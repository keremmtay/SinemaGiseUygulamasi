using BusinessLayer.Concrete;
using EntityLayer;
using SinemaGiseUygulamasi.Araclar;
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
    public partial class FormIslem : Form
    {
        public FormIslem()
        {
            InitializeComponent();
        }

        Seat seat;

        BookingManager manager = new BookingManager();

        private void FormIslem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = manager.GetAllBL();
        }

        private void OdaSec()
        {
            SeatManager seats = new SeatManager();

            int pozisyonX = 30, pozisyonY = 30, sutun = 1;

            for (int i = 0; i < seats.GetAllBL().Count; i++)
            {
                MyButton myButton = new MyButton();

                myButton.Seat = seats.GetAllBL()[i];

                myButton.Location = new Point(pozisyonX, pozisyonY);

                myButton.Width = 50;

                myButton.Height = 50;

                myButton.Text = seats.GetAllBL()[i].No.ToString();

                myButton.Name = seats.GetAllBL()[i].Id.ToString();

                myButton.Click += new EventHandler(SeciliButon);

                groupBox1.Controls.Add(myButton);

                if (seats.GetAllBL()[i].MusaitMi)
                {
                    myButton.BackColor = Color.Green;
                }
                else
                {
                    myButton.BackColor = Color.Red;
                    myButton.Enabled = false;
                }


                if (sutun < 4)
                {
                    pozisyonX += 75;
                    sutun++;
                }
                else
                {
                    pozisyonX = 30;
                    pozisyonY += 75;
                    sutun = 1;
                }
            }


        }


        private void SeciliButon(Object sender, EventArgs eventArgs)
        {
            MyButton dinamikButon = (sender as MyButton);

            //tbxOdaNo.Text = dinamikButon.Oda.OdaNo;
            //tbxOdaId.Text = dinamikButon.Oda.Id.ToString();
            //tbxOdaFiyati.Text = dinamikButon.Oda.OdaFiyati.ToString();

            seat = dinamikButon.Seat;
        }
    }
}
