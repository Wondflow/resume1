using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_tkt : System.Web.UI.Page
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
            ShowData();
        }
    }
    public void ShowData()
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 10 * from tkt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "tkt");
        DataList1.DataSource = ds;
        DataList1.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerTKT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 2;
            for (int i = 0; i < num; i++)
            {
                TextBox text = (TextBox)(DataList1.Items[i].FindControl("TextBox1"));
                string str11 = myread[i + 2].ToString();
                if (str11 !="")
                {
                    text.Text = str11;
                }

            }
            myread.Close();
        }
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 10 * from tkt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "tkt");
        DataList1.DataSource = ds;
        DataList1.DataBind();
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
            TextBox text = (TextBox)(DataList1.Items[i].FindControl("TextBox1"));
            if (text.Text != null)
            {
                arrData[i] = text.Text.ToString();
            }
            else
            {
                arrData[i] = "";
            }
            //string str1 = rd1.SelectedItem.Text;
        }
        string xh = Session["xh"].ToString();
        string str1 = " select  * from answerTKT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str1, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            string str11 = "update answerTKT set " +
            "tkt1='" + arrData[0] + "'," +
            "tkt2='" + arrData[1] + "'," +
            "tkt3='" + arrData[2] + "'," +
            "tkt4='" + arrData[3] + "'," +
            "tkt5='" + arrData[4] + "',"+
            "tkt6='" + arrData[5] + "'," +
            "tkt7='" + arrData[6] + "'," +
            "tkt8='" + arrData[7] + "'," +
            "tkt9='" + arrData[8] + "'," +
            "tkt10='" + arrData[9] + "' where xh='" + xh + "'";
            OleDbCommand cmd2 = new OleDbCommand(str11, conn);
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
            //RadioButtonList rd1 = (RadioButtonList)DataList1.Items[i].FindControl("RadioButtonList1");
            TextBox text = (TextBox)(DataList1.Items[i].FindControl("TextBox1"));
            if (text.Text != null)
            {
                arrData[i] = text.Text.ToString();
            }
            else
            {
                arrData[i] = "";
            }
            //string str1 = rd1.SelectedItem.Text;
        }
        string xh = Session["xh"].ToString();
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerTKT(xh,tkt1,tkt2,tkt3,tkt4,tkt5,tkt6,tkt7,tkt8,tkt9,tkt10) values('"
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
        + arrData[9] + "')";

        OleDbCommand cmd = new OleDbCommand(str1, conn);
        int n1 = cmd.ExecuteNonQuery();
        if (n1 > 0)
            Response.Write("ok");
        conn.Close();

    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("kaoshi.aspx");
    }
}