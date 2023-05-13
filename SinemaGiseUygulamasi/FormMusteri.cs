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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        CustomerManager manager = new CustomerManager();

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Adi = tbxAdi.Text;
            customer.Soyadi = tbxSoyadi.Text;
            customer.Telefon = mtbxTelefon.Text;
            customer.Email = tbxEmail.Text;
            customer.UyeMi = Convert.ToBoolean(cbxUyeMi.Checked);
            customer.KayitTarihi = Convert.ToDateTime(dtpKayitTarihi.Text);

            string mesaj = manager.CustomerAddBL(customer);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxEmail.Clear();
            tbxId.Clear();
            mtbxTelefon.Clear();
            cbxUyeMi.Checked = false;
            dtpKayitTarihi.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(tbxId.Text);
                customer.Adi = tbxAdi.Text;
                customer.Soyadi = tbxSoyadi.Text;
                customer.Telefon = mtbxTelefon.Text;
                customer.Email = tbxEmail.Text;
                customer.UyeMi = Convert.ToBoolean(cbxUyeMi.Checked);
                customer.KayitTarihi = Convert.ToDateTime(dtpKayitTarihi.Text);

                string mesaj = manager.CustomerUpdateBL(customer);

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
                manager.CustomerDeleteBL(Convert.ToInt32(tbxId.Text));

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
            tbxAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbxUyeMi.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
            dtpKayitTarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
