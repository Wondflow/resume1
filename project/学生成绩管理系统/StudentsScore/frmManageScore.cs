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
    public partial class frmManageScore : Form
    {
        public frmManageScore()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "delete from Scoreinfo where Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "' and Sid='" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "'";
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
            if (txtSname.Text != "")
            {
                conditon += "and Cname='" + txtSname.Text + "'";
            }
            if (txtClass.Text!= "")
            {
                conditon += "and Class='" + txtClass.Text + "'";
            }
            if (txtCid.Text != "")
            {
                conditon += "and Cid='" + txtCid.Text + "'";
            }
            strSql = "select Courseinfo.Cid as 课程编号,Courseinfo.Cname as 课程名称,Studentinfo.Sname as 姓名,Studentinfo.Class as 班级 ,Studentinfo.Sid as 学号,Scoreinfo.Score as 成绩 from Studentinfo,Courseinfo,Scoreinfo where Courseinfo.Cid=Scoreinfo.Cid and Studentinfo.Sid=Scoreinfo.Sid" + conditon;
            data.DataCon();
            ds = data.getDataset(strSql);
            dgvInfo .DataSource =ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Scoreinfo set Score= '" + dgvInfo.CurrentRow.Cells[5].Value.ToString() + "' where Sid= '" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "' and Cid= '" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "' ";
            data.DataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("修改成功！！");
            }
            else
            {
                MessageBox.Show("修改失败！！");
            }
        }

        private void frmManageScore_Load(object sender, EventArgs e)
        {
           
        }
    }
}
