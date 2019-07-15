using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Delete : Form
    {
        private Pharmacy pharmacy;
        private DataGridView dgv;
        public Delete(Pharmacy p, DataGridView d)
        {
            InitializeComponent();
            pharmacy = p;
            dgv = d;
            cmbDelete.DataSource = pharmacy.GetMedicine();
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
            int id=int.Parse(cmbDelete.SelectedValue.ToString().Substring(0,2).Trim());
            pharmacy.DeleteMedicine(id);

            cmbDelete.DataSource = null;
            cmbDelete.DataSource = pharmacy.GetMedicine();

            dgv.DataSource = null;
            dgv.DataSource = pharmacy.GetMedicine();
        }
    }
}
