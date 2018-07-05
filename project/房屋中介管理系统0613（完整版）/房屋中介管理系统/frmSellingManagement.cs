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
    public partial class frmSellingManagement : Form
    {
        public frmSellingManagement()
        {
            InitializeComponent();
        }
        public static string sid;
        public static string Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtSid.Text != "")
            {
                condition += " and sellingID ='" + txtSid.Text + "' ";
            }
            if (txtArea.Text != "")
            {
                condition += " and sarea ='" + txtArea.Text + "'";
            }
            if (txtDct.Text != "")
            {
                condition += " and sdecoration ='" + txtDct.Text + "'";
            }
            if (txtPrice.Text != "")
            {
                condition += " and sprice ='" + txtPrice.Text + "'";
            }
            if (cboType.Text != "")
            {
                condition += " and shouseType ='" + cboType.Text + "'";
            }
            strSql = " select sellingID as 出售编号, sarea as 面积, sprice as 价格, shouseType as 房屋类型, saddress as 地址 , syear as 楼龄, sfloor as 楼层, sdecoration as 装修情况, sremarks as 配套设施, shqingkuang as 房屋情况  from chushouinfo where 1=1" + condition;
            data.DataCon();
            ds = data.getDataset(strSql );
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql =" delete from chushouinfo where sellingID = '"+dataGridView1 .CurrentRow .Cells [0].Value .ToString ()+"'";
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
            frmSellingManagement.sid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmSellingEdit sellingEdit = new frmSellingEdit();
            sellingEdit.Show();
        }
    }
}
