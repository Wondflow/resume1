using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;

public partial class xzt_kaoshi : System.Web.UI.Page
{
    //public DataSet ds;
   // string[] arr
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
            ShowData();
        }
    }
     public void ShowData()
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 20 * from choose order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "choose");
        DataList1.DataSource = ds;
        DataList1.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answer where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount-2;
            for (int i = 0; i < num; i++)
            {
               RadioButtonList rd1 = (RadioButtonList)(DataList1.Items[i].FindControl("RadioButtonList1"));
                string str11 = myread[i+2].ToString();
                if (str11 == "A")
                {
                    rd1.Items[0].Selected = true;
                }
                else if (str11 == "B")
                {
                    rd1.Items[1].Selected = true;
                }
                else if (str11 == "C")
                {
                    rd1.Items[2].Selected = true;
                }
                else if (str11 == "D")
                {
                    rd1.Items[3].Selected = true;
                }

            }
            myread.Close();
        }
        
        conn.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool bflag = false;
        bflag = updateData();
        if (bflag)
        {
            SaveData();
        }
    }
    public bool updateData()
    {
        bool bflag2;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
         int num = DataList1.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            RadioButtonList rd1 = (RadioButtonList)DataList1.Items[i].FindControl("RadioButtonList1");
            if (rd1.SelectedItem != null)
            {
                arrData[i] = rd1.SelectedValue.ToString();
            }
            else
            {
                arrData[i] = "";
            }
            //string str1 = rd1.SelectedItem.Text;
        }
        string xh = Label1.Text;
        string str1 = " select  * from answer where xh='"+xh+"'";
        OleDbCommand cmd = new OleDbCommand(str1, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            string str11 = "update answer set " +
            "xuan1='" + arrData[0] + "'," +
            "xuan2='" + arrData[1] + "'," +
            "xuan3='" + arrData[2] + "'," +  
            "xuan4='" + arrData[3] + "'," +
            "xuan5='" + arrData[4] + "'," +
            "xuan6='" + arrData[5] + "'," +  
            "xuan7='" + arrData[6] + "'," +
            "xuan8='" + arrData[7] + "'," +
            "xuan9='" + arrData[8] + "'," +  
            "xuan10='" + arrData[9] + "'," +
            "xuan11='" + arrData[10] + "'," +
            "xuan12='" + arrData[11] + "'," +  
            "xuan13='" + arrData[12] + "'," +
            "xuan14='" + arrData[13] + "'," +
            "xuan15='" + arrData[14] + "'," +
            "xuan16='" + arrData[15] + "'," +
            "xuan17='" + arrData[16] + "'," +
            "xuan18='" + arrData[17] + "'," +  
            "xuan19='" + arrData[18] + "'," +
            "xuan20='" + arrData[19] + "' where xh='" + xh+"'";
            OleDbCommand cmd2 = new OleDbCommand(str11,conn);
            int res = cmd2.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Write("ok");
            }
            else
            {
                Response.Write("no");
            }
            bflag2 = false;
        }
        else
        {
            bflag2 = true;
        }
        myread.Close();
        conn.Close();
        return bflag2;
    }
    public void SaveData()
    {
        int num = DataList1.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            RadioButtonList rd1 = (RadioButtonList)DataList1.Items[i].FindControl("RadioButtonList1");
            if (rd1.SelectedItem != null)
            {
                arrData[i] = rd1.SelectedValue.ToString();
            }
            else
            {
                arrData[i] = "";
            }
            //string str1 = rd1.SelectedItem.Text;
        }
        string xh = Session["xh"].ToString();
        string type = Button2.Text;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
               string str1 = " insert into answer(xh,xuan1,xuan2,xuan3,xuan4,xuan5,xuan6,xuan7,xuan8,xuan9,xuan10,xuan11,xuan12,xuan13,xuan14,xuan15,xuan16,xuan17,xuan18,xuan19,xuan20) values('"
               + xh + "','"
               + arrData[0] + "','"
               + arrData[1] + "','"
               + arrData[2] + "','"
               + arrData[3] + "','"
               + arrData[4] + "','"
               + arrData[5] + "','"
               + arrData[6] + "','"
               + arrData[7] + "','"
               + arrData[8] + "','"
               + arrData[9] + "','"
               + arrData[10] + "','"
               + arrData[11] + "','"
               + arrData[12] + "','"
               + arrData[13] + "','"
               + arrData[14] + "','"
               + arrData[15] + "','"
               + arrData[16] + "','"
               + arrData[17] + "','"
               + arrData[18] + "','"
               + arrData[19] + "')";

               OleDbCommand cmd = new OleDbCommand(str1, conn);
               int n1 = cmd.ExecuteNonQuery();
               if (n1 > 0)
                   Response.Write("ok");
               conn.Close();
            
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 20 * from choose order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "choose");
        DataList1.DataSource = ds;
        DataList1.DataBind();
        conn.Close();

    }
   /* protected void Button3_Click1(object sender, EventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 20 * from pdt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "pdt");
        DataList2.DataSource = ds;
        DataList2.DataBind();
        conn.Close();
    }*/
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("pdt.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("bct.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("jdt.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("tkt.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("score.aspx");
    }
}