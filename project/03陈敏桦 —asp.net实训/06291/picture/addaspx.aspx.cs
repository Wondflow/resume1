using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class picture_addaspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string strcon = "Database='hospital';Data Source=localhost;user ID='root';PassWord='123456';";
        MySqlConnection conn = new MySqlConnection(strcon);
        conn.Open();
        string stype = TextBox2.Text;
        string sdate = TextBox3.Text;

        if (FileUpload1.HasFile)
        {
            string FileName = this.FileUpload1.FileName;
            string path = Server.MapPath("../images/") + FileName;
            this.FileUpload1.PostedFile.SaveAs(path);
            string path1 = "../images/" + FileName;
            string str1 = "insert into picture(pname,stype,sdate) values('"
                             + path1 + "','"
                             + stype + "','"
                             + sdate + "')";

            MySqlCommand cmd = new MySqlCommand(str1, conn);
            int res= cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Write("<script languange=javascript> alert('记录添加成功')</script>");
            }
            else
            {
                Response.Write("<script languange=javascript> alert('记录添加失败')</script>");
            }
            conn.Close();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";

    }
}