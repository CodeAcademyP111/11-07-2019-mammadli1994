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
    public partial class Form1 : Form
    {
        private Pharmacy pharmacy;
        private DataGridView dgv;
        public Form1()
        {
            InitializeComponent();
            Pharmacy avromed = new Pharmacy("Avromed");
            pharmacy = avromed;
            dgv = dgvList;
            dgvList.DataSource = pharmacy.GetMedicine();
        }

        private void BtnCreat_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            float price = float.Parse(txtPrice.Text);



            if(name=="" || price ==null)
            {
                MessageBox.Show("Zehmet olmasa doldurun","information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Medicine medicine = new Medicine { Name=name, Price=price};
            pharmacy.AddMedicine(medicine);


            dgvList.DataSource = null;
            dgvList.DataSource = pharmacy.GetMedicine();


            txtName.Text = null;
            txtPrice.Text = null;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(pharmacy,dgv);
            delete.Show();
        }
        private int ID = 0;

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCreat.Visible = false;
            btnUpdate.Visible = true;
            int id = (int)dgv.Rows[e.RowIndex].Cells[0].Value;
            ID = id;
            Medicine medicine = pharmacy.GetMedicines(id);

            txtName.Text = medicine.Name;
            txtPrice.Text = medicine.Price.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            string name = txtName.Text.Trim();
            float price = float.Parse(txtPrice.Text);



            if (name == "" || price == null)
            {
                MessageBox.Show("Zehmet olmasa doldurun", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            pharmacy.UpdateMedicine(ID, name, price);

            dgvList.DataSource = null;
            dgvList.DataSource = pharmacy.GetMedicine();


            txtName.Text = null;
            txtPrice.Text = null;
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreat.Visible = true;
            btnUpdate.Visible = false;
        }
    }
}
