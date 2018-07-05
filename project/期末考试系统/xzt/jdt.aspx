<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jdt.aspx.cs" Inherits="xzt_jdt" %>

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
    <div style="height: 1037px">
    
        <p>2016——2017学年下半年ASP.NET期末考试试题</p>
       <p> 学号：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 班级：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p> 
    
        完成题目后请按提交按钮：<asp:Button 
            ID="Button1" runat="server" Height="31px" onclick="Button1_Click" 
            Text="提交" Width="69px" />
        <br />
        <br />
        <br />
        返回主页面：
         
        <asp:Button ID="Button7" runat="server" Height="33px" onclick="Button7_Click" 
            Text="返回" Width="67px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" BackColor="White" 
            BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            GridLines="Horizontal" Width="561px">
            <AlternatingItemStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="109px" TextMode="MultiLine" 
                    Width="227px"></asp:TextBox>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
