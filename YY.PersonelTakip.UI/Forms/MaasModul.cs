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
    public partial class MaasModul : Form
    {
        public MainForm mainForm;
        public MaasModul()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            Kidem kidem = new Kidem();
            Departman departman = new Departman();
            IPersonelService personelService = new PersonelManager(new GenericRepository<Personel>(new PersonelAppContext()));
            p = personelService.Get(textBox1.Text);
            IPersonelAyarService personelAyarService = new PersonelAyarManager(new GenericRepository<PersonelAyar>(new PersonelAppContext()));

            PersonelAyar personelAyar = new PersonelAyar();
            personelAyar = personelAyarService.GetAll().Where(a=>a.PersonelId == p.PersonelId).FirstOrDefault();
            IDepartmanService departmanService = new DepartmanManager(new GenericRepository<Departman>(new PersonelAppContext()));
            IKidemService KidemService = new KidemManager(new GenericRepository<Kidem>(new PersonelAppContext()));
            departman = departmanService.GetAll().Where(a=>a.DepartmanId == personelAyar.DepartmanID).FirstOrDefault();
            kidem = KidemService.GetAll().Where(a=>a.KidemId == personelAyar.KidemID).FirstOrDefault();
            label1.Text = (kidem.Maas + departman.Maas).ToString();

        }
    }
}
