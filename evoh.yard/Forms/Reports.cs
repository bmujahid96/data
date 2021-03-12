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
    public partial class Reports : Form
    {
       
        public Reports(string customername,string vno,int id)
        {
            InitializeComponent();
            dgvprint.AutoGenerateColumns = false;
            lblcustomername.Text = customername;
            lblvno.Text = vno;
            BindGrid(id);
        }
        
        private void BindGrid(int id)
        {
            PattiBAL patti = new PattiBAL();
            var data = patti.GetbyId("select b.ItemName, a.*from tbPatti a, tbItem b where a.ItemId = b.Id and PHId = " + id + "");
            dgvprint.DataSource = data;
        }

        private void dgvprint_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvprint.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            

            DataGridViewAdvancedBorderStyle cellStyle = new DataGridViewAdvancedBorderStyle();
            cellStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
           
            dgvprint.Rows[4].AdjustRowHeaderBorderStyle(cellStyle,cellStyle, true, false, false, false);

            dgvprint.Rows[4].Selected = true;
            dgvprint.Rows[4].Selected = true;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
