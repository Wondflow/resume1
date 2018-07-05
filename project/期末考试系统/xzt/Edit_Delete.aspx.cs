﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_Edit_Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ShowData();
        }

    }
    public void ShowData()
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select * from info";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "info");
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataKeyNames = new string[] { "ID" };
        GridView1.DataBind();
        conn.Close();

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        ShowData();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        ShowData();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        ShowData();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();

        string v1, v2, v3;

        v1 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
        v2 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
        v3 = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();



        string sid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(sid);

        string str1 = "update info set " +
            "xh='" + v1 + "'," +
            "sname='" + v2 + "'," +
            "banji='" + v3 + "'  where ID=" + id;

        OleDbCommand cmd = new OleDbCommand(str1, conn);
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
        ShowData();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();

        string sid = GridView1.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(sid);

        string str1 = " delete from studentInfo where id=" + id;
        OleDbCommand cmd = new OleDbCommand(str1, conn);
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
        ShowData();
    }
}