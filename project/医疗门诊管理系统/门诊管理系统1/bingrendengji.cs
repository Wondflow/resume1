using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 门诊管理系统1
{
    public partial class bingrendengji : Form
    {
        public bingrendengji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bingrenjilu bin = new bingrenjilu();
            bin.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "delete from Patientinfo where VisitID='" + dgvinfo.CurrentRow.Cells[0].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select VisitID as 就诊号,Pname as 姓名,Sex as 性别,Old as 年龄,StatusID as 身份证号,Address as 地址,Telehpone as 电话,remarks as 备注,Time as 登记时间 from Patientinfo where 1=1";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvinfo.DataSource = ds.Tables[0];
            button3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select VisitID as 就诊号,Pname as 姓名,Sex as 性别,Old as 年龄,StatusID as 身份证号,Address as 地址,Telehpone as 电话,remarks as 备注 from Patientinfo where VisitID like '%" + textBox1.Text + "%' or Pname like '%" + textBox1.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvinfo.DataSource = ds.Tables[0];
        }

        private void dgvinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
            //button3.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Patientinfo set Pname='" + dgvinfo.CurrentRow.Cells[1].Value.ToString() + "',Sex='" + dgvinfo.CurrentRow.Cells[2].Value.ToString() + "',Old='" + dgvinfo.CurrentRow.Cells[3].Value.ToString() + "',StatusID='" + dgvinfo.CurrentRow.Cells[4].Value.ToString() + "',Address='" + dgvinfo.CurrentRow.Cells[5].Value.ToString() + "',Telehpone='" + dgvinfo.CurrentRow.Cells[6].Value.ToString() + "',remarks='" + dgvinfo.CurrentRow.Cells[7].Value.ToString() + "'where VisitID='" + dgvinfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void dgvinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
