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
    public partial class FormFilm : Form
    {
        public FormFilm()
        {
            InitializeComponent();
        }

        MovieManager movieManager = new MovieManager();

        private void FormFilm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = movieManager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Adi = tbxAdi.Text,
                Sure = Convert.ToInt32(tbxSuresi.Text),
                CikisTarihi = Convert.ToDateTime(dtpVizyon.Text),
                Aciklama = tbxKonu.Text,
            };

            string mesaj = movieManager.MovieAddBL(movie);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxAdi.Clear();
            tbxKonu.Clear();
            tbxSuresi.Clear();
            dtpVizyon.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Movie movie = new Movie();
                movie.Id = Convert.ToInt32(tbxId.Text);
                movie.Adi = tbxAdi.Text;
                movie.CikisTarihi = Convert.ToDateTime(dtpVizyon.Text);
                movie.Aciklama = tbxKonu.Text;
                movie.Sure = Convert.ToInt32(tbxSuresi.Text);   

                string mesaj = movieManager.MovieUpdateBL(movie);

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != string.Empty)
            {
                movieManager.MovieDeleteBL(Convert.ToInt32(tbxId.Text));

                MessageBox.Show("Kayıt silindi.");

                Listele();

                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxKonu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpVizyon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxSuresi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
