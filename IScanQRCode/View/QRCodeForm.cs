using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode.Internal;

namespace IScanQRCode.View
{
    /// <summary>
    ///  Generate QRCode Form
    /// author: netsail
    /// time: 2016-11-15 22:00
    /// </summary>
    public partial class QRCodeForm : Form
    {
        public QRCodeForm(string qrText,int size)
        {
            InitializeComponent();
            pictureBox1.Size = new Size(size, size);
            GenerateQRCode(qrText,size);
        }

        private void GenerateQRCode(string qrText,int size)
        {
            QRCode code = ZXing.QrCode.Internal.Encoder.encode(qrText, ErrorCorrectionLevel.M);
            ByteMatrix m = code.Matrix;
            int blockSize = Math.Max(size / m.Height, 1);//
            Bitmap drawArea = new Bitmap((m.Width * blockSize), (m.Height * blockSize));
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(Color.White);
                using (Brush b = new SolidBrush(Color.Black))
                {
                    for (int row = 0; row < m.Width; row++)
                    {
                        for (int col = 0; col < m.Height; col++)
                        {
                            if (m[row, col] != 0)
                            {
                                g.FillRectangle(b, blockSize * row, blockSize * col, blockSize, blockSize);
                            }
                        }
                    }
                }
            }
            pictureBox1.Image = drawArea;
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs =
    (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }
    }
}
