using CarDealer.DataLayer;
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
    public partial class frmManufacturers : Form
    {

        private CarDealerModelContainer _db = new CarDealerModelContainer();

        public frmManufacturers()
        {
            InitializeComponent();


            //dgvManufacturers.

            dgvManufacturers.DataSource = _db.Manifactures.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManufacturers_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //_db.SaveChanges();
        }
    }
}
