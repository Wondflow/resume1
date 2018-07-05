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
    public partial class frmAddStu : Form
    {
        public frmAddStu()
        {
            InitializeComponent();
        }

        private void txtSid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            strSql ="insert into Studentinfo(Sid,Sname,Sex,Birthday,Class,Tel,Adress) values('"+txtSid .Text +"','"+txtSName .Text +"','"+cboSex.Text  +"','"+txtBirth .Text +"','"+txtClass .Text +"','"+txtTel .Text +"','"+txtAddress.Text+"')";
            data.DataCon();
            if (data.sqlExec(strSql))
            {
                MessageBox.Show("添加成功！！");
            }
            else
            {
                MessageBox.Show("添加失败！！");
            }
        }
    }
}
