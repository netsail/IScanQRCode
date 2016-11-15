namespace IScanQRCode.View
{
    /// <summary>
    /// Scan QRCode Main Form
    /// author: netsail
    /// time: 2016-11-15 22:00
    /// </summary>
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScanQRCodeButton = new System.Windows.Forms.Button();
            this.QRCodeResultTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ScanQRCodeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QRCodeResultTextBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.24735F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.75265F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ScanQRCodeButton
            // 
            this.ScanQRCodeButton.Location = new System.Drawing.Point(3, 3);
            this.ScanQRCodeButton.Name = "ScanQRCodeButton";
            this.ScanQRCodeButton.Size = new System.Drawing.Size(101, 22);
            this.ScanQRCodeButton.TabIndex = 0;
            this.ScanQRCodeButton.Text = "点击获取二维码";
            this.ScanQRCodeButton.UseVisualStyleBackColor = true;
            this.ScanQRCodeButton.Click += new System.EventHandler(this.ScanQRCodeButton_Click);
            // 
            // QRCodeResultTextBox
            // 
            this.QRCodeResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QRCodeResultTextBox.Location = new System.Drawing.Point(3, 31);
            this.QRCodeResultTextBox.Name = "QRCodeResultTextBox";
            this.QRCodeResultTextBox.Size = new System.Drawing.Size(427, 249);
            this.QRCodeResultTextBox.TabIndex = 1;
            this.QRCodeResultTextBox.Text = "";
            this.QRCodeResultTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.QRCodeResultTextBox_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "IScanQRCode-v1.0 netsail@gmail.com";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ScanQRCodeButton;
        private System.Windows.Forms.RichTextBox QRCodeResultTextBox;
    }
}