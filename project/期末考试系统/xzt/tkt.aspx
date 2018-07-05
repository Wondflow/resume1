<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tkt.aspx.cs" Inherits="xzt_tkt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        p
        {
            text-align:center;
            font-family:@幼圆;
            font-size:20px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 530px">
    
        <p>2016——2017学年下半年ASP.NET期末考试试题</p>
       <p> 学号：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 班级：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p> 
    
        完成题目后请按提交按钮：<asp:Button 
            ID="Button1" runat="server" Height="28px" onclick="Button1_Click" 
            Text="提交" Width="62px" />
         <br />
        <br />
         返回主页面：&nbsp; 
        <asp:Button ID="Button7" runat="server" Height="27px" onclick="Button7_Click" 
            Text="返回" Width="66px" />
&nbsp;&nbsp;&nbsp;<br />
    
        <br />
&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
            Width="631px">
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
