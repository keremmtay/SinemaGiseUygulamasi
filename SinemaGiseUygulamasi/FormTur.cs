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
    public partial class FormTur : Form
    {
        public FormTur()
        {
            InitializeComponent();
        }

        GenreManager manager = new GenreManager();

        private void FormTur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre();
            genre.Adi = tbxTurAdi.Text;
            genre.YasSiniri = Convert.ToInt32(tbxYasSiniri.Text);

            string mesaj = manager.GenreAddBL(genre);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != string.Empty)
            {
                manager.GenreDeleteBL(Convert.ToInt32(tbxId.Text));

                MessageBox.Show("Kayıt silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Genre genre = new Genre();
                genre.Id = Convert.ToInt32(tbxId.Text);
                genre.Adi = tbxTurAdi.Text;
                genre.YasSiniri = Convert.ToInt32(tbxYasSiniri.Text);

                string mesaj = manager.GenreUpdateBL(genre);

                MessageBox.Show(mesaj);

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.");
            }
        }

        private void btnFormuTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxTurAdi.Clear();
            tbxYasSiniri.Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxTurAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxYasSiniri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
