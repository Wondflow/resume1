using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 房屋中介管理系统
{
    public partial class frmHuntingManagement : Form
    {
        public frmHuntingManagement()
        {
            InitializeComponent();
        }
        public static string customerID;
        public static string CustomerID
        {
            get { return customerID ; }
            set { customerID  = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtCid.Text != "")
            {
                condition += " and customerID = '" + txtCid.Text + "'";
            }
            if (txtPrice.Text != "")
            {
                condition += " and hprice ='" + txtPrice.Text + "'";
            }
            if (txtArea.Text != "")
            {
                condition += " and harea ='"+txtArea .Text +"'";
            }
            if (txtDct.Text != "")
            {
                condition +=" and hdecoration = '"+txtDct .Text +"'";
            }
            strSql = " select customerID as 客户编号,customerName as 客户姓名, harea as 面积, hprice as 价格, hhouseType as 房屋类型, hdecoration as 装修情况, ctelephone as 电话, csex as 性别 from qiuzhuinfo where 1=1" + condition;
            data.DataCon();
            ds = data.getDataset(strSql );
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql =" delete from qiuzhuinfo where customerID='"+dataGridView1 .CurrentRow .Cells [0].Value .ToString ()+"' ";
            data.DataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHuntingManagement.customerID  = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmHuntingEdit huntingEdit = new frmHuntingEdit();
            huntingEdit.Show();
        }
    }
}
