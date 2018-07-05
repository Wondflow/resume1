using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_pdt : System.Web.UI.Page
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
        string str1 = " select top 10 * from pdt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "pdt");
        DataList1.DataSource = ds;
        DataList1.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerPDT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 2;
            for (int i = 0; i < num; i++)
            {
                RadioButtonList rd1 = (RadioButtonList)(DataList1.Items[i].FindControl("RadioButtonList1"));
                string str11 = myread[i + 2].ToString();
                if (str11 == "对")
                {
                    rd1.Items[0].Selected = true;
                }
                else if(str11=="错")
                {
                    rd1.Items[1].Selected = true;
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
        string str1 = " select top 10 * from pdt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "pdt");
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
        string str1 = " select  * from answerPDT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str1, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            string str11 = "update answerPDT set " +
            "pdt1='" + arrData[0] + "'," +
            "pdt2='" + arrData[1] + "'," +
            "pdt3='" + arrData[2] + "'," +
            "pdt4='" + arrData[3] + "'," +
            "pdt5='" + arrData[4] + "'," +
            "pdt6='" + arrData[5] + "'," +
            "pdt7='" + arrData[6] + "'," +
            "pdt8='" + arrData[7] + "'," +
            "pdt9='" + arrData[8] + "'," +
            "pdt10='" + arrData[9] + "' where xh='" + xh + "'";
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
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerPDT(xh,pdt1,pdt2,pdt3,pdt4,pdt5,pdt6,pdt7,pdt8,pdt9,pdt10) values('"
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