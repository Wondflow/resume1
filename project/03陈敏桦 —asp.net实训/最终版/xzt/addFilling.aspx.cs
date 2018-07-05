using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class fill_addFilling : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("../App_Data/examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();

        string title;
        title = TextBox1.Text;

        string answer;
        answer = TextBox2.Text;

        string str1 = " insert into tkt(title,answer) values('" + title + "','" + answer + "')";

        OleDbCommand cmd = new OleDbCommand(str1, conn);
        int n1 = cmd.ExecuteNonQuery();
        if (n1 > 0)
            Response.Write("ok");
        conn.Close();
    }
}