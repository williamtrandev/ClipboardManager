using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardManager
{
    public partial class MainForm : Form
    {
        // Stack để lưu text chị copy nè
        private Stack<ClipboardItem> clipboardItems = new Stack<ClipboardItem>();

        private string lastClipboardText = string.Empty;

        private const int WM_HOTKEY = 0x0312;
        private const int MOD_CTRL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private int hotkeyId = 1;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Hằng số cho việc di chuyển form.
        // Mấy cái hằng số và hàm này chị không cần quan tâm, nó là API của windows để hỗ trợ kéo form thôi. 
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            StartClipboardMonitoring();
            RegisterGlobalHotkeys();

            titleBar.MouseDown += (sender, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
        }

        private void UpdateClipboardListView()
        {
            clipboardDataGridView.Rows.Clear();

            // Hiển thị các mục từ stack (mới nhất ở trên cùng)
            foreach (var item in clipboardItems)
            {
                // Cắt nội dung nếu quá dài
                string preview = item.Content.Length > 50
                    ? item.Content.Substring(0, 50) + "..."
                    : item.Content;

                // Loại bỏ các ký tự xuống dòng để hiển thị tốt hơn
                preview = preview.Replace("\r\n", " ").Replace("\n", " ");

                clipboardDataGridView.Rows.Add(preview, item.Timestamp.ToString("HH:mm:ss dd/MM/yyyy"));
            }
        }

        private void StartClipboardMonitoring()
        {
            // Thêm sự kiện cho clipboard. Cái này để quét clipboard của windows, nếu có thực hiện copy mới sẽ update danh sách lại
            Timer clipboardTimer = new Timer
            {
                Interval = 500 // Kiểm tra mỗi nửa giây
            };
            clipboardTimer.Tick += ClipboardTimer_Tick;
            clipboardTimer.Start();
        }

        private void AddClipboardItem(string content)
        {
            // Tạo một mục clipboard mới
            ClipboardItem item = new ClipboardItem
            {
                Content = content,
                Timestamp = DateTime.Now
            };

            // Thêm vào stack
            clipboardItems.Push(item);

            // Cập nhật giao diện
            UpdateClipboardListView();
        }

        private void ClipboardTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    string currentText = Clipboard.GetText();
                    if (!string.IsNullOrEmpty(currentText) && currentText != lastClipboardText)
                    {
                        lastClipboardText = currentText;
                        AddClipboardItem(currentText);
                    }
                }
            }
            catch (Exception ex)
            {
                // Bỏ qua lỗi clipboard
                Console.WriteLine("Clipboard error: " + ex.Message);
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            Guna2MessageDialog confirmDialog = new Guna2MessageDialog
            {
                Caption = "Xác nhận",
                Text = "Bạn có chắc chắn muốn xóa tất cả nội dung clipboard?",
                Icon = MessageDialogIcon.Question,
                Style = MessageDialogStyle.Dark,
                Buttons = MessageDialogButtons.YesNo,
                Parent = this
            };

            if (confirmDialog.Show() == DialogResult.Yes)
            {
                clipboardItems.Clear();
                UpdateClipboardListView();
            }
        }

        private void RegisterGlobalHotkeys()
        {
            // Đăng ký phím tắt Ctrl+Shift+V
            RegisterHotKey(this.Handle, hotkeyId, MOD_CTRL | MOD_SHIFT, (int)Keys.V);
        }

        protected override void WndProc(ref Message m)
        {
            // Xử lý phím tắt
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == hotkeyId)
            {
                this.Visible = !this.Visible;
                if (this.Visible)
                {
                    this.Activate();
                    this.BringToFront();
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Hủy đăng ký phím tắt khi form đóng
            UnregisterHotKey(this.Handle, hotkeyId);
            base.OnFormClosing(e);
        }

        private void clipboardDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mục từ stack
                ClipboardItem[] itemsArray = clipboardItems.ToArray();
                if (e.RowIndex < itemsArray.Length)
                {
                    // Hiển thị nội dung đầy đủ trong một dialog
                    ShowContentDialog(itemsArray[e.RowIndex]);
                }
            }
        }

        private void ShowContentDialog(ClipboardItem item)
        {
            // Cập nhật nội dung
            ClipboardDetailForm.Instance.SetClipboardText(item.Content);

            // Hiển thị dialog
            ClipboardDetailForm.Instance.ShowDialog();
        }

    }
    public class ClipboardItem
    {
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
