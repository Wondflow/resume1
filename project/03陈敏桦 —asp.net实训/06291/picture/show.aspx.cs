using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class picture_show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            showData();
        }
    }
    public void showData()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select * from picture";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "picture");
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataKeyNames = new string[] { "ID" };
        GridView1.DataBind();
        conn.Close();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        showData();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        showData();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();

        string sid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(sid);

        string str1 = " delete from picture where id=" + id;
        MySqlCommand cmd = new MySqlCommand(str1, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Write("<script languange=javascript> alert('记录被删除')</script>");
        }
        else
        {
            Response.Write("<script languange=javascript> alert('记录删除失败')</script>");
        }
        conn.Close();
        showData();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();

        string v1, v2, v3;

        v1 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
        v2 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
        v3 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();



        string sid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(sid);

        string str1 = "update picture set " +
            "pname='" + v1 + "'," +
            "stype='" + v2 + "'," +
            "sdate='" + v3 + "'  where ID=" + id;

        MySqlCommand cmd = new MySqlCommand(str1, conn);
        int res = cmd.ExecuteNonQuery();
        if (res > 0)
        {
            Response.Write("<script languange=javascript> alert('记录更新成功')</script>");
        }
        else
        {
            Response.Write("<script languange=javascript> alert('记录更新失败')</script>");
        }
        conn.Close();
        GridView1.EditIndex = -1;
        showData();
    }
}