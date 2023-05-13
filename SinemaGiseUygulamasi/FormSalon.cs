using BusinessLayer.Concrete;
using EntityLayer;
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
    public partial class FormSalon : Form
    {
        public FormSalon()
        {
            InitializeComponent();
        }

        TheaterManager manager = new TheaterManager();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Theater theater = new Theater();
            theater.Numarasi = tbxSalonAdi.Text;
            theater.KoltukSayisi = Convert.ToInt32(tbxKoltukSayisi.Text);

            string mesaj = manager.TheaterAddBL(theater);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Theater theater = new Theater();
                theater.Id = Convert.ToInt32(tbxId.Text);
                theater.Numarasi = tbxSalonAdi.Text;
                theater.KoltukSayisi = Convert.ToInt32(tbxKoltukSayisi.Text);

                string mesaj = manager.TheaterUpdateBL(theater);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != string.Empty)
            {
                manager.TheaterDeleteBL(Convert.ToInt32(tbxId.Text));

                MessageBox.Show("Kayıt silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxSalonAdi.Clear();
            tbxKoltukSayisi.Clear();
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxSalonAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxKoltukSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
