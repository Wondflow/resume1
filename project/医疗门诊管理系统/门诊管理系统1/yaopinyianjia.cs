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
    public partial class yaopinyianjia : Form
    {
        public yaopinyianjia()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            strsql = "insert into Drugmanage(drugID,drugkind,drugname,drugsize,drugunit,drugstock,drugprice,tradeprice,saleprice,batch,termtime,trademark,address)values('"+txtm.Text+"','"+coma.Text+"','"+txtb.Text+"','"+txtc.Text+"','"+txtd.Text+"','"+txte.Text+"','"+txtf.Text+"','"+txtg.Text+"','"+txth.Text+"','"+txti.Text+"','"+txtj.Text+"','"+txtk.Text+"','"+txtl.Text+"')";
            data.dataCon();
            if (data.sqlExec(strsql))
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yaopinyianjia_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugstock as 规格 from Drugstock where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select address as 产地 from Address where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtd.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtk.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }
        

    }
}
