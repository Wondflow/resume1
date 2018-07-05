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
    public partial class frmSaleManagement : Form
    {
        public frmSaleManagement()
        {
            InitializeComponent();
        }
        public static string cid;
        public static string Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtCid.Text != "")
            {
                condition += "and customerID ='" + txtCid.Text + "'";
            }
            strSql = "select customerID as 客户编号 ,customerName as 客户姓名, saarea as 面积 , saprice as 价格, sahouseType as 房屋类型, sadecoration as 装修情况, ctelephone as 电话, csex as 性别 from qiugouinfo where 1=1" + condition;
            data.DataCon();
            ds = data.getDataset(strSql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = " delete from qiugouinfo where customerID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmSaleManagement.cid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmSaleEdit frmEdit = new frmSaleEdit();
            frmEdit.Show();
        }
    }
}
