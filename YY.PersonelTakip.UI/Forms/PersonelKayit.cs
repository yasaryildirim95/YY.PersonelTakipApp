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
using YY.PersonelTakip.DAL.Abstract;
using YY.PersonelTakip.DAL.Context;
using YY.PersonelTakip.DAL.Repository;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.UI.Forms
{
    public partial class PersonelKayit : Form
    {
        public MainForm mainForm;
        string img_path = string.Empty;
        Personel ptemp = new Personel();
        
        public PersonelKayit()
        {
            InitializeComponent();
        }

        

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            void ControlTC()
            {

            }

            try
            {
                Personel p = new Personel()
                {
                    Ad = textBox1.Text,
                    Soyad = textBox2.Text,
                    DogumTarihi = (dateTimePicker1).Value,
                    AnneAdi = textBox4.Text,
                    BabaAdi = textBox5.Text,
                    MedeniDurum = comboBox2.SelectedItem?.ToString(),
                    SehirId = comboBox1.SelectedIndex + 1,
                    Tc = textBox9.Text,
                    Foto = mainForm.ConvertImageToByteArray(img_path)
                };

                mainForm.personelService.Add(p);
                MessageBox.Show("Başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                img_path = openFileDialog1.FileName;
                MessageBox.Show(img_path);
                using (Image resim = Image.FromFile($"{img_path}"))
                {
                    pictureBox1.Image = new Bitmap(resim);
                }
            }
            else
            { MessageBox.Show("you didn't select the file!"); }
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {
            var data = mainForm.sehirService.GetAll();
            foreach (var item in data)
            {
                comboBox1.Items.Add(item.SehirName);
            }

            mainForm.personelDoldur(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEkle.Enabled = false;
            string temp = listBox1.SelectedItem.ToString();
            string tc = temp.Split(" ")[0];
            ptemp = mainForm.personelService.Get(tc);
            textBox9.Text = ptemp.Tc;
            textBox1.Text = ptemp.Ad;
            textBox2.Text = ptemp.Soyad;
            dateTimePicker1.Value = ptemp.DogumTarihi;
            textBox4.Text = ptemp.AnneAdi;
            textBox5.Text = ptemp.BabaAdi;
            comboBox1.SelectedIndex = ptemp.SehirId;
            comboBox2.Text = ptemp.MedeniDurum.ToString();
            using (Image resim = mainForm.ByteArrayToImage(ptemp.Foto))
            {
                pictureBox1.Image = new Bitmap(resim);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ptemp.Ad = textBox1.Text;
                ptemp.Soyad = textBox2.Text;
                ptemp.DogumTarihi = (dateTimePicker1).Value;
                ptemp.AnneAdi = textBox4.Text;
                ptemp.BabaAdi = textBox5.Text;
                ptemp.MedeniDurum = comboBox2.SelectedItem?.ToString();
                ptemp.SehirId = comboBox1.SelectedIndex;
                ptemp.Tc = textBox9.Text;
                //ptemp.Foto = ConvertImageToByteArray(img_path);

                mainForm.personelService.Update(ptemp);
                MessageBox.Show("Güncelleme Başarılı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
    }
}
