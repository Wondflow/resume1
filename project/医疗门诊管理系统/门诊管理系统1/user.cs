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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "insert into Userinfo([Username],[Userpassword])values('" + txtname.Text + "','" + txtpassd.Text + "')";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
            string strsql;
            string condition = "";
            DataAccess data3 = new DataAccess();
            DataSet ds;
            strsql = "select Username as 用户名,Userpassword as 用户密码 from Userinfo where 1=1" + condition;
            data3.dataCon();
            ds = data.getDataset(strsql);
            dgcinfo.DataSource = ds.Tables[0];
            txtname.Text = "";
            txtpassd.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Userinfo set Userpassword='" + dgcinfo.CurrentRow.Cells[1].Value.ToString() + "'where Username='" + dgcinfo.CurrentRow.Cells[0].Value.ToString() +"'";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("修改失败！");
            }
            string strsql;
            string condition = "";
            DataAccess data1 = new DataAccess();
            DataSet ds;
            strsql = "select Username as 用户名,Userpassword as 用户密码 from Userinfo where 1=1" + condition;
            data1.dataCon();
            ds = data.getDataset(strsql);
            dgcinfo.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "delete from Userinfo where Username='" + dgcinfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
            string strsql;
            string condition = "";
            DataAccess data2 = new DataAccess();
            DataSet ds;
            strsql = "select Username as 用户名,Userpassword as 用户密码 from Userinfo where 1=1" + condition;
            data2.dataCon();
            ds = data.getDataset(strsql);
            dgcinfo.DataSource = ds.Tables[0];
        }

        private void user_Load(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select Username as 用户名,Userpassword as 用户密码 from Userinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgcinfo.DataSource = ds.Tables[0];
        }
    }
}
