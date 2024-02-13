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
    public partial class PersonelAyarlarModul : Form
    {
        public MainForm mainForm;
        Personel p = new Personel();

        




        public PersonelAyarlarModul()
        {
            InitializeComponent();

            var data = mainForm.departmanService.GetAll();
            foreach (var item in data)
            {
                comboBox1.Items.Add(item.Aciklama);
            }

            var data2 = mainForm.KidemService.GetAll();
            foreach (var item in data2)
            {
                comboBox3.Items.Add(item.Aciklama);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            p = mainForm.personelService.Get(textBox1.Text);
            label2.Text = p.Ad;
            label5.Text = p.Soyad;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            PersonelAyar personelAyar = new PersonelAyar()
            {
                DepartmanID = comboBox1.SelectedIndex,
                KidemID = comboBox3.SelectedIndex,
                PersonelId = p.PersonelId
            };
            try
            {
                mainForm.personelAyarService.Add(personelAyar);
                MessageBox.Show("Başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem");
                throw;
            }
            
        }
    }
}
