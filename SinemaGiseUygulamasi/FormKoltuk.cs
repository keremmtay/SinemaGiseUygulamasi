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
    public partial class FormKoltuk : Form
    {
        public FormKoltuk()
        {
            InitializeComponent();
        }

        SeatManager manager = new SeatManager();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Seat seat = new Seat();
            seat.Sıra = Convert.ToChar(tbxSira.Text);
            seat.No = Convert.ToInt32(tbxNumara.Text);
            seat.Fiyat = Convert.ToDouble(tbxFiyat.Text);

            string mesaj = manager.SeatAddBL(seat);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxSira.Clear();
            tbxNumara.Clear();
            tbxFiyat.Clear();
        }

        private void FormKoltuk_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Seat seat = new Seat();
                seat.Id = Convert.ToInt32(tbxId.Text);
                seat.Sıra = Convert.ToChar(tbxSira.Text);
                seat.No = Convert.ToInt32(tbxNumara.Text);
                seat.Fiyat = Convert.ToDouble(tbxFiyat.Text);

                string mesaj = manager.SeatUpdateBL(seat);

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
                manager.SeatDeleteBL(Convert.ToInt32(tbxId.Text));

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxSira.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxNumara.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxFiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
