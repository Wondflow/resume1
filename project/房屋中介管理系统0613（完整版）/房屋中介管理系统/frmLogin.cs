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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtPwd.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username, password;
            string strSql = "";
            DataSet ds;
            if (txtPwd.Text.Trim() != "" && txtUser.Text.Trim() != "")
            {
                username = txtPwd.Text.Trim();
                password = txtUser.Text.Trim();
                strSql = "select * from Userinfo where userID='" + txtPwd.Text + "' and userPwd='" + txtUser.Text + "'";
                DataAccess data = new DataAccess();
                data.DataCon();
                ds = data.getDataset(strSql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "登录失败");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码为空，请输入信息！","提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
