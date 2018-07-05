using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 房屋中介管理系统
{
    public partial class frmHuntinghouse : Form
    {
        public frmHuntinghouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();//实例化数据库
            strSql = "insert into qiuzhuinfo(customerID,harea , hprice , hhouseType , haddress , hdecoration ,customerName , ctelephone ,csex)values('" + txtCid.Text + "','" + txtArea.Text + "','" + txtPrice.Text + "','" + cboType.Text + "','" + txtAddress.Text + "','" + txtDct.Text + "','" + txtCname.Text + "','" + txtTel.Text + "','" + cboSex.Text + "' )";
            data.DataCon();//连接数据库
            if (data.sqlExec(strSql))//判断数据是否添加成功
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
