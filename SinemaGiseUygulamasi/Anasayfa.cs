using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaGiseUygulamasi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void tsbtnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGetir(Form form)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(form);

            form.FormBorderStyle = FormBorderStyle.None;

            form.Show();
        }

        private void tsbtnFilmler_Click(object sender, EventArgs e)
        {
            FormFilm form = new FormFilm();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void tsbtnSalonlar_Click(object sender, EventArgs e)
        {
            FormSalon form = new FormSalon();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void tsbtnTurler_Click(object sender, EventArgs e)
        {
            FormTur form = new FormTur();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void tsbtnKoltuklar_Click(object sender, EventArgs e)
        {
            FormKoltuk form = new FormKoltuk();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void tsbtnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteri form = new FormMusteri();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void tsbtnPersonel_Click(object sender, EventArgs e)
        {
            FormPersonel form = new FormPersonel();

            form.MdiParent = this;

            FormGetir(form);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormIslem form = new FormIslem();

            form.MdiParent = this;

            FormGetir(form);
        }
    }
}
