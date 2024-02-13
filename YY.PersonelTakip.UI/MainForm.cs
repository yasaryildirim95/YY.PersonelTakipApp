using System;
using System.Windows.Forms;
using YY.PersonelTakip.BLL.Managers;
using YY.PersonelTakip.BLL.Services;
using YY.PersonelTakip.DAL.Context;
using YY.PersonelTakip.DAL.Repository;
using YY.PersonelTakip.Entity.Entities;
using YY.PersonelTakip.UI.Forms;

namespace YY.PersonelTakip.UI
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public IPersonelAyarService personelAyarService = new PersonelAyarManager(new GenericRepository<PersonelAyar>(new PersonelAppContext()));
        public IDepartmanService departmanService = new DepartmanManager(new GenericRepository<Departman>(new PersonelAppContext()));
        public IKidemService KidemService = new KidemManager(new GenericRepository<Kidem>(new PersonelAppContext()));
        public ISehirService sehirService = new SehirManager(new GenericRepository<Sehir>(new PersonelAppContext()));
        public IPersonelService personelService = new PersonelManager(new GenericRepository<Personel>(new PersonelAppContext()));

        public MainForm()
        {
            InitializeComponent();
        }
        public byte[] ConvertImageToByteArray(string imagePath)
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

        public void personelDoldur(ListBox listBox)
        {
            var data2 = personelService.GetAll();
            foreach (var item in data2)
            {
                listBox.Items.Add(item.Tc + " " + item.Ad + " " + item.Soyad);
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelCenter.Controls.Add(childForm);
            this.panelCenter.Tag = childForm;
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelKayit personelKayit = new PersonelKayit();
            personelKayit.mainForm = this;
            OpenChildForm(personelKayit, sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelOzluk personelOzluk = new PersonelOzluk();
            personelOzluk.mainForm = this;
            OpenChildForm(personelOzluk, sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EgitimModul egitimModul = new EgitimModul();
            egitimModul.mainForm = this;
            OpenChildForm(egitimModul, sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            izinModul izinModul = new izinModul();
            izinModul.mainForm = this;
            OpenChildForm(izinModul, sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MaasModul maasModul = new MaasModul();
            maasModul.mainForm = this;
            OpenChildForm(maasModul, sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AvansModul avansModul = new AvansModul();
            avansModul.mainForm = this;
            OpenChildForm(avansModul, sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BordroModul bordroModul = new BordroModul();
            bordroModul.MainForm = this;
            OpenChildForm(bordroModul, sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PersonelAyarlarModul personelAyarlarModul = new PersonelAyarlarModul();
            personelAyarlarModul.mainForm = this;
            OpenChildForm(personelAyarlarModul, sender);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}