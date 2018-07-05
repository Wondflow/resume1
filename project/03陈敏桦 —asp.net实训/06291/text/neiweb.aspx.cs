using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class text_neiweb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            showData();
            showData2();
            showData3();
            showData4();
            showData5();
            showData6();
            showData7();
          
        }
    }
    //科室动态
    public void showData()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select title from text where type='科室动态'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "text");
        DataList1.DataSource = ds.Tables[0];
        DataList1.DataBind();
        
        conn.Close();
    }
    //科研教学

    public void showData2()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select title from text where type='科研教学'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "text");
        DataList2.DataSource = ds.Tables[0];
        DataList2.DataBind();

        conn.Close();
    }

    //健康教育
    public void showData3()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select title  from text where type='健康教育'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "text");
        DataList3.DataSource = ds.Tables[0];
        DataList3.DataBind();

        conn.Close();
    }

    //科室介绍


    public void showData4()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select content from text where type='科室简介'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "text");
        DataList4.DataSource = ds.Tables[0];
        DataList4.DataBind();

        conn.Close();
    }

    //就诊指南

    public void showData5()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select pname from picture where stype='就诊指南'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "picture");
        DataList5.DataSource = ds.Tables[0];
        DataList5.DataBind();

        conn.Close();
    }

    public void showData6()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select pname from picture where stype='特殊检查项目'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "picture");
        DataList6.DataSource = ds.Tables[0];
        DataList6.DataBind();

        conn.Close();
    }
    public void showData7()
    {
        // string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\Database1.accdb");
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string str1 = " select * from picture where stype='医师介绍'";
        MySqlDataAdapter da = new MySqlDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "picture");
        DataList7.DataSource = ds.Tables[0];
        DataList7.DataBind();

        conn.Close();
    }
}