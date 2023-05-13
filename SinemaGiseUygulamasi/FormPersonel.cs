﻿using BusinessLayer.Concrete;
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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        EmployeeManager manager = new EmployeeManager();

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Adi = tbxAdi.Text;
            employee.Soyadi = tbxSoyadi.Text;
            employee.KullaniciAdi = tbxKullaniciAdi.Text;
            employee.Sifre = tbxSifre.Text;
            employee.Gorevi = tbxGorevi.Text;
            employee.AktifMi = cbxAktifMi.Checked;

            string mesaj = manager.EmployeeAddBL(employee);

            MessageBox.Show(mesaj);

            Listele();

            FormuTemizle();
        }

        private void FormuTemizle()
        {
            tbxId.Clear();
            tbxAdi.Clear();
            tbxSoyadi.Clear();
            tbxKullaniciAdi.Clear();
            tbxSifre.Clear();
            tbxGorevi.Clear();
            cbxAktifMi.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbxId.Text != "")
            {
                Employee employee = new Employee();
                employee.Id = Convert.ToInt32(tbxId.Text);
                employee.Adi = tbxAdi.Text;
                employee.Soyadi = tbxSoyadi.Text;
                employee.KullaniciAdi = tbxKullaniciAdi.Text;
                employee.Sifre = tbxSifre.Text;
                employee.Gorevi = tbxGorevi.Text;
                employee.AktifMi = cbxAktifMi.Checked;

                string mesaj = manager.EmployeeUpdateBL(employee);

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
                manager.EmployeeDeleteBL(Convert.ToInt32(tbxId.Text));

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
            tbxGorevi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxSifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbxAktifMi.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);
        }
    }
}
