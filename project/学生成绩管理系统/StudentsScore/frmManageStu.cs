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
    public partial class frmManageStu : Form
    {
        public frmManageStu()
        {
            InitializeComponent();
        }
        public static string sid;
        public static string Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "delete from Studentinfo where Sid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
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
            if (txtSid.Text != "")
            {
                conditon += "and Sid='" + txtSid.Text + "'";
            }
            if (txtName.Text != "")
            {
                conditon += "and Cname='" + txtName.Text + "'";
            }
            if (txtClass.Text != "")
            {
                conditon += "and Class='" + txtClass.Text + "'";
            }
            if (cboSex.Text != "")
            {
                conditon += "and Sex='" + cboSex.Text + "'";
            }
            strSql = "select Sid as 学号 , Sname as 姓名 ,Sex as 性别 , Birthday as 出生日期 , Class as 班级 , Tel as 电话 , Adress as 家庭住址 from Studentinfo where 1=1" + conditon;
            data.DataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageStu.sid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            frmEditStu  frmEditStu1=new frmEditStu ();
            frmEditStu1.Show();
        }
    }
}
