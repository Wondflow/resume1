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
    public partial class shoufeidanchaxun : Form
    {
        public shoufeidanchaxun()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow a in dgvinfo.SelectedRows)
            {
                if (!a.IsNewRow)
                {
                    dgvinfo.Rows.Remove(a);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string strSql;
                DataAccess data = new DataAccess();
                DataSet ds;
                strSql = "select danjuhao as 单据号,VisitID as 就诊号,Pname as 姓名,Sex as 性别,Old as 年龄,charg as 应收费用 from Patientinfo where 1=1";
                data.dataCon();
                ds = data.getDataset(strSql);
                dgvinfo.DataSource = ds.Tables[0];
            }
            if (checkBox1.Checked == false)
            {
                dgvinfo.DataSource = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select danjuhao as 单据号,VisitID as 就诊号,Pname as 姓名,Sex as 性别,Old as 年龄,charg as 应收费用from Patientinfo where VisitID like '%" + textBox1.Text + "%' or Pname like '%" + textBox1.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvinfo.DataSource = ds.Tables[0];
        }

        private void shoufeidanchaxun_Load(object sender, EventArgs e)
        {

        }

    }
}
