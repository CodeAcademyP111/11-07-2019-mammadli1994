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
    public partial class Form1 : Form
    {
        private Form login;
        public Form1(Form f)
        {
            InitializeComponent();
            login = f;
            f.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }
    }
}
