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
    public partial class frmHuntingEdit : Form
    {
        public frmHuntingEdit()
        {
            InitializeComponent();
        }

      private void button1_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (txtArea.Text != "" && txtCname.Text != "" && txtDct.Text != "" && txtPrice.Text != "" && txtTel.Text != "" && cboSex.Text != "" && cboType.Text != "")
            {
                strSql = "update qiuzhuinfo set harea ='" + txtArea.Text + "', hprice ='" + txtPrice.Text  + "', hhouseType ='" + cboType.Text + "' , hdecoration ='" + txtDct.Text + "', customerName ='" + txtCname.Text + "', ctelephone ='" + txtTel.Text + "', csex ='" + cboSex.Text + "'  where customerID = '"+ txtCid.Text+"'";
                DataAccess data = new DataAccess();
                data.DataCon();//连接数据库
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("输入未完全");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHuntingEdit_Load(object sender, EventArgs e)
        {
            txtCid.Text = frmHuntingManagement.customerID;
        }
    }
}
