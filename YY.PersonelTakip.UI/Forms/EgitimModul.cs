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
    public partial class EgitimModul : Form
    {
        public MainForm mainForm;
        string path1, path2, path3;
        Personel p = new Personel();
        public EgitimModul()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            IPersonelService personelService = new PersonelManager(new GenericRepository<Personel>(new PersonelAppContext()));

            using (Image resim = mainForm.ByteArrayToImage(p.Foto))
            {
                if (resim != null)
                {
                    pictureBox1.Image = new Bitmap(resim);
                }
                else
                {
                    label8.Text = "Resim Yok.";
                }
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            IEgitimService egitimService = new EgitimManager(new GenericRepository<Egitim>(new PersonelAppContext()));
            EgitimBilgi egitimBilgi = new EgitimBilgi()
            {
                Ilkokul = textBox1.Text,
                Lise = textBox2.Text,
                Uni = textBox3.Text,
                UniBelge = mainForm.ConvertImageToByteArray(path1),
                Doktora = textBox4.Text,
                DoktoraBelge = mainForm.ConvertImageToByteArray(path2),
                Yuksek = textBox5.Text,
                YuksekBelge = mainForm.ConvertImageToByteArray(path3),
                PersonelId = p.PersonelId
            };
        }

        private void EgitimModul_Load(object sender, EventArgs e)
        {
            mainForm.personelDoldur(listBox2);
        }
    }
}
