using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace IScanQRCode.View
{
    /// <summary>
    /// Scan QRCode Main Form
    /// author: netsail
    /// time: 2016-11-15 22:00
    /// </summary>
    public partial class MainForm : Form
    {
        private string qrcodeText = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }
        void splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            QRCodeResultTextBox.Text = qrcodeText;
            this.Show();
            this.Activate();
        }
        private void ScanQRCodeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Screen screen in Screen.AllScreens)
            {
                using (Bitmap fullImage = new Bitmap(screen.Bounds.Width,
                                                screen.Bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(fullImage))
                    {
                        g.CopyFromScreen(screen.Bounds.X,
                                         screen.Bounds.Y,
                                         0, 0,
                                         fullImage.Size,
                                         CopyPixelOperation.SourceCopy);
                    }
                    int maxTry = 10;
                    for (int i = 0; i < maxTry; i++)
                    {
                        int marginLeft = (int)((double)fullImage.Width * i / 2.5 / maxTry);
                        int marginTop = (int)((double)fullImage.Height * i / 2.5 / maxTry);
                        Rectangle cropRect = new Rectangle(marginLeft, marginTop, fullImage.Width - marginLeft * 2, fullImage.Height - marginTop * 2);
                        Bitmap target = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);

                        double imageScale = (double)screen.Bounds.Width / (double)cropRect.Width;
                        using (Graphics g = Graphics.FromImage(target))
                        {
                            g.DrawImage(fullImage, new Rectangle(0, 0, target.Width, target.Height),
                                            cropRect,
                                            GraphicsUnit.Pixel);
                        }
                        var source = new BitmapLuminanceSource(target);
                        var bitmap = new BinaryBitmap(new HybridBinarizer(source));
                        QRCodeReader reader = new QRCodeReader();
                        var result = reader.decode(bitmap);
                        if (result != null)
                        {
                            QRCodeSplashForm splash = new QRCodeSplashForm();
                            this.qrcodeText = result.Text;
                            this.QRCodeResultTextBox.Text = string.Empty;
                            splash.FormClosed += splash_FormClosed;
                            double minX = Int32.MaxValue, minY = Int32.MaxValue, maxX = 0, maxY = 0;
                            foreach (ResultPoint point in result.ResultPoints)
                            {
                                minX = Math.Min(minX, point.X);
                                minY = Math.Min(minY, point.Y);
                                maxX = Math.Max(maxX, point.X);
                                maxY = Math.Max(maxY, point.Y);
                            }
                            minX /= imageScale;
                            minY /= imageScale;
                            maxX /= imageScale;
                            maxY /= imageScale;
                            // make it 20% larger
                            double margin = (maxX - minX) * 0.20f;
                            minX += -margin + marginLeft;
                            maxX += margin + marginLeft;
                            minY += -margin + marginTop;
                            maxY += margin + marginTop;
                            splash.Location = new Point(screen.Bounds.X, screen.Bounds.Y);
                            // we need a panel because a window has a minimal size
                            // TODO: test on high DPI
                            splash.TargetRect = new Rectangle((int)minX + screen.Bounds.X, (int)minY + screen.Bounds.Y, (int)maxX - (int)minX, (int)maxY - (int)minY);
                            splash.Size = new Size(fullImage.Width, fullImage.Height);
                            splash.Show();
                            return;
                        }
                    }
                }
            }
            MessageBox.Show(("No QRCode found. Try to zoom in or move it to the center of the screen."));
            this.Show();
            this.Activate();
        }

        private void QRCodeResultTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void GenerateQRCodeButton_Click(object sender, EventArgs e)
        {
            QRCodeForm qrcodeForm = new QRCodeForm(this.QRCodeResultTextBox.Text, Decimal.ToInt32( this.QRCodeSize.Value));
            qrcodeForm.Show();
            qrcodeForm.Activate();
        }


    }
}
