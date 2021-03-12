using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evoh.yard.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtusername.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text=="Admin" && txtpassword.Text=="Admin")
            {
                this.Hide();
                Forms.Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password !!");
                txtusername.Clear();
                txtpassword.Clear();
            }
        }
    }
}
