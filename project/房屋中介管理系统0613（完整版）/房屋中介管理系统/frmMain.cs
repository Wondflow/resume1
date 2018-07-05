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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 出租房屋信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenthouse renthouse = new frmRenthouse();
            renthouse.MdiParent = this;
            renthouse.Show();
        }

        private void 出租房屋信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentMangement  rentManagement = new frmRentMangement ();
            rentManagement.MdiParent = this;
            rentManagement.Show();
        }

        private void 出租房屋信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentMangement rentManagement = new frmRentMangement();
            rentManagement.MdiParent = this;
            rentManagement.Show();
        }

        private void 出租房屋信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentMangement rentManagement = new frmRentMangement();
            rentManagement.MdiParent = this;
            rentManagement.Show();
        }

        private void 出售房屋信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellinghouse sellinghouse = new frmSellinghouse();
            sellinghouse.MdiParent = this;
            sellinghouse.Show();
        }

        private void 出售房屋信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellingManagement sellingManagement = new frmSellingManagement();
            sellingManagement.MdiParent = this;
            sellingManagement.Show();
        }

        private void 出售房屋信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSellingManagement sellingManagement = new frmSellingManagement();
            sellingManagement.MdiParent = this;
            sellingManagement.Show();
        }

        private void 出售房屋信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSellingManagement sellingManagement = new frmSellingManagement();
            sellingManagement.MdiParent = this;
            sellingManagement.Show();
        }

        private void 求租房屋信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuntinghouse huntinghouse = new frmHuntinghouse();
            huntinghouse.MdiParent = this;
            huntinghouse.Show();
        }

        private void 求租房屋信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuntingManagement huntingManagement = new frmHuntingManagement();
            huntingManagement.MdiParent = this;
            huntingManagement.Show();
        }

        private void 求租房屋信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuntingManagement huntingManagement = new frmHuntingManagement();
            huntingManagement.MdiParent = this;
            huntingManagement.Show();
        }

        private void 求租房屋信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHuntingManagement huntingManagement = new frmHuntingManagement();
            huntingManagement.MdiParent = this;
            huntingManagement.Show();
        }

        private void 求购房屋信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalehourse salehouse = new frmSalehourse();
            salehouse.MdiParent = this;
            salehouse.Show();
        }

        private void 求购房屋信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleManagement salemanagement = new frmSaleManagement();
            salemanagement.MdiParent = this;
            salemanagement.Show();
        }

        private void 求购房屋信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleManagement salemanagement = new frmSaleManagement();
            salemanagement.MdiParent = this;
            salemanagement.Show();
        }

        private void 求购房屋信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaleManagement salemanagement = new frmSaleManagement();
            salemanagement.MdiParent = this;
            salemanagement.Show();
        }

        
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmRentMangement rent = new frmRentMangement();
            rent.MdiParent = this;
            rent.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSellingManagement sell = new frmSellingManagement();
            sell.MdiParent = this;
            sell.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmHuntingManagement hunting = new frmHuntingManagement();
            hunting.MdiParent = this;
            hunting.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmSaleManagement sale = new frmSaleManagement();
            sale.MdiParent = this;
            sale.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.MdiParent = this;
            about.Show();
        }
    }
}
