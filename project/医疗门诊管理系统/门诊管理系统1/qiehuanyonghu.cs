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
    public partial class qiehuanyonghu : Form
    {
        public qiehuanyonghu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string username, password;
            string strSql = "";
            DataSet ds;
            if (textUser.Text.Trim() != "" && textPassword.Text.Trim() != "")
            {
                username = textUser.Text.Trim();
                password = textPassword.Text.Trim();
                strSql = "select * from Userinfo where Username='" + username + "'and Userpassword='" + password + "'";
                DataAccess data = new DataAccess();
                data.dataCon();
                ds = data.getDataset(strSql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    Form1 fMain = new Form1();
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
                MessageBox.Show("用户名或密码为空，请输入信息", "提示");
            } 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
