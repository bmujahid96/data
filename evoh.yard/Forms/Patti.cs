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
    public partial class Patti : Form
    {
        DataTable data = new pattiTableDataTable();
        TextBox tb = new TextBox();
        PattiBAL patti = new PattiBAL();
        ItemBAL item = new ItemBAL();
        CustomerBAL customer = new CustomerBAL();
        int CustId = 0;
        public Patti()
        {
            InitializeComponent();
            dgvpatti.AutoGenerateColumns = false;
            data.Rows.Add();
            dgvpatti.DataSource = data;

            panel2.Location = new Point(
                this.ClientSize.Width / 2 - panel2.Size.Width / 2,
                this.ClientSize.Height / 2 - panel2.Size.Height / 2
                );
            panel2.Anchor = AnchorStyles.None;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            dgvcustomerdata.Visible = false;
            dgvcustomerdata.AutoGenerateColumns = false;
            bindCustomer();
           // dgvcustomerdata.ClearSelection();
        }
        private void bindCustomer()
        {
            DataTable data = customer.GetAll();
            dgvcustomerdata.DataSource = data;
        }
        private List<DTO.Patti> mapPatti()
        {
            List<DTO.Patti> pattis = new List<DTO.Patti>();
            for (int i = 0; i < dgvpatti.Rows.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells["ItemCode"].Value.ToString()))
                {
                    pattis.Add(new DTO.Patti()
                    {
                        Bag = Convert.ToDecimal(dgvpatti.Rows[i].Cells["Bag"].Value.ToString()),
                        ItemId = Convert.ToInt32(dgvpatti.Rows[i].Cells["ItemId"].Value.ToString()),
                        Kg = Convert.ToDecimal(dgvpatti.Rows[i].Cells["Kg"].Value.ToString()),
                        Price = Convert.ToDecimal(dgvpatti.Rows[i].Cells["Price"].Value.ToString()),
                        Total = Convert.ToDecimal(dgvpatti.Rows[i].Cells["Total"].Value.ToString()),
                    });
                }
            }
            return pattis;
        }
        private void Add()
        {
            //string Query = "sp_tbPattiHeader_ups " + 0 + ",'" + cmbCustomer.SelectedValue + "','" + txtvno.Text + "','" + txttotalbags.Text + "','" + txttotalkg.Text + "','" + txttotalamt.Text + "',1";
            int i=  patti.Add(new DTO.PattiHeader()
            {
                CustomerId = Convert.ToInt32(CustId),
                VNo = txtvno.Text,
                TotalAMT = Convert.ToDecimal(txttotalamt.Text),
                TotalBag = Convert.ToDecimal(txttotalbags.Text),
                TotalKg = Convert.ToDecimal(txttotalkg.Text),
            }, mapPatti());
            if (i > 1)
            {
                Clearme();
                //MessageBox.Show("Data Successfully Saved !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Reports reports = new Reports(txtCustomerName.Text, txtvno.Text, i);
                reports.ShowDialog();
               
            }  
            else
                MessageBox.Show("Sorry Try Again !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cellfocuse(int rowindex,string columnname)
        {
            dgvpatti.CurrentCell = dgvpatti.Rows[rowindex].Cells[columnname];
            dgvpatti.BeginEdit(true);
        }
        private void addrow()
        {
            if (string.IsNullOrWhiteSpace(dgvpatti.Rows[dgvpatti.CurrentCell.RowIndex].Cells["Item"].Value.ToString()))
            {
                int lastrow = dgvcustomerdata.Rows.Count - 1;
                if (string.IsNullOrWhiteSpace(dgvpatti.Rows[lastrow].Cells["Item"].Value.ToString()))
                {
                    cellfocuse(lastrow, "Item");
                }
                else
                {
                    data.Rows.Add();
                    dgvpatti.DataSource = data;
                }
                
            }
            else
            {
                data.Rows.Add();
                dgvpatti.DataSource = data;
            }
        }
        private void enteronlynumber(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        private void enteronlydecimal(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }

        }
        private void calculate()
        {
            for (int i = 0; i < dgvpatti.Rows.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[1].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[3].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[4].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[5].Value.ToString()))
                {
                    /*
                     total=(bag*kg) *price

                    */

                    decimal bag = Convert.ToDecimal(dgvpatti.Rows[i].Cells[3].Value.ToString());
                    decimal kg = Convert.ToDecimal(dgvpatti.Rows[i].Cells[4].Value.ToString());
                    decimal price = Convert.ToDecimal(dgvpatti.Rows[i].Cells[5].Value.ToString());


                    dgvpatti.Rows[i].Cells[6].Value = ((bag * kg) * price).ToString("#.##");

                }
            }
            calculatefooter();
        }
        private void calculatefooter()
        {
            decimal total_bag = 0, total_kg = 0, total_amt = 0;
            for (int i = 0; i < dgvpatti.Rows.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[1].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[3].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[4].Value.ToString()) &&
                    !string.IsNullOrWhiteSpace(dgvpatti.Rows[i].Cells[5].Value.ToString()))
                {
                    total_bag += Convert.ToDecimal(dgvpatti.Rows[i].Cells[3].Value.ToString());
                    total_kg += Convert.ToDecimal(dgvpatti.Rows[i].Cells[4].Value.ToString());
                    total_amt += Convert.ToDecimal(dgvpatti.Rows[i].Cells[6].Value.ToString());

                }
            }
            txttotalkg.Text = total_kg.ToString("#.##");
            txttotalbags.Text = total_bag.ToString("#.##");
            txttotalamt.Text = total_amt.ToString("#.##");
        }
        private string GetItem(string Code)
        {
            DataTable data = item.GetbyCode(Code);
            if (data.Rows.Count > 0)
                return data.Rows[0]["ItemName"].ToString();
            else
                cellfocuse(dgvpatti.CurrentCell.RowIndex, "ItemCode");
            return "";
        }
        private string GetItemId(string Code)
        {
            DataTable data = item.GetbyCode(Code);
            if (data.Rows.Count > 0)
                return data.Rows[0]["Id"].ToString();
            else
                cellfocuse(dgvpatti.CurrentCell.RowIndex, "ItemCode");
            return "";
        }
        private void Clearme()
        {
            data.Rows.Clear();
            data.Rows.Add();
            bindCustomer();
            dgvcustomerdata.Visible = false;
            txtCustomerName.Clear();
            txttotalamt.Clear();
            txttotalbags.Clear();
            txttotalkg.Clear();
            txtvno.Clear();
        }


        private void dgvpatti_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvpatti.BeginEdit(false);
        }
        private void dgvpatti_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            tb = e.Control as TextBox;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        private void dgvpatti_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvpatti.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void dgvpatti_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            var currentcell = dgvpatti.CurrentCell;
            if (currentcell.ColumnIndex == 1)
            {
                /// Item
                dgvpatti.Rows[e.RowIndex].Cells[1].Value = tb.Text;
                // calculate();
            }
            else if (currentcell.ColumnIndex == 3)
            {
                /// bag

                dgvpatti.Rows[e.RowIndex].Cells[3].Value = tb.Text;
                calculate();

            }
            else if (currentcell.ColumnIndex == 4)
            {
                /// kg
                /// 
                dgvpatti.Rows[e.RowIndex].Cells[4].Value = tb.Text;
                calculate();

            }
            else if (currentcell.ColumnIndex == 5)
            {
                ///price
                ///
                dgvpatti.Rows[e.RowIndex].Cells[5].Value = tb.Text;
                calculate();
            }
        }
        private void dgvpatti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            var currentcell = dgvpatti.CurrentCell;
            if (keyData==Keys.Enter || keyData==Keys.Tab)
            {
                if (currentcell.ColumnIndex==1)
                {
                    /// Item
                    cellfocuse(currentcell.RowIndex, "bag");
                    dgvpatti.Rows[currentcell.RowIndex].Cells[2].Value = GetItem(dgvpatti.Rows[currentcell.RowIndex].Cells[1].Value.ToString());
                    dgvpatti.Rows[currentcell.RowIndex].Cells[7].Value = GetItemId(dgvpatti.Rows[currentcell.RowIndex].Cells[1].Value.ToString());
                    calculate();
                    return true;
                }
                else if (currentcell.ColumnIndex == 3)
                {
                    /// bag
                    cellfocuse(currentcell.RowIndex, "Kg");
                   // tb.KeyPress += new KeyPressEventHandler(enteronlydecimal);
                    calculate();
                    return true;
                }
                else if (currentcell.ColumnIndex == 4)
                {
                    /// kg
                    /// 
                    cellfocuse(currentcell.RowIndex, "Price");
                 //   tb.KeyPress -= new KeyPressEventHandler(enteronlydecimal);
                    calculate();
                    return true;
                }
                else if (currentcell.ColumnIndex == 5)
                {
                    ///
                    /// Price
                    ///
                    addrow();
                    cellfocuse((dgvpatti.Rows.Count)-1, "ItemCode");
                    calculate();
                    return true;
                }


                
                //if (keyData == Keys.S )
                //{
                //    MessageBox.Show("Test");
                //}

            }
            if (keyData==Keys.F7)
            {
                Add();
            }
            else if (keyData==Keys.F1)
            {
                Forms.Customer customer = new Customer();
                customer.ShowDialog();
            }
            else if (keyData==Keys.F2)
            {
                Forms.Item customer = new Forms.Item();
                customer.ShowDialog();
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtvno.Focus();
            }
        }
        private void txtvno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtvno.Text))
                    cellfocuse((dgvpatti.Rows.Count) - 1, "ItemCode");
                else
                    MessageBox.Show("Please Enter The V No !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void Patti_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Customer customer = new Customer();
            customer.ShowDialog();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Add();
        }


        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            var currentcell = dgvpatti.CurrentCell;

            if (currentcell.ColumnIndex==3)
            {
                /// bag (int)
                enteronlynumber(e);
            }
            else if (currentcell.ColumnIndex == 4)
            {
                /// kg (decimal)
                enteronlydecimal(sender, e);
            }
            else if (currentcell.ColumnIndex == 5)
            {
                /// Price (decimal)
                enteronlydecimal(sender, e);
            }
            else if (currentcell.ColumnIndex == 6)
            {
                /// Total (decimal)
                enteronlydecimal(sender, e);
            }



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
         
            dgvcustomerdata.Visible = true;
            panel2.Controls.Add(dgvcustomerdata);
            dgvcustomerdata.BringToFront();
            dgvcustomerdata.Location = new Point(36, 83);
            
            // dgvcustomerdata.Focus();
            try
            {
                ((DataTable)dgvcustomerdata.DataSource).DefaultView.RowFilter = string.Format("Name like '%{0}%'", txtCustomerName.Text.Trim().Replace("'", "''"));
                dgvcustomerdata.Refresh();
            }
            catch
            {

            }
        }
        private void dgvcustomerdata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtCustomerName.Text = dgvcustomerdata.Rows[dgvcustomerdata.CurrentCell.RowIndex].Cells[0].Value.ToString();
                CustId = Convert.ToInt32(dgvcustomerdata.Rows[dgvcustomerdata.CurrentCell.RowIndex].Cells[1].Value.ToString());
                txtvno.Focus();
                dgvcustomerdata.Visible = false;
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                dgvcustomerdata.Focus();
            }
            if (e.KeyCode==Keys.Enter)
            {
                txtCustomerName.Text = dgvcustomerdata.Rows[dgvcustomerdata.CurrentCell.RowIndex].Cells[0].Value.ToString();
                CustId = Convert.ToInt32(dgvcustomerdata.Rows[dgvcustomerdata.CurrentCell.RowIndex].Cells[1].Value.ToString());
                txtvno.Focus();
                dgvcustomerdata.Visible = false;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            Forms.Item customer = new Item();
            customer.ShowDialog();
        }

    }
}
