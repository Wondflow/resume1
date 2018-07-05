﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xzt_showStudent : System.Web.UI.Page
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
}