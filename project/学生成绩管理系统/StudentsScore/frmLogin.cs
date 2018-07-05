using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentsScore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtName.Focus();//将光标放在用户名文本框上

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username, password;//定义两个变量来存储文本框中的文本
            string strSql = "";
            DataSet ds;
            if (txtName.Text.Trim() != "" && txtPwd.Text.Trim() != "")//判断文本框是否为空
            {
                username = txtName.Text.Trim();
                password = txtPwd.Text.Trim();
                strSql = "select * from Userinfo where Userid='" + username + "' and Userpwd='" + password + "'";
                DataAccess data = new DataAccess();//实例化类
                data.DataCon();//连接数据库
                ds = data.getDataset(strSql);//执行查询语句strSql，获取DataSet
                //判断shifo
                if (ds.Tables[0].Rows.Count == 1)
                {
                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码输入有误！！！", "登陆失败");
                }
            }
            else
            {
                MessageBox.Show(" 用户名或密码为空,请输入信息！！！", "提示");
            }

        }
    }
}
