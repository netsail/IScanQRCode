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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ScanQRCodeButton = new System.Windows.Forms.Button();
            this.QRCodeResultTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateQRCodeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QRCodeSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeSize)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 297);
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
            this.QRCodeResultTextBox.Location = new System.Drawing.Point(3, 33);
            this.QRCodeResultTextBox.Name = "QRCodeResultTextBox";
            this.QRCodeResultTextBox.Size = new System.Drawing.Size(366, 261);
            this.QRCodeResultTextBox.TabIndex = 1;
            this.QRCodeResultTextBox.Text = "";
            this.QRCodeResultTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.QRCodeResultTextBox_LinkClicked);
            // 
            // GenerateQRCodeButton
            // 
            this.GenerateQRCodeButton.Location = new System.Drawing.Point(112, 3);
            this.GenerateQRCodeButton.Name = "GenerateQRCodeButton";
            this.GenerateQRCodeButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateQRCodeButton.TabIndex = 1;
            this.GenerateQRCodeButton.Text = "生成二维码";
            this.GenerateQRCodeButton.UseVisualStyleBackColor = true;
            this.GenerateQRCodeButton.Click += new System.EventHandler(this.GenerateQRCodeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "大小：";
            // 
            // QRCodeSize
            // 
            this.QRCodeSize.Location = new System.Drawing.Point(234, 6);
            this.QRCodeSize.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.QRCodeSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QRCodeSize.Name = "QRCodeSize";
            this.QRCodeSize.Size = new System.Drawing.Size(61, 21);
            this.QRCodeSize.TabIndex = 5;
            this.QRCodeSize.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "px";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QRCodeSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateQRCodeButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "IScanQRCode-v1.0 netsail@gmail.com";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ScanQRCodeButton;
        private System.Windows.Forms.RichTextBox QRCodeResultTextBox;
        private System.Windows.Forms.Button GenerateQRCodeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QRCodeSize;
        private System.Windows.Forms.Label label2;
    }
}