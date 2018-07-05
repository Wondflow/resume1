using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["xh"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
            Label1.Text = Session["xh"].ToString();
            Label2.Text = Session["sname"].ToString();
            Label3.Text = Session["banji"].ToString();
        }
    }
    public void getXZT(OleDbConnection conn)
    {
        int num;

        string str1 = " select * from choose";
        OleDbCommand cmd = new OleDbCommand(str1, conn);

        OleDbDataReader myread = cmd.ExecuteReader();
        if (!myread.HasRows)
        {
            Response.Write("<script language=javascript> alert('选择题数据表里没有数据')</script>");
            return;
        }
        num = 0;

        while (myread.Read())
        {
            num++;
        }

        int[] arrData = new int[20];
        bool[] arrflag = new bool[num];

        int i = 0;
        Random rnd = new Random();

        while (i < 20)
        {
            int val = rnd.Next(1, num);
            if (arrflag[val] == false)
            {
                arrflag[val] = true;
                arrData[i] = val;
                i++;
            }
        }
        myread.Close();
        cmd.CommandText = str1;
        myread = cmd.ExecuteReader();//重新打开 OleDbDataReader
        int k = 1;

        string title1, xuanA1, xuanB1, xuanC1, xuanD1, answer1;

        while (myread.Read())
        {
            for (i = 0; i < 20; i++)
            {
                int data1 = arrData[i];
                if (k == data1)
                {
                    title1 = myread[1].ToString();
                    xuanA1 = myread[2].ToString();
                    xuanB1 = myread[3].ToString();
                    xuanC1 = myread[4].ToString();
                    xuanD1 = myread[5].ToString();
                    answer1 = myread[6].ToString();
                    string str12 = " insert into choose1(title,xuanA,xuanB,xuanC,xuanD,answer) values('"
                   + title1 + "','"
                   + xuanA1 + "','"
                   + xuanB1 + "','"
                   + xuanC1 + "','"
                   + xuanD1 + "','"
                   + answer1 + "')";
                    OleDbCommand cmd2 = new OleDbCommand(str12, conn);
                    cmd2.ExecuteNonQuery();
                    i = 20;
                }

            }
            k++;
        }



    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        /*string str1 = " select * from choose";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "choose");
        DataList1.DataSource = ds;
        DataList1.DataBind();
        conn.Close();*/
        getXZT(conn);
        string str1 = " select * from choose1";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "choose1");
        DataList1.DataSource = ds;
        DataList1.DataBind();
        conn.Close();



      /*  string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\student.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();

        if (CheckBox1.Checked == true)
        {
            getXZT(conn);
        }
        conn.Close();*/
   
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string A = "";
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();


        RadioButton box1 = ((RadioButton)DataList1.FindControl("Radiobutton1"));
        RadioButton box2 = ((RadioButton)DataList1.FindControl("Radiobutton2"));
        RadioButton box3 = ((RadioButton)DataList1.FindControl("Radiobutton3"));
        RadioButton box4 = ((RadioButton)DataList1.FindControl("Radiobutton4"));
        if (box1.Checked == true)
        {
            A = ((RadioButton)DataList1.FindControl("Radiobutton1")).Text.ToString();
        }
        if (box2.Checked == true)
        {
            A = ((RadioButton)DataList1.FindControl("Radiobutton2")).Text.ToString();
        }
        if (box3.Checked == true)
        {
            A = ((RadioButton)DataList1.FindControl("Radiobutton3")).Text.ToString();
        }
        if (box4.Checked == true)
        {
            A = ((RadioButton)DataList1.FindControl("Radiobutton4")).Text.ToString();
        }
        string str1 = " insert into answer(answer) values('"
             + A + "')";

        OleDbCommand cmd = new OleDbCommand(str1, conn);
        int n1 = cmd.ExecuteNonQuery();
        if (n1 > 0)
            Response.Write("ok");
        conn.Close();
   
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
    }

    public string Label4 { get; set; }
}