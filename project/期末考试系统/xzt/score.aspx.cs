using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_score : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
            OleDbConnection conn = new OleDbConnection(strcon);
            conn.Open();
            string[] arrStudent = new string[52];
            string sc = "delete * from score";
            OleDbCommand comd = new OleDbCommand(sc, conn);
            comd.ExecuteNonQuery();

            string xh;
            string sname;
            string str1;
            str1 = "select * from info";
            OleDbCommand cmd = new OleDbCommand(str1, conn);
            OleDbCommand cmd2;
            OleDbDataReader myread = cmd.ExecuteReader();
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    xh = myread[1].ToString();
                    sname = myread[2].ToString();
                    string str11 = "insert into score(xh,sname,result) values('"
                        + xh + "','"
                        + sname + "',0)";
                    cmd2 = new OleDbCommand(str11, conn);
                    cmd2.ExecuteNonQuery();
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('信息表中没有该学生信息')</script>");
                return;
            }
            myread.Close();

         
            str1 = " select top 20 * from choose";//改选择题
            cmd.CommandText = str1;
            myread = cmd.ExecuteReader();
            string[] arrXuan = new string[20];
            int i = 0;
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    arrXuan[i] = myread[6].ToString();
                    i++;
                }
            }
            myread.Close();
            string str2 = "select * from answer";
            cmd.CommandText = str2;
            myread = cmd.ExecuteReader();

            int num;
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    num = 0;
                    for (int j = 0; j < 20; j++)
                    {
                        if (arrXuan[j] == myread[2 + j].ToString())
                        {
                            num++;
                        }
                    }
                    xh = myread[1].ToString();
                    string str12 = "update score set xzt=" + num + " where xh='" + xh + "' ";
                    cmd2 = new OleDbCommand(str12, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            myread.Close();


            str1 = " select top 10 * from pdt";//改判断题
            cmd.CommandText = str1;
            myread = cmd.ExecuteReader();
            string[] arrPDT = new string[10];
            i = 0;
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    arrPDT[i] = myread[2].ToString();
                    i++;
                }
            }
            myread.Close();
            str2 = "select * from answerPDT";
            cmd.CommandText = str2;
            myread = cmd.ExecuteReader();

            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    num = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        if (arrPDT[j] == myread[2 + j].ToString())
                        {
                            num++;
                        }
                    }
                    xh = myread[1].ToString();
                    string str12 = "update score set pdt=" + num + " where xh='" + xh + "' ";
                    cmd2 = new OleDbCommand(str12, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            myread.Close();



            str1 = " select top 10 * from tkt";//改填空题
            cmd.CommandText = str1;
            myread = cmd.ExecuteReader();
            string[] arrTKT = new string[10];
            i = 0;
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    arrTKT[i] = myread[2].ToString();
                    i++;
                }
            }
            myread.Close();
            str2 = "select * from answerTKT";
            cmd.CommandText = str2;
            myread = cmd.ExecuteReader();
            if (myread.HasRows)
            {
                while (myread.Read())
                {
                    num = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        if (arrTKT[j] == myread[2 + j].ToString())
                        {
                            num++;
                        }
                    }
                    xh = myread[1].ToString();
                    string str12 = "update score set tkt=" + num + " where xh='" + xh + "' ";
                    cmd2 = new OleDbCommand(str12, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            myread.Close();
            //显示结果

            str1 = "select * from score";

            OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "score");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataKeyNames = new string[] { "xh" };
            GridView1.DataBind();
            conn.Close();


        }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("kaoshi.aspx");
    }
}