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
    public partial class taocan : Form
    {
        public taocan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == ""|| txtgxiao.Text == ""|| txtshuliang.Text == "" || txtunit.Text == "")
            { MessageBox.Show("请输入完整内容！"); }
            else
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "insert into Mealinfo( bianhao,name,shuliang,mealkind,guige,effect)values ('" + txtid.Text + "','" + txtname.Text + "','" + txtshuliang.Text + "','" + txtunit.Text + "','" + txtguige.Text + "','" + txtgxiao.Text + "')";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("添加成功！！");
                }
                else
                {
                    MessageBox.Show("添加失败！！");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "delete from Mealinfo where bianhao='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select bianhao as 编号, name as 药品名称, shuliang as 数量,mealkind as 单位,guige as 规格,effect as 功效 from Mealinfo where 1=1";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            txtid.Text = "";
            txtname.Text = "";
            txtshuliang.Text = "";
            txtunit.Text = "";
            txtgxiao.Text = "";
            txtguige.Text = "";
            
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select  bianhao as 编号, name as 药品名称, shuliang as 数量,mealkind as 单位,guige as 规格,effect as 功效 from Mealinfo where bianhao like'%" + textBox6.Text + "%' or name like'%" + textBox6.Text + "%' or effect like'%" + textBox6.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void taocan_Load(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select bianhao as 编号, name as 药品名称, shuliang as 数量,mealkind as 单位,guige as 规格,effect as 功效 from Mealinfo where 1=1";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible =true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugname  as 药品名称 from Drugmanage where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select dosageunit as 单位 from Unitinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtunit.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView4.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugstock as 规格 from Drugstock where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView4.DataSource = ds.Tables[0];
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtguige.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            dataGridView4.Visible = false;
        }

        
    }
}
