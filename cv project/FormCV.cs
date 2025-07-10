
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;


namespace CV_Project
{
    public partial class FormCV : Form
    {
        public FormCV()
        {
            InitializeComponent();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(
                "=== PROFIL ===" + Environment.NewLine +
                "Nama: Fulan" + Environment.NewLine +
                "TTL: Purwokerto, 1 Januari 2000" + Environment.NewLine +
                "Alamat: Jl. Contoh No.123" + Environment.NewLine + Environment.NewLine
            );
        }

        private void btnPendidikan_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(
                "=== PENDIDIKAN ===" + Environment.NewLine +
                "SD Contoh (2006–2012)" + Environment.NewLine +
                "SMP Contoh (2012–2015)" + Environment.NewLine +
                "SMA Contoh (2015–2018)" + Environment.NewLine +
                "Universitas AMIKOM Purwokerto (2018–2022)" + Environment.NewLine + Environment.NewLine
            );
        }

        private void btnPengalaman_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(
                "=== PENGALAMAN ===" + Environment.NewLine +
                "Magang di PT. Teknologi" + Environment.NewLine +
                "Freelance Web Developer" + Environment.NewLine + Environment.NewLine
            );
        }

        private void btnKeahlian_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(
                "=== KEAHLIAN ===" + Environment.NewLine +
                "Bahasa: C#, PHP, JavaScript" + Environment.NewLine +
                "Database: MySQL, SQL Server" + Environment.NewLine + Environment.NewLine
            );
        }

        private void btnKontak_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(
                "=== KONTAK ===" + Environment.NewLine +
                "Email: fulan@example.com" + Environment.NewLine +
                "HP: 081234567890" + Environment.NewLine +
                "LinkedIn: linkedin.com/in/fulan" + Environment.NewLine + Environment.NewLine
            );
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            saveFile.Title = "Simpan CV sebagai Gambar";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Gunakan Panel yang membungkus txtOutput + pictureBox1
                Bitmap bmp = new Bitmap(panelCV.Width, panelCV.Height);
                panelCV.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panelCV.Width, panelCV.Height));

                // Simpan file
                if (Path.GetExtension(saveFile.FileName).ToLower() == ".jpg")
                {
                    bmp.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    bmp.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }

                MessageBox.Show("CV dan gambar berhasil disimpan.");
            }
        }


        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CV_Saya.pdf");

            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "CV Sederhana";
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
            XFont boldFont = new XFont("Verdana", 12, XFontStyle.Bold);

            double margin = 40;
            double imageWidth = 150;
            double imageHeight = 200;

            // Jika ada gambar, letakkan di kanan atas
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;
                    XImage image = XImage.FromStream(ms);

                    gfx.DrawImage(image, page.Width - imageWidth - margin, margin, imageWidth, imageHeight);
                }
            }

            // Buat text formatter
            XTextFormatter tf = new XTextFormatter(gfx);

            double textWidth = page.Width - imageWidth - margin * 3; // area kiri dari gambar
            double x = margin;
            double y = margin;
            double lineHeight = font.GetHeight() + 5;

            string[] lines = txtOutput.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                bool isHeading = line.StartsWith("===");
                tf.DrawString(line, isHeading ? boldFont : font, XBrushes.Black,
                    new XRect(x, y, textWidth, page.Height), XStringFormats.TopLeft);
                y += lineHeight;
            }

            doc.Save(path);
            MessageBox.Show("CV berhasil diexport ke PDF di: " + path);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            pictureBox1.Image = null;
        }

  
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
