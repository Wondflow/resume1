using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsScore
{
    public partial class frmManageCourse : Form
    {
        public frmManageCourse()
        {
            InitializeComponent();
        }

        public static string cid;
        public static string Cid
        {
            get { return cid; }
            set { cid = value ; }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "delete from Courseinfo where Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.DataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("删除成功！！");
            }
            else
            {
                MessageBox.Show("删除失败！！");
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            string strSql;
            string conditon = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtCid.Text != "")
            {
                conditon += "and Cid='" + txtCid.Text + "'";
            }
            if (txtCname.Text != "")
            {
                conditon += "and Cname='" + txtCname.Text + "'";
            }
            strSql = "select Cid as 课程编号,Cname as 课程名称,Credit as 学分 from Courseinfo where 1=1" + conditon;
            data.DataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageCourse.cid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            frmEditCourse frmEditCourse1 = new frmEditCourse();
            frmEditCourse1.Show();
        }
    }
}
