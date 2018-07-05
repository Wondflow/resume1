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
    public partial class zhenliaoxiangmu : Form
    {
        public zhenliaoxiangmu()
        {
            InitializeComponent();
        }

        private void zhenliaoxiangmu_Load(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tprice as 单价 from Treatinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txta.Text == ""||txtb.Text==""||txtc.Text==""||txtd.Text=="")
            { MessageBox.Show("请输入内容!"); }
            else
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "insert into Treatinfo( project,proname,treatunit,tamount,tprice)values('" + txta.Text + "','" + txtb.Text + "','" + txtc.Text + "','" + txte.Text + "','" + txtd.Text + "')";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            string strsql;
            string condition = "";
            DataAccess data1 = new DataAccess();
            DataSet ds;
            strsql = "select  project as 项目大类,proname as 项目名称,treatunit as 单位,tprice as 单价 from Treatinfo where 1=1" + condition;
            data1.dataCon();
            ds = data1.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Treatinfo set project='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "',treatunit='" + dgvInfo.CurrentRow.Cells[2].Value.ToString() + "',tprice='" + dgvInfo.CurrentRow.Cells[3].Value.ToString() + "'where proname='" + dgvInfo.CurrentRow.Cells[1].Value.ToString() + "'";
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
            strsql = "select  project as 项目大类,proname as 项目名称,treatunit as 单位,tprice as 单价 from Treatinfo where 1=1" + condition;
            data1.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "delete from Treatinfo where proname='" + dgvInfo.CurrentRow.Cells[1].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                string strsql;
                string condition = "";
                DataAccess data2 = new DataAccess();
                DataSet ds;
                strsql = "select  project as 项目大类,proname as 项目名称,treatunit as 单位,tprice as 单价 from Treatinfo where 1=1" + condition;
                data2.dataCon();
                ds = data.getDataset(strsql);
                dgvInfo.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tprice as 单价 from Treatinfo where project like '%" + txtadd.Text + "%'or proname like '%" + txtadd.Text + "%'or treatunit like '%" + txtadd.Text + "%'or tprice like '%" + txtadd.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data1 = new DataAccess();
            DataSet ds;
            strsql = "select itembroad as 项目大类 from Iteminfo where 1=1" + condition;
            data1.dataCon();
            ds = data1.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txta.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select dosageunit as 单位 from Unitinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtc.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dataGridView2.Visible = false;
        }
    }
}
