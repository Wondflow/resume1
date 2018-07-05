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
    public partial class frmSellingEdit : Form
    {
        public frmSellingEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strSql = "";
            if (txtAddress.Text != "" && txtArea.Text != "" && txtDct.Text != "" && txtFloor.Text != "" && txtPrice.Text != "" && txtptss.Text != "" && txtYear.Text != "" && cboType.Text != "")
            {
                strSql = "update chushouinfo set sarea ='" + txtArea.Text + "', sprice ='" + txtPrice.Text + "', shouseType ='" + cboType.Text + "', saddress ='" + txtAddress.Text + "', syear ='" + txtYear.Text + "', sfloor='" + txtFloor.Text + "', sdecoration ='" + txtDct.Text + "', sremarks='" + txtptss.Text + "' where sellingID='" + txtSid.Text + "'";
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

        private void frmSellingEdit_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmSellingManagement.sid;
        }
    }
}
