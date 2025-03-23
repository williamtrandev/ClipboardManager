namespace ClipboardManager
{
    partial class ClipboardDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dialogMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dialogContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.contentTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dialogTitleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.dialogCloseButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dialogTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dialogMainPanel.SuspendLayout();
            this.dialogContentPanel.SuspendLayout();
            this.dialogTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogMainPanel
            // 
            this.dialogMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.dialogMainPanel.BorderRadius = 15;
            this.dialogMainPanel.Controls.Add(this.dialogContentPanel);
            this.dialogMainPanel.Controls.Add(this.dialogTitleBar);
            this.dialogMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogMainPanel.Location = new System.Drawing.Point(0, 0);
            this.dialogMainPanel.Name = "dialogMainPanel";
            this.dialogMainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.dialogMainPanel.ShadowDecoration.BorderRadius = 15;
            this.dialogMainPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.dialogMainPanel.ShadowDecoration.Depth = 10;
            this.dialogMainPanel.ShadowDecoration.Enabled = true;
            this.dialogMainPanel.Size = new System.Drawing.Size(484, 361);
            this.dialogMainPanel.TabIndex = 0;
            // 
            // dialogContentPanel
            // 
            this.dialogContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.dialogContentPanel.Controls.Add(this.contentTextBox);
            this.dialogContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogContentPanel.Location = new System.Drawing.Point(10, 50);
            this.dialogContentPanel.Name = "dialogContentPanel";
            this.dialogContentPanel.Padding = new System.Windows.Forms.Padding(10);
            this.dialogContentPanel.Size = new System.Drawing.Size(464, 301);
            this.dialogContentPanel.TabIndex = 1;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.contentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contentTextBox.DefaultText = "";
            this.contentTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contentTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contentTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contentTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.contentTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.contentTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contentTextBox.Location = new System.Drawing.Point(10, 10);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.PlaceholderText = "";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.SelectedText = "";
            this.contentTextBox.Size = new System.Drawing.Size(444, 281);
            this.contentTextBox.TabIndex = 0;
            // 
            // dialogTitleBar
            // 
            this.dialogTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.dialogTitleBar.BorderRadius = 15;
            this.dialogTitleBar.Controls.Add(this.dialogCloseButton);
            this.dialogTitleBar.Controls.Add(this.dialogTitle);
            this.dialogTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dialogTitleBar.Location = new System.Drawing.Point(10, 10);
            this.dialogTitleBar.Name = "dialogTitleBar";
            this.dialogTitleBar.Size = new System.Drawing.Size(464, 40);
            this.dialogTitleBar.TabIndex = 0;
            // 
            // dialogCloseButton
            // 
            this.dialogCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogCloseButton.FillColor = System.Drawing.Color.Transparent;
            this.dialogCloseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.dialogCloseButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dialogCloseButton.Location = new System.Drawing.Point(418, 7);
            this.dialogCloseButton.Name = "dialogCloseButton";
            this.dialogCloseButton.Size = new System.Drawing.Size(30, 30);
            this.dialogCloseButton.TabIndex = 1;
            // 
            // dialogTitle
            // 
            this.dialogTitle.BackColor = System.Drawing.Color.Transparent;
            this.dialogTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dialogTitle.Location = new System.Drawing.Point(15, 10);
            this.dialogTitle.Name = "dialogTitle";
            this.dialogTitle.Size = new System.Drawing.Size(139, 22);
            this.dialogTitle.TabIndex = 0;
            this.dialogTitle.Text = "Nội dung Clipboard";
            // 
            // ClipboardDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dialogMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClipboardDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nội dung Clipboard";
            this.dialogMainPanel.ResumeLayout(false);
            this.dialogContentPanel.ResumeLayout(false);
            this.dialogTitleBar.ResumeLayout(false);
            this.dialogTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dialogMainPanel;
        private Guna.UI2.WinForms.Guna2Panel dialogTitleBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel dialogTitle;
        private Guna.UI2.WinForms.Guna2Panel dialogContentPanel;
        private Guna.UI2.WinForms.Guna2TextBox contentTextBox;
        private Guna.UI2.WinForms.Guna2ControlBox dialogCloseButton;
    }
}