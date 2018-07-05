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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["xh"] == null)
        {
            Response.Redirect("Login1.aspx");
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
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
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
            int num = myread.FieldCount - 3;
            for (int i = 0; i < num; i++)
            {
                RadioButtonList rd1 = (RadioButtonList)(DataList1.Items[i].FindControl("RadioButtonList1"));
                string str11 = myread[i + 3].ToString();
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
        bool bflag3 = false;
        bool bflag4= false;
        bool bflag5 = false;
        bool bflag6 = false;
        bflag = updateData();
        bflag3 = updateData2();
        bflag4 = updateData3();
        bflag5 = updateData4();
        bflag6 = updateData5();
        if (bflag)
        {
            SaveData();
        }
        if (bflag3)
        {
            SaveData2();
        }
        if (bflag4)
        {
            SaveData3();
        }
        if (bflag5)
        {
            SaveData4();
        }
        if (bflag6)
        {
            SaveData5();
        }
    }
   public bool updateData()//x
    {
        bool bflag2;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
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
        string str1 = " select  * from answer where xh='" + xh + "'";
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
            "xuan20='" + arrData[19] + "' where xh='" + xh + "'";
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
   public bool updateData2()//编程题
   {
       bool bflag2;
       string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
       OleDbConnection conn = new OleDbConnection(strcon);
       conn.Open();
       int num = DataList3.Items.Count;
       string[] arrData = new string[num];
       for (int i = 0; i < num; i++)
       {
           TextBox text = (TextBox)DataList3.Items[i].FindControl("TextBox1");
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
       string xh = Label1.Text;
       string str1 = " select  * from answerBCT where xh='" + xh + "'";
       OleDbCommand cmd = new OleDbCommand(str1, conn);
       OleDbDataReader myread;
       myread = cmd.ExecuteReader();
       if (myread.HasRows)
       {
           string str11 = "update answerBCT set " +
           "bct1='" + arrData[0] + "'," +
           "bct2='" + arrData[1] + "'," +
           "bct3='" + arrData[2] + "'," +
           "bct4='" + arrData[3] + "'," +
           "bct5='" + arrData[4] + "' where xh='" + xh + "'";
           OleDbCommand cmd2 = new OleDbCommand(str11, conn);
           int res = cmd2.ExecuteNonQuery();
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
   public bool updateData3()//简答题
   {
       bool bflag2;
       string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
       OleDbConnection conn = new OleDbConnection(strcon);
       conn.Open();
       int num = DataList4.Items.Count;
       string[] arrData = new string[num];
       for (int i = 0; i < num; i++)
       {
           TextBox text = (TextBox)DataList4.Items[i].FindControl("TextBox2");
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
       string xh = Label1.Text;
       string str1 = " select  * from answerJDT where xh='" + xh + "'";
       OleDbCommand cmd = new OleDbCommand(str1, conn);
       OleDbDataReader myread;
       myread = cmd.ExecuteReader();
       if (myread.HasRows)
       {
           string str11 = "update answerJDT set " +
           "jdt1='" + arrData[0] + "'," +
           "jdt2='" + arrData[1] + "'," +
           "jdt3='" + arrData[2] + "'," +
           "jdt4='" + arrData[3] + "'," +
           "jdt5='" + arrData[4] + "' where xh='" + xh + "'";
           OleDbCommand cmd2 = new OleDbCommand(str11, conn);
           int res = cmd2.ExecuteNonQuery();
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
   public bool updateData4()//判断题更新
   {
       bool bflag2;
       string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
       OleDbConnection conn = new OleDbConnection(strcon);
       conn.Open();
       int num = DataList2.Items.Count;
       string[] arrData = new string[num];
       for (int i = 0; i < num; i++)
       {
           RadioButtonList rd1 = (RadioButtonList)DataList2.Items[i].FindControl("RadioButtonList2");
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
   public bool updateData5()
   {
       bool bflag2;
       string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion.accdb");
       OleDbConnection conn = new OleDbConnection(strcon);
       conn.Open();
       int num = DataList5.Items.Count;
       string[] arrData = new string[num];
       for (int i = 0; i < num; i++)
       {
           TextBox text = (TextBox)DataList5.Items[i].FindControl("TextBox3");
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
       string xh = Label1.Text;
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
           "tkt5='" + arrData[4] + "'," +
           "tkt6='" + arrData[5] + "'," +
           "tkt7='" + arrData[6] + "'," +
           "tkt8='" + arrData[7] + "'," +
           "tkt9='" + arrData[8] + "'," +
           "tkt10='" + arrData[9] + "' where xh='" + xh + "'";
           OleDbCommand cmd2 = new OleDbCommand(str11, conn);
           int res = cmd2.ExecuteNonQuery();
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
    public void SaveData()//选择题
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
        }
        string xh = Session["xh"].ToString();
        string type = Button2.Text;
       // string xh = "115611101001";
       // str2 += "'" + arrData[19] + "'";
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
               string str1 = " insert into answer(type,xh,xuan1,xuan2,xuan3,xuan4,xuan5,xuan6,xuan7,xuan8,xuan9,xuan10,xuan11,xuan12,xuan13,xuan14,xuan15,xuan16,xuan17,xuan18,xuan19,xuan20) values('"
               + type + "','"
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
    public void SaveData2()//编程题
    {
        int num = DataList3.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            //RadioButtonList rd1 = (RadioButtonList)DataList3.Items[i].FindControl("RadioButtonList1");
            TextBox text = (TextBox)DataList3.Items[i].FindControl("TextBox1");
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
       string type = Button4.Text;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerBCT(type,xh,bct1,bct2,bct3,bct4,bct5) values('"
        + type + "','"
        + xh + "','"
        + arrData[0] + "','"
        + arrData[1] + "','"
        + arrData[2] + "','"
        + arrData[3] + "','"
        + arrData[4] + "')";

        OleDbCommand cmd = new OleDbCommand(str1, conn);
        int n1 = cmd.ExecuteNonQuery();
        conn.Close();

    }

     public void SaveData3()//简答题
    {
        int num = DataList4.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            //RadioButtonList rd1 = (RadioButtonList)DataList1.Items[i].FindControl("RadioButtonList1");
            TextBox text = (TextBox)DataList4.Items[i].FindControl("TextBox2");
            if (text.Text != null)
            {
                arrData[i] = text.Text.ToString();
            }
            else
            {
                arrData[i] = "";
            }
            
        }
        string xh = Session["xh"].ToString();
        string type = Button5.Text;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerJDT(type,xh,jdt1,jdt2,jdt3,jdt4,jdt5) values('"
        + type + "','"
        + xh + "','"
        + arrData[0] + "','"
        + arrData[1] + "','"
        + arrData[2] + "','"
        + arrData[3] + "','"
        + arrData[4] + "')";

        OleDbCommand cmd = new OleDbCommand(str1, conn);
        int n1 = cmd.ExecuteNonQuery();
        conn.Close();

    }
      public void SaveData4()//判断题
    {
        int num = DataList2.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            RadioButtonList rd1 = (RadioButtonList)DataList2.Items[i].FindControl("RadioButtonList2");
            if (rd1.SelectedItem != null)
            {
                arrData[i] = rd1.SelectedValue.ToString();
            }
            else
            {
                arrData[i] = "";
            }
        }

       string xh = Session["xh"].ToString();
       string type = Button3.Text;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerPDT(type,xh,pdt1,pdt2,pdt3,pdt4,pdt5,pdt6,pdt7,pdt8,pdt9,pdt10) values('"
        + type + "','"
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
        conn.Close();

    }
    public void SaveData5()//填空题
    {
        int num = DataList5.Items.Count;
        string[] arrData = new string[num];
        for (int i = 0; i < num; i++)
        {
            //RadioButtonList rd1 = (RadioButtonList)DataList1.Items[i].FindControl("RadioButtonList1");
            TextBox text = (TextBox)DataList5.Items[i].FindControl("TextBox3");
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
        string type = Button6.Text;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " insert into answerTKT(type,xh,tkt1,tkt2,tkt3,tkt4,tkt5,tkt6,tkt7,tkt8,tkt9,tkt10) values('"
        + type + "','"
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
        conn.Close();

    }
  
    protected void Button3_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        DataList3.Visible = false;
        DataList4.Visible = false;
        DataList5.Visible = false; 
        DataList2.Visible = true;
        //Response.Redirect("pdt.aspx");
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 10 * from pdt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "pdt");
        DataList2.DataSource = ds;
        DataList2.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerPDT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 3;
            for (int i = 0; i < num; i++)
            {
                RadioButtonList rd1 = (RadioButtonList)(DataList2.Items[i].FindControl("RadioButtonList2"));
                string str11 = myread[i + 3].ToString();
                if (str11 == "对")
                {
                    rd1.Items[0].Selected = true;
                }
                else if (str11 == "错")
                {
                    rd1.Items[1].Selected = true;
                }

            }
            myread.Close();
        }
        conn.Close();
       
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
       // Response.Redirect("bct.aspx");
        DataList1.Visible = false;
        DataList2.Visible = false;
        DataList4.Visible = false;
        DataList5.Visible = false;
        DataList3.Visible = true;
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 5 * from bct order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "bct");
        DataList3.DataSource = ds;
        DataList3.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerBCT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 3;
            for (int i = 0; i < num; i++)
            {
                TextBox text = (TextBox)(DataList3.Items[i].FindControl("TextBox1"));
                string str11 = myread[i + 3].ToString();
                if (str11 != null)
                {
                    text.Text = str11;
                }
                if (str11 == null)
                {
                    str11 = text.Text;
                }

            }
            myread.Close();
        }
        conn.Close();
       

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        DataList2.Visible = false;
        DataList3.Visible = false;
        DataList5.Visible = false;
        DataList4.Visible = true;
        //Response.Redirect("jdt.aspx");
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 5 * from jdt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "jdt");
        DataList4.DataSource = ds;
        DataList4.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerJDT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 3;
            for (int i = 0; i < num; i++)
            {
                TextBox text = (TextBox)(DataList4.Items[i].FindControl("TextBox2"));
                string str11 = myread[i + 3].ToString();
                if (str11 != null)
                {
                    text.Text = str11;
                }
                if (str11 == null)
                {
                    str11 = text.Text;
                }

            }
            myread.Close();
        }
        conn.Close();
       
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        DataList1.Visible = false;
        DataList2.Visible = false;
        DataList3.Visible = false;
        DataList4.Visible = false;
        DataList5.Visible = true;
        //Response.Redirect("tkt.aspx");
        string strcon = "Provider=Microsoft.Ace.oledb.12.0;data source=" + Server.MapPath("~\\App_Data\\examinatiion1.accdb");
        OleDbConnection conn = new OleDbConnection(strcon);
        conn.Open();
        string str1 = " select top 10 * from tkt order by ID";
        OleDbDataAdapter da = new OleDbDataAdapter(str1, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "tkt");
        DataList5.DataSource = ds;
        DataList5.DataBind();

        string xh = Session["xh"].ToString();
        string str12 = " select  * from answerTKT where xh='" + xh + "'";
        OleDbCommand cmd = new OleDbCommand(str12, conn);
        OleDbDataReader myread;
        myread = cmd.ExecuteReader();
        if (myread.HasRows)
        {
            myread.Read();
            int num = myread.FieldCount - 3;
            for (int i = 0; i < num; i++)
            {
                TextBox text = (TextBox)(DataList5.Items[i].FindControl("TextBox3"));
                string str11 = myread[i + 3].ToString();
                if (str11 != null)
                {
                    text.Text = str11;
                }
                if (str11 == null)
                {
                    str11 = text.Text;
                }

            }
            myread.Close();
        }
        conn.Close();
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataList5.Visible = false;
        DataList2.Visible = false;
        DataList3.Visible = false;
        DataList4.Visible = false;
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
        DataList1.Visible =true;
    }
}