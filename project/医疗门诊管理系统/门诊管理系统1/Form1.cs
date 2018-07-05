using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace 门诊管理系统1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bingrendengji bing = new bingrendengji();
            //bing.MdiParent = this;
            bing.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            menzhenshoufei men = new menzhenshoufei();
            //men.MdiParent = this;
            men.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            shoufeidanchaxun shou = new shoufeidanchaxun();
            //shou.MdiParent = this;
            shou.Show();
        }

        private void 收费单统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoufeitongji shoufei = new shoufeitongji();
           //shoufei.MdiParent = this;
            shoufei.Show();
        }


        private void 明细统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mingxitongji mingxi = new mingxitongji();
            //mingxi.MdiParent = this;
            mingxi.Show();
        }

       


       

      
        private void 套餐编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taocan tao = new taocan();
           // tao.MdiParent = this;
            tao.Show();
        }

        private void 药品出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drug dr = new drug();
            //dr.MdiParent = this;
            dr.Show();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ruku ru = new ruku();
//ru.MdiParent = this;
            ru.Show();
        }

        private void 出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuku chu = new chuku();
           // chu.MdiParent = this;
            chu.Show();
        }

       

        private void 项目大类设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xiangmudalei xiang = new xiangmudalei();
           // xiang.MdiParent = this;
            xiang.Show();
        }

        private void 诊疗项目设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zhenliaoxiangmu zhen = new zhenliaoxiangmu();
           // zhen.MdiParent = this;
            zhen.Show();
        }

        private void 科室设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keshishezhi keshi = new keshishezhi();
           // keshi.MdiParent = this;
            keshi.Show();
        }

        private void 医生设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yishengshezhi yisheng = new yishengshezhi();
          //  yisheng.MdiParent = this;
            yisheng.Show();
        }

        private void 计量单位设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jiliangdanweishezhi ji = new jiliangdanweishezhi();
           // ji.MdiParent = this;
            ji.Show();
        }

        private void 药品规格设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yaopinchandishezhi yao = new yaopinchandishezhi();
           // yao.MdiParent = this;
            yao.Show();
        }

        private void 药品剂型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yaopinjixingshezhi jixing = new yaopinjixingshezhi();
          //  jixing.MdiParent = this;
            jixing.Show();
        }

        private void 药品场地设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yaopinchandishezhi di = new yaopinchandishezhi();
           // di.MdiParent = this;
            di.Show();
        }

        private void 供货商设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gonghuoshangshezhi gong = new gonghuoshangshezhi();
           // gong.MdiParent = this;
            gong.Show();
        }

        private void 出库单位设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chukudanwei chu = new chukudanwei();
          //  chu.MdiParent = this;
            chu.Show();
        }

        private void 用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user ue = new user();
            //ue.MdiParent = this;
            ue.Show();
        }


        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qiehuanyonghu qiehuan = new qiehuanyonghu();
            //qiehuan.MdiParent = this;
            qiehuan.Show();
        }


        private void 退出系统ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentDatabasePath = Environment.CurrentDirectory + @"\DataAccess.mdb";//获取数据库位置

            FolderBrowserDialog fbd = new FolderBrowserDialog();//弹出选位置窗体
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString();
                File.Copy(CurrentDatabasePath, PathtobackUp + @"\DataAccess.mdb", true);
                MessageBox.Show("备份成功！！");
            }
        }

        private void 数据恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentDatabasePath = Application.StartupPath.ToString() + @"\DataAccess.mdb";//还原数据库文件位置
            FolderBrowserDialog fbd = new FolderBrowserDialog();//弹出选位置窗体
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString() + @"\DataAccess.mdb";
                File.Copy(PathtobackUp, CurrentDatabasePath, true);

                MessageBox.Show("还原成功！！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 药房管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            taocan tao = new taocan();
            // tao.MdiParent = this;
            tao.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            taocan tao = new taocan();
            // tao.MdiParent = this;
            tao.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string shi=DateTime.Now.ToLocalTime().ToString();        // 2008-9-4 20:12:12
          /* string y= DateTime.Now.Year.ToString();         //获取年份 
           string mo=DateTime.Now.Month.ToString();     //获取月份  
           //string x=DateTime.Now.DayOfWeek.ToString(); //获取星期
            string d = DateTime.Now.DayOfYear.ToString(); //获取第几天  
            string h = DateTime.Now.Hour.ToString();//获取系统时间小时
            string m = DateTime.Now.Minute.ToString();//获取系统时间分钟
            string s = DateTime.Now.Second.ToString();//获取系统时间秒*/
            label2.Text = "时间:" + shi;// y + "年" + mo+ "月"+d+"日" + h + "：" + m +"："+ s ;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bingrendengji bing = new bingrendengji();
            //bing.MdiParent = this;
            bing.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menzhenshoufei men = new menzhenshoufei();
            //men.MdiParent = this;
            men.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            shoufeidanchaxun shou = new shoufeidanchaxun();
            //shou.MdiParent = this;
            shou.Show();
        }
        

        private void button15_Click(object sender, EventArgs e)
        {
            drug dr = new drug();
            //dr.MdiParent = this;
            dr.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ruku ru = new ruku();
            //ru.MdiParent = this;
            ru.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chuku chu = new chuku();
            // chu.MdiParent = this;
            chu.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            xiangmudalei xiang = new xiangmudalei();
            // xiang.MdiParent = this;
            xiang.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            zhenliaoxiangmu zhen = new zhenliaoxiangmu();
            // zhen.MdiParent = this;
            zhen.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            keshishezhi keshi = new keshishezhi();
            // keshi.MdiParent = this;
            keshi.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            yishengshezhi yisheng = new yishengshezhi();
            //  yisheng.MdiParent = this;
            yisheng.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            jiliangdanweishezhi ji = new jiliangdanweishezhi();
            // ji.MdiParent = this;
            ji.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            yaopinchandishezhi yao = new yaopinchandishezhi();
            // yao.MdiParent = this;
            yao.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            yaopinchandishezhi di = new yaopinchandishezhi();
            // di.MdiParent = this;
            di.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            gonghuoshangshezhi gong = new gonghuoshangshezhi();
            // gong.MdiParent = this;
            gong.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            chukudanwei chu = new chukudanwei();
            //  chu.MdiParent = this;
            chu.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            yaopinjixingshezhi jixing = new yaopinjixingshezhi();
            //  jixing.MdiParent = this;
            jixing.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            user ue = new user();
            //ue.MdiParent = this;
            ue.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string CurrentDatabasePath = Environment.CurrentDirectory + @"\DataAccess.mdb";//获取数据库位置

            FolderBrowserDialog fbd = new FolderBrowserDialog();//弹出选位置窗体
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString();
                File.Copy(CurrentDatabasePath, PathtobackUp + @"\DataAccess.mdb", true);
                MessageBox.Show("备份成功！！");
            }
        }


        private void 数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("初始化成功！！");
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            string CurrentDatabasePath = Application.StartupPath.ToString() + @"\DataAccess.mdb";//还原数据库文件位置
            FolderBrowserDialog fbd = new FolderBrowserDialog();//弹出选位置窗体
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string PathtobackUp = fbd.SelectedPath.ToString() + @"\DataAccess.mdb";
                File.Copy(PathtobackUp, CurrentDatabasePath, true);

                MessageBox.Show("还原成功！！");
            }
        }

        
   
    }
}
