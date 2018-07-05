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
    public partial class bingrenjilu : Form
    {
        public bingrenjilu()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql = "insert into Patientinfo([VisitID],[Pname],[Sex],[Old],[StatusID],[Address],[Telehpone],[remarks],[Time])values('" + txtID.Text + "','" + txtname.Text + "','" + cbosex.Text + "','" + txtold.Text + "','" + txtstaid.Text + "','" + txtaddress.Text + "','" + txtphone.Text + "','" + txtremark.Text + "','"+textBox1.Text+"')";
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

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string shijian = DateTime.Now.ToLocalTime().ToString();
            textBox1.Text = shijian;
        }

        private void bingrenjilu_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
