<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addFilling.aspx.cs" Inherits="fill_addFilling" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        body
        {
            
            margin:0 auto;
        }
        #div1
        {
            margin:20px auto;
            border:1px solid blue;
            text-align:center;
        }
    </style>
</head>
<body style="height: 261px; width: 877px">
    <form id="form1" runat="server">
    <div style="height: 252px; width: 390px" id="div1">
    
        添加填空题<br />
        <br />
        题目：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        答案：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="38px" onclick="Button1_Click" 
            Text="添加" Width="73px" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="36px" Text="取消" Width="68px" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="33px" Text="返回" Width="72px" />
    
    </div>
    </form>
</body>
</html>
