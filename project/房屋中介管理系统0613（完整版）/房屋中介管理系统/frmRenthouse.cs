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
    public partial class frmRenthouse : Form
    {
        public frmRenthouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();//实例化数据库
            strSql = "insert into rentinfo(rentID ,rarea , rprice , rhouseType ,raddress , ryear , rfloor , rdecoration ,rremarks,rhqingkuang) values( '" + txtRid.Text + "','" + txtArea.Text + "','" + txtPrice.Text + "','" + cboType.Text + "','" + txtAddress.Text + "','" + txtYear.Text + "','" + txtFloor.Text + "','" + txtDct.Text + "','" + txtPtss.Text + "','"+txtrhQK .Text +"' )";
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
