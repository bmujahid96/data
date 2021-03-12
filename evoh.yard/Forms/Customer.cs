using evoh.yard.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static evoh.yard.patti;

namespace evoh.yard.Forms
{
    public partial class Customer : Form
    {
        CustomerBAL customer = new CustomerBAL();
        int CustomerId = 0;
        public Customer()
        {
            InitializeComponent();
            dgvCustomer.AutoGenerateColumns = false;
            bindGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Clearme()
        {
            txtaddress.Clear();
            txtcity.Clear();
            txtcode.Clear();
            txtemailid.Clear();
            txtmobileno.Clear();
            txtname.Clear();
            txtpincode.Clear();
            btnadd.Text = "&Add";
            bindGrid();
            txtname.Focus();
        }
        private void Add()
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text))
            {
                MessageBox.Show("Please Enter Code !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcode.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please Enter Name !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtmobileno.Text))
            {
                MessageBox.Show("Please Enter Mobile No !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmobileno.Focus();
            }

            else if (string.IsNullOrWhiteSpace(txtcity.Text))
            {
                MessageBox.Show("Please Enter City !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcity.Focus();
            }
            else
            {
                if (btnadd.Text == "&Add")
                {
                    string Query = "sp_tbcustomer_ups " + 0 + ",'" + txtcode.Text + "','" + txtname.Text + "','" + txtmobileno.Text + "','" + txtemailid.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "','" + txtpincode.Text + "','Admin',1";
                    int i = customer.Add(Query);
                    if (i > 0)
                    {
                        MessageBox.Show("Data Successfull Saved !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Clearme();
                }
                else
                {
                    string Query = "sp_tbcustomer_ups " + CustomerId + ",'" + txtcode.Text + "','" + txtname.Text + "','" + txtmobileno.Text + "','" + txtemailid.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "','" + txtpincode.Text + "','Admin',2";
                    int i = customer.Add(Query);
                    if (i > 0)
                    {
                        MessageBox.Show("Data Successfull Saved !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Clearme();
                }
            }
        }
        private void mapCustomer(int Id)
        {
            string Query = "";
            DataTable data = customer.GetbyId(Id);

            if (data.Rows.Count > 0)
            {
                txtaddress.Text = data.Rows[0]["Address"].ToString();
                txtcity.Text = data.Rows[0]["City"].ToString();
                txtcode.Text = data.Rows[0]["Code"].ToString();
                txtemailid.Text = data.Rows[0]["EmailId"].ToString();
                txtmobileno.Text = data.Rows[0]["MobileNo"].ToString();
                txtname.Text = data.Rows[0]["Name"].ToString();
                txtpincode.Text = data.Rows[0]["Pincode"].ToString();
                CustomerId = Convert.ToInt32(data.Rows[0]["Id"].ToString());
                btnadd.Text = "&Update";
            }
        }
        private void bindGrid()
        {
            DataTable data = customer.GetAll();
            dgvCustomer.DataSource = data;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            Clearme();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentCell.ColumnIndex == 6)
            {
                mapCustomer(Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString()));
            }
        }   
        private void dgvCustomer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvCustomer.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F9)
            {
                this.Dispose();
            }
            else if (keyData == Keys.F8)
            {
                Clearme();
            }
            else if (keyData == Keys.F7)
            {
                Add();
            }



            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
