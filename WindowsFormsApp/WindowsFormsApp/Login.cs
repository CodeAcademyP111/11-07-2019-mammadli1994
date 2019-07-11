using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(username!="admin" || password!="123")
            {
                MessageBox.Show("Username or Password wrong !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Form1 form = new Form1(this);
            form.Show();
        }
    }
}
