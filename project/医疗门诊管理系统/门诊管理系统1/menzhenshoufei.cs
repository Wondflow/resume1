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
    public partial class menzhenshoufei : Form
    {
        public menzhenshoufei()
        {
            InitializeComponent();
        }int cc = 0; 
        int aa = 0;
        int bb = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            shuaka shua = new shuaka();
            shua.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView4.Visible = true;
            string strSql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select  danjuhao as 单据号,VisitID as 就诊号,Pname as 姓名,Sex as 性别,Old as 年龄,StatusID as 身份证号码,Address as 地址,Telehpone as 电话号码,Time as 时间 from Patientinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strSql);
            dataGridView4.DataSource = ds.Tables[0];

        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView7.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tamount as 数量,tprice as 单价 from Treatinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView7.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select office as 科室 from Officesinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select doctorname as 医生姓名 from Doctorinfo where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = true;
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugstock as 库存 ,termtime as 有效期,address as 产地,drugkind as 类型,saleprice as 单价,zongji as 总计 from Drugmanage where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();

            dataGridView4.Visible = false;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            dataGridView3.Visible = false;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkeshi.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txta.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            txtd.Text = dataGridView5.CurrentRow.Cells[7].Value.ToString();
            txtb.Text = dataGridView5.CurrentRow.Cells[3].Value.ToString();
            //textBox9.Text = dataGridView5.CurrentRow.Cells[8].Value.ToString();
            txtc.Text = "0";
            dataGridView5.Visible = false;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (txta.Text != ""&&txtb.Text!=""&&txtc.Text!=""&&txtd.Text!="")
            {
                string strsql;
                string condition = "";
                DataAccess data = new DataAccess();
                DataSet ds;
                strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugstock as 库存 ,termtime as 有效期,address as 产地,drugkind as 类型,shuliang as 数量,saleprice as 单价,zongji as 总计 from Drugmanage where drugname='" + txta.Text + "'" + condition;
                data.dataCon();
                ds = data.getDataset(strsql);
                dgvInfo.DataSource = ds.Tables[0];
                DataAccess data1 = new DataAccess();
                strsql = "update Drugmanage set shuliang='" + txtc.Text.ToString() + "' where drugname='" + txta.Text + "' ";
                data1.dataCon();
                if (data.sqlExec(strsql))
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugstock as 库存 ,termtime as 有效期,address as 产地,drugkind as 类型,shuliang as 数量,saleprice as 单价 from Drugmanage  where drugname='" + txta.Text + "'";
                data.dataCon();
                ds = data.getDataset(strsql);
                dgvInfo.DataSource = ds.Tables[0];
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 药品编号,drugname as 药品名称, drugstock as 当前库存,shuliang as 数量,saleprice as 单价,zongji as 总计 from Drugmanage where drugname='" + txta.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
            
            // for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //  {
            string strSql2;
            cc = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString()) * Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
            strSql2 = "update Drugmanage set zongji='" + cc.ToString() + "' where drugID='" + ds.Tables[0].Rows[0][0].ToString() + "'";
            data.dataCon();
            data.sqlExec(strSql2);
            
            // }
            strsql = "select drugID as 药品编号,drugname as 药品名称, drugstock as 当前库存,shuliang as 数量,saleprice as 单价,zongji as 总计 from Drugmanage where drugname='" + txta.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
            label15.Text = "￥"+dgvInfo.CurrentRow.Cells[5].Value.ToString();
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
            txtd.Text = "";
            //label19.Text = "￥" + dgvInfo.CurrentRow.Cells[5].Value.ToString();
            bb = aa + cc;
            label19.Text = "￥" + bb.ToString();
        }

        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox24.Text = dataGridView7.Rows[0].Cells[1].Value.ToString();
            textBox24.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            textBox23.Text = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            textBox19.Text = dataGridView7.CurrentRow.Cells[4].Value.ToString();
            dataGridView7.Visible = false;
            textBox21.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tamount as 数量,tprice as 项目费用 , zongfeiyong as 总费用 from Treatinfo where proname='" + textBox24.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            
            // for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //  {
            string strSql2;
            aa = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString()) * Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString());
            strSql2 = "update Treatinfo set zongfeiyong='" + aa.ToString() + "' where proname='" + ds.Tables[0].Rows[0][1].ToString() + "'";
            data.dataCon();
            data.sqlExec(strSql2);
            
            // }
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tamount as 数量,tprice as 项目费用,zongfeiyong as 总费用 from Treatinfo where proname='" + textBox24.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            label24.Text = "￥" + dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox21.Text = "";
            textBox24.Text = "";
            textBox23.Text = "";
            textBox19.Text = "";
            bb=aa+cc;
            label19.Text = "￥" + bb.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tamount as 数量,tprice as 项目费用 from Treatinfo where proname='" + textBox24.Text + "'" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView7.DataSource = ds.Tables[0];
            DataAccess data1 = new DataAccess();
            strsql = "update Treatinfo set tamount ='" + textBox21.Text.ToString() + "' where proname ='" + textBox24.Text + "'";
            data1.dataCon();
            if (data.sqlExec(strsql))
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            strsql = "select project as 项目大类,proname as 项目名称,treatunit as 单位,tamount as 数量,tprice as 单价 from Treatinfo where proname='" + textBox24.Text + "'";
            data.dataCon();
            ds = data.getDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dataGridView1.Rows.Remove(r);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow a in dgvInfo.SelectedRows)
            {
                if(!a.IsNewRow)
                {
                    dgvInfo.Rows.Remove(a);
                }
            }
            
        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            textBox21.Text = "";
        }

        private void txtc_Click(object sender, EventArgs e)
        {
            txtc.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            shuaka shua = new shuaka();
            shua.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Patientinfo set charg='" + label19.Text.ToString() + "'where VisitID='"+textBox1.Text+"'";

            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("保存成功!!");
            }
            else
            {
                MessageBox.Show("保存失败！！");
            }
        }

       
       

       

       
      
      



       

       

       
         
       
    }
}
