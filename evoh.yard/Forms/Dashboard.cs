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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ShowForm(Form obj, string name)
        {
            Form fc = Application.OpenForms[name];
            if (fc == null)
            {
                Form[] cs = this.MdiChildren;
                if (cs.Count() > 0)
                {
                    foreach (Form c in cs)
                    {

                        DialogResult res = MessageBox.Show("Please save your data before close this window!", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            c.Close();
                            obj.MdiParent = this;
                            obj.StartPosition = FormStartPosition.Manual;
                            obj.Location = new Point(0, 0);
                            obj.Dock = DockStyle.Fill;
                            obj.Show();
                        }

                    }

                }
                else
                {
                    obj.MdiParent = this;
                    obj.StartPosition = FormStartPosition.Manual;
                    obj.Location = new Point(0, 0);
                    obj.Dock = DockStyle.Fill;
                    obj.Show();
                }
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Customer customer = new Customer();
            ShowForm(customer, "Customer");
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Item item = new Item();
            ShowForm(item, "Item");
        }

        private void pattiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Patti patti = new Patti();
            ShowForm(patti, "Patti");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.login login = new login();
            login.ShowDialog();
            this.Dispose();

        }
    }
}
