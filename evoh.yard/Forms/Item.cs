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

namespace evoh.yard.Forms
{
    public partial class Item : Form
    {
        ItemBAL item = new ItemBAL();
        int itemId = 0;


        public Item()
        {
            InitializeComponent();
            dgvItem.AutoGenerateColumns = false;
            bindGrid();
          
        }

        private void Clearme()
        {
            txtcode.Clear();
            txtname.Clear();
            btnadd.Text = "&Add";
            bindGrid();
            txtcode.Select();
            txtcode.Focus();
        }
        private void Add()
        {
            if (string.IsNullOrWhiteSpace(txtcode.Text))
            {
                MessageBox.Show("Please Enter Code !!","Demo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtcode.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please Enter Name !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
            }
            else
            {
                if (btnadd.Text=="&Add")
                {
                    string Query = "sp_tbitem_ups " + 0 + ",'" + txtcode.Text + "','" + txtname.Text + "','Admin',1";
                    int i = item.Add(Query);
                    if (i > 0)
                        MessageBox.Show("Data Successfully Saved !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearme();
                }
                else
                {
                    string Query = "sp_tbitem_ups " + itemId + ",'" + txtcode.Text + "','" + txtname.Text + "','Admin',2";
                    int i = item.Add(Query);
                    if (i > 0)
                        MessageBox.Show("Data Successfully Update !!", "Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clearme();
                }
                
            }
        }
        private void bindGrid()
        {
            DataTable data = item.GetAll();
            dgvItem.DataSource = data;
        }
        private void mapData(int Id)
        {
            DataTable data = item.GetbyId(Id);
            if (data.Rows.Count > 0)
            {
                txtcode.Text = data.Rows[0]["ItemCode"].ToString();
                txtname.Text = data.Rows[0]["ItemName"].ToString();
                itemId = Convert.ToInt32(data.Rows[0]["Id"].ToString());
                btnadd.Text = "&Update";
            }
        }

        private void dgvItem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvItem.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItem.CurrentCell.ColumnIndex==4)
            {
                mapData(Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString()));
            }
        }      
        private void btnadd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            Clearme();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void Item_Load(object sender, EventArgs e)
        {
            groupBox1.Focus();
            txtcode.Select();
            txtcode.Focus();
        }
    }
}
