using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Marilucy
{
    public partial class gestorqrform : Form
    {
        public gestorqrform()
        {
            InitializeComponent();
            btnguardar.Enabled = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtvalor.Text.Trim(),out qrCode) ;
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400,QuietZoneModules.Zero),Brushes.Black,Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png,ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(200,200)));
            imgqr.BackgroundImage = image;
            image.Save("imagen.png", ImageFormat.Png);
            btnguardar.Enabled = true;
            txtvalor.Text = "";

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Image image = (Image)imgqr.BackgroundImage.Clone();
            SaveFileDialog CajaDialogoGuardar = new SaveFileDialog();
            CajaDialogoGuardar.AddExtension = true;
            CajaDialogoGuardar.Filter = "Image PNG(*.png)|*.png";
            CajaDialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDialogoGuardar.FileName))
            {
                image.Save(CajaDialogoGuardar.FileName, ImageFormat.Png);
            }
            image.Dispose();
        }
    }
}
