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
    public partial class drug : Form
    {
        public drug()
        {
            InitializeComponent();
        }

        private void drug_Load(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugunit as 单位,drugstock as 库存,drugprice as 进货价,tradeprice as 批发价,saleprice as 销售价,batch as 批号,termtime as 有效期,trademark as 注册商标,address as 产地,drugkind as 类型 from Drugmanage where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "update Drugmanage set drugname='" + dgvInfo.CurrentRow.Cells[1].Value.ToString() + "',drugsize='" + dgvInfo.CurrentRow.Cells[2].Value.ToString() + "',drugunit='" + dgvInfo.CurrentRow.Cells[3].Value.ToString() + "',drugstock='" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "',drugprice='" + dgvInfo.CurrentRow.Cells[5].Value.ToString() + "',tradeprice='" + dgvInfo.CurrentRow.Cells[6].Value.ToString() + "',saleprice='" + dgvInfo.CurrentRow.Cells[7].Value.ToString() + "',batch='" + dgvInfo.CurrentRow.Cells[8].Value.ToString() + "',termtime='" + dgvInfo.CurrentRow.Cells[9].Value.ToString() + "',trademark='" + dgvInfo.CurrentRow.Cells[10].Value.ToString() + "',address='" + dgvInfo.CurrentRow.Cells[11].Value.ToString() + "',drugkind='" + dgvInfo.CurrentRow.Cells[12].Value.ToString() + "'where drugID='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";

            data.dataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("修改成功!!");
            }
            else
            {
                MessageBox.Show("修改失败！！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           if(MessageBox.Show("是否删除", "询问", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
           {
                string strSql;
                 DataAccess data = new DataAccess();
                 strSql = "delete from Drugmanage where drugID='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
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
            yaopinyianjia yao = new yaopinyianjia();
            yao.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugunit as 单位,drugstock as 库存,drugprice as 进货价,tradeprice as 批发价,saleprice as 销售价,batch as 批号,termtime as 有效期,trademark as 注册商标,address as 产地,drugkind as 类型 from Drugmanage where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select drugID as 编号, drugname  as 药品名称, drugsize as 规格,drugunit as 单位,drugstock as 库存,drugprice as 进货价,tradeprice as 批发价,saleprice as 销售价,batch as 批号,termtime as 有效期,trademark as 注册商标,address as 产地,drugkind as 类型 from Drugmanage where drugID like '%" + textBox1.Text + "%'or drugname like '%" + textBox1.Text + "%'" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }
    }
}
