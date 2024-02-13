using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YY.PersonelTakip.BLL.Managers;
using YY.PersonelTakip.BLL.Services;
using YY.PersonelTakip.DAL.Context;
using YY.PersonelTakip.DAL.Repository;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.UI.Forms
{

    public partial class PersonelOzluk : Form
    {
        public MainForm mainForm;
        Personel p = new Personel();
        string path1, path2, path3, path4, path5, path6, path7, path8;
        IOzlukService ozlukService = new OzlukManager(new GenericRepository<OzlukBilgi>(new PersonelAppContext()));
        public PersonelOzluk()
        {
            InitializeComponent();

        }


        byte[] ConvertImageToByteArray(string imagePath)
        {
            using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    return reader.ReadBytes((int)stream.Length);
                }
            }
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null;
            }

            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                try
                {
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that might occur during image conversion.
                    // For example, the input byte array may not represent a valid image.
                    Console.WriteLine("Error converting byte array to image: " + ex.Message);
                    return null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPersonelService personelService = new PersonelManager(new GenericRepository<Personel>(new PersonelAppContext()));
            using (Image resim = ByteArrayToImage(p.Foto))
            {
                if (resim != null)
                {
                    pictureBox1.Image = new Bitmap(resim);
                }
                else
                {
                    label9.Text = "Resim Yok.";
                }
            }
            LoadListBox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PersonelOzluk_Load(object sender, EventArgs e)
        {
            mainForm.personelDoldur(listBox2);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            OzlukBilgi ozlukBilgi = new OzlukBilgi()
            {
                PersonelId = p.PersonelId,
                Ikametgah = textBox2.Text,
                BaslangicTarihi = dateTimePicker1.Value,
                SaglikRaporu = ConvertImageToByteArray(path1),
                AdliSicilBelgesi = ConvertImageToByteArray(path2),
                SirketSozlesmesi = ConvertImageToByteArray(path3),
                Cv = ConvertImageToByteArray(path4),
                Ehliyet = ConvertImageToByteArray(path5),
                AskerlikBelgesi = ConvertImageToByteArray(path6),
                EvlilikCüzdanı = ConvertImageToByteArray(path7),
                IsBasvurusu = ConvertImageToByteArray(path8)
            };
            ozlukService.Add(ozlukBilgi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path1 = openFileDialog1.FileName;
                button1.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path2 = openFileDialog1.FileName;
                button2.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path3 = openFileDialog1.FileName;
                button5.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path4 = openFileDialog1.FileName;
                button6.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path5 = openFileDialog1.FileName;
                button4.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }

        }

        void LoadListBox()
        {
            var o = ozlukService.GetAll().Where(a => a.PersonelId == p.PersonelId);

            foreach (var a in o)
            {
                listBox1.Items.Add(a.Ehliyet.ToString());
                listBox1.Items.Add(a.IsBasvurusu.ToString());
                listBox1.Items.Add(a.AdliSicilBelgesi.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path6 = openFileDialog1.FileName;
                button9.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path7 = openFileDialog1.FileName;
                button11.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select file";
            openFileDialog1.InitialDirectory = @"c:\";//--"c:\\";
            openFileDialog1.Filter = "JPG (*.jpg;*.jpeg)|*.jpg;*jpeg|PNG(*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                path8 = openFileDialog1.FileName;
                button10.Enabled = false;
            }
            else
            { MessageBox.Show("you didn't select the file!"); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ByteArrayToImage()
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = listBox2.SelectedItem.ToString();
            string tc = temp.Split(" ")[0];
            Personel ptemp = mainForm.personelService.Get(tc);
        }
    }
}
