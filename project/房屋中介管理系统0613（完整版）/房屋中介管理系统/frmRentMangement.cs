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
    public partial class frmRentMangement : Form
    {
        public frmRentMangement()
        {
            InitializeComponent();
        }
        public static string rentID;
        public static string RentID
        {
            get { return rentID ; }
            set { rentID  = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtRid.Text != "")
            {
                condition +="and RentID ='"+txtRid .Text +"'";
            }

            if (txtArea.Text != "")
            {
                condition += "and rarea ='" + txtArea.Text + "'";
            }
            if (txtDct.Text != "")
            {
                condition += " and rdecoration ='"+txtDct .Text +"'";
            }
            if (txtPrice.Text != "")
            {
                condition += " and rprice ='" + txtPrice.Text + "'";
            }
            if (cboType.Text != "")
            {
                condition += " and rhouseType ='" + cboType.Text + "'";
            }
          
            strSql = " select rentID as 出租编号 ,rarea as 面积 ,rprice as 价格 ,rhouseType as 房屋类型 , raddress as 具体地址  ,ryear as 楼龄 ,rfloor as 楼层, rdecoration as 装修情况 , rremarks as 配套设施 , rhqingkuang as 房屋情况 from rentinfo where 1=1" + condition;
            data.DataCon();
            ds = data.getDataset(strSql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql ="delete from rentinfo where RentID ='"+dataGridView1 .CurrentRow .Cells [0].Value .ToString ()+"'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmRentMangement.rentID= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmRentEdit frmrentEdit1 = new frmRentEdit();
            frmrentEdit1.Show();
        }
    }
}
