<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="web_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        body
        {
            width:900px;
            margin:20px auto;
        }
        #div1
        {
            width:900px;
            height:600px;
            margin:10px auto;
            text-align:center;
        }
        table
        {
            width:500px;
            margin:0 auto;
            }
        td,tr
        {
            border:1px solid #699;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div  id="div1">
     
        
        <table width="100%" cellspacing="0" 
            style="border-spacing: 0px; border-collapse: collapse; border-color:Navy;">                      
            <tr>
                <td colspan="2" 
                    style="font-family: 宋体, Arial, Helvetica, sans-serif; font-size: 30px">添加内容</td>
            </tr>
       <tr>
           <td bgcolor="#336666">类型：</td>
           <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
       </tr> 
     <tr>
        <td bgcolor="#336666">标题：</td>
        <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
     </tr>
     <tr>
         <td bgcolor="#336666">内容：</td>
         <td><asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox></td>
     </tr> 
         <tr> <td bgcolor="#336666">录入日期：</td>
         <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
     <tr>  
     <td colspan="2"><asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" Text="取消" onclick="Button2_Click" /></td>
      </tr>
        </table>  
        <br />
        <br />
        
        <p style=" font-size:20px;">数据的浏览、修改、删除</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Height="295px" onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" Width="900px" BackColor="White" 
            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
            GridLines="Horizontal" AllowPaging="True" 
            onpageindexchanging="GridView1_PageIndexChanging">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="type" HeaderText="类型" />
                <asp:BoundField DataField="title" HeaderText="标题" />
                <asp:BoundField DataField="content" HeaderText="内容" />
                <asp:BoundField DataField="sdate" HeaderText="录入日期" />
                <asp:CommandField HeaderText="修改" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
    </div>
   
    </form>
</body>
</html>
