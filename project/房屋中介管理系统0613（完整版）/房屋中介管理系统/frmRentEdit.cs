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
    public partial class frmRentEdit : Form
    {
        public frmRentEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (txtAddress.Text != "" && txtArea.Text != "" && txtDct.Text != "" && txtFloor.Text != "" && txtPrice.Text != "" && txtPtss.Text != "" && txtYear.Text != "" && cboType .Text !="")
            {
                strSql = "update rentinfo set rarea ='" + txtArea.Text + "', rprice ='" + txtPrice.Text + "', rhouseType ='" + cboType.Text + "', raddress ='" + txtAddress.Text + "', ryear ='" + txtYear.Text + "', rfloor ='" + txtFloor.Text + "', rdecoration ='" + txtDct.Text + "', rremarks ='" + txtPtss.Text + "'  where rentID ='"+txtRid .Text +"'";
                DataAccess data = new DataAccess();
                data.DataCon();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void frmRentEdit_Load(object sender, EventArgs e)
        {
            txtRid.Text = frmRentMangement.rentID ;
        }
    }
}
 