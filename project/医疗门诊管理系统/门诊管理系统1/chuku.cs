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
    public partial class chuku : Form
    {
        public chuku()
        {
            InitializeComponent();
        }

        private void chuku_Load(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
             dataGridView2.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 药品编号,drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,camount as 上次出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where 1=1";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 药品编号,drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,camount as 上次出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where drugname='" + textBox1.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            //string strsql;

            DataAccess data1 = new DataAccess();
            strsql = "update Drugmanage set camount='" + textBox5.Text.ToString() + "',chukushijian='" + textBox2.Text + "' where drugID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
            data1.dataCon();
            if (data.sqlExec(strsql))
            {
                MessageBox.Show("点击确认出库可出库");
            }
            else
            {
                MessageBox.Show("出库失败");
            }
            strsql = "select drugID as 药品编号,drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,camount as 待出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where drugname='" + textBox1.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 药品编号,drugname as 药品名称,chukushijian as 出库时间, drugstock as 当前库存,camount as 出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where drugname like '%" + textBox3.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 药品编号,drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,camount as 待出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where drugname='" + textBox1.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0]; 
            int aa = 0;
            // for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //  {
            string strSql2;
            aa = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString()) - Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
            strSql2 = "update Drugmanage set drugstock='" + aa.ToString() + "' where drugID='" + ds.Tables[0].Rows[0][0].ToString() + "'";
            data.dataCon();
            data.sqlExec(strSql2);
            aa = 0;
            // }
            strsql = "select drugID as 药品编号,drugname as 药品名称, chukushijian as 出库时间, drugstock as 当前库存,camount as 本次出库数量,drugprice as 进货价,saleprice as 销售价,batch as 批号,termtime as 有效期 from Drugmanage where drugname='" + textBox1.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox4.Text = "";
            strsql = "update Drugmanage set camount='" + textBox5.Text + "' where drugID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
            MessageBox.Show("已经确认出库");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string shijian = DateTime.Now.ToLocalTime().ToString();
            textBox2.Text = shijian;
        }
    
        
    }
}