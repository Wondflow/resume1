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
    public partial class frmEditStu : Form
    {
        public frmEditStu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string strSql;
            if (txtName.Text != "" && txtBirth.Text != "" && txtClass.Text != "" && txtTel.Text != "" && txtAddress.Text != "" && cboSex.Text != "")
            { 
                strSql ="update Studentinfo set Sname='"+txtName .Text +"',Sex='"+cboSex .Text+"', Birthday='"+txtBirth .Text +"',Class='"+txtClass .Text +"',Tel='"+txtTel .Text+ "',Adress='"+txtAddress .Text +"' where Sid='"+frmManageStu.sid  +"'";
                DataAccess data = new DataAccess();
                data.DataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("修改成功！！！");
                }
                else
                {
                    MessageBox.Show("修改失败！！！");
                }


            }
            else
            {
                MessageBox.Show(" 输入未完全！！！");
            }
            
 
        }

        private void frmEditStu_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmManageStu.sid;
        }
    }
}
