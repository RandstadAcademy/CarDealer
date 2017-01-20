using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnManifacturersList_Click(object sender, EventArgs e)
        {
            Form frmManufacturers = new frmManufacturers();

            //frmManufacturers.Text = "Produttori";

            frmManufacturers.Show();

        }
    }
}
