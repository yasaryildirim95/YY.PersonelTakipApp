using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using YY.PersonelTakip.BLL.Managers;
using YY.PersonelTakip.BLL.Services;
using YY.PersonelTakip.DAL.Context;
using YY.PersonelTakip.DAL.Repository;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.UI.Forms
{
    public partial class izinModul : Form
    {
        public MainForm mainForm;
        Personel p = new Personel();
        public izinModul()
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

        private void button5_Click(object sender, EventArgs e)
        {
            IPersonelService personelService = new PersonelManager(new GenericRepository<Personel>(new PersonelAppContext()));

            p = personelService.Get(textBox6.Text);
            label4.Text += $"{p.Ad + " " + p.Soyad}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IizinService iizinService = new IzinManager(new GenericRepository<KullanilanIzin>(new PersonelAppContext()));
            KullanilanIzin kullanilanIzin = new KullanilanIzin()
            {
                BaslangicTarihi = dateTimePicker1.Value,
                BitisTarihi = dateTimePicker2.Value,
                PersonelId = p.PersonelId
            };

            iizinService.Add(kullanilanIzin);

        }
    }
}
