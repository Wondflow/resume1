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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }

        private void 学生信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStu AddStu = new frmAddStu();
            AddStu.MdiParent = this;
            AddStu.Show();
        }

        private void 学生信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }

        private void 学生信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStu ManageStu = new frmManageStu();
            ManageStu.MdiParent = this;
            ManageStu.Show();
        }

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }

        private void 课程信息添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCourse AddCourse = new frmAddCourse();
            AddCourse.MdiParent = this;
            AddCourse.Show();
        }

        private void 课程信息修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }

        private void 课程信息删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageCourse ManageCourse = new frmManageCourse();
            ManageCourse.MdiParent = this;
            ManageCourse.Show();
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }

        private void 成绩添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddScore AddScore = new frmAddScore();
            AddScore.MdiParent = this;
            AddScore.Show();
        }

        private void 成绩修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }

        private void 成绩删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageScore ManageScore = new frmManageScore();
            ManageScore.MdiParent = this;
            ManageScore.Show();
        }

        private void 版本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.MdiParent = this;
            About.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
