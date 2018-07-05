using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        bool bflag = false;
        string strconn = "Provider=Microsoft.Ace.oledb.12.0;data source="
        + Server.MapPath("~/app_data/examinatiion.accdb");            //..
        OleDbConnection conn = new OleDbConnection(strconn);

        conn.Open();

        string xh;
        xh = TextBox1.Text;


        string strsql = "select  * from  Info  where  xh='" + xh + "'";


        OleDbCommand cmd = new OleDbCommand(strsql, conn);

        /*OleDbDataReader myread = new OleDbDataReader();*/

        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            Label1.Text = myread[2].ToString();
            Label2.Text = myread[3].ToString();
            Session["xh"] = xh;
            Session["sname"] = myread[2].ToString();
            Session["banji"] = myread[3].ToString();
            // bflag = true;
            Button2.Visible = true;

        }
        else
        {
            Response.Write("alert('不存在该学生')");
        }

        myread.Close();
        conn.Close();

        /* if (bflag)
         {
             Response.Redirect("Main.aspx");
         }
          */
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bool bflag = false;
        if (!bflag)
        {
            Response.Redirect("kaoshi.aspx");
        }
    }
}