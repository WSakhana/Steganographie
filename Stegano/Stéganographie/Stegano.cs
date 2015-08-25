using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjet_Stéganographie
{
    public partial class Stegano : Form
    {
        public Stegano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image File (*.png, *.jpg)|*.png;*.jpg";
            openDialog.InitialDirectory = @"C:\";

            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = txtPath.Text;

            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Bitmap img ;

            try
            {
                 img = new Bitmap(txtPath.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Veillez Choisir une Image !");
                return;
            }
            if (txtMessage.TextLength < 1)
            {
                MessageBox.Show("Veillez entrer un Message !");
            }


            if (!Steganographie.encoder(img, txtMessage.Text))
            {
                MessageBox.Show("Erreur");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Extention JPEG(*.jpg)|*.jpg |Extention PNG(*.png)|*.png";
            save.InitialDirectory = @"C:\";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = save.FileName;
                pictureBox1.ImageLocation = txtPath.Text;
                img.Save(txtPath.Text, ImageFormat.Png);
                MessageBox.Show("Enregistrer Avec succés !");
            }
            

        }

        private void btnDecoder_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(txtPath.Text);

            txtMsgDecoder.Text = Steganographie.decoder(img);
            MessageBox.Show("Message récuperer.");
        }


    }
}
