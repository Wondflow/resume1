﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 门诊管理系统1
{
    public partial class gonghuoshangshezhi : Form
    {
        public gonghuoshangshezhi()
        {
            InitializeComponent();
        }

        private void gonghuoshangshezhi_Load(object sender, EventArgs e)
        {
             string strsql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select gonghuo as 供货商 from Gonghuoshang where 1=1" + condition;
            data.dataCon();
            ds = data.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {
            string strSql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strSql = "select gonghuo as 供货商 from Gonghuoshang where gonghuo like '%" + txtadd.Text + "%'";
            data.dataCon();
            ds = data.getDataset(strSql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtadd.Text == "")
            { MessageBox.Show("请输入完整内容!"); }
            else
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "insert into Gonghuoshang(gonghuo)values('" + txtadd.Text + "')";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            string strsql;
            string condition = "";
            DataAccess data1 = new DataAccess();
            DataSet ds;
            strsql = "select gonghuo as 供货商 from Gonghuoshang where 1=1" + condition;
            data1.dataCon();
            ds = data1.getDataset(strsql);
            dgvInfo.DataSource = ds.Tables[0];
            txtadd.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strSql;
                DataAccess data = new DataAccess();
                strSql = "delete from Gonghuoshang where gonghuo='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
                data.dataCon();
                if (data.sqlExec(strSql))
                {
                    MessageBox.Show("删除成功！");

                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                string strsql;
                string condition = "";
                DataAccess data2 = new DataAccess();
                DataSet ds;
                strsql = "select gonghuo as 供货商 from Gonghuoshang where 1=1" + condition;
                data2.dataCon();
                ds = data.getDataset(strsql);
                dgvInfo.DataSource = ds.Tables[0];
            }
        }
    }
}
