<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addProgram.aspx.cs" Inherits="program_addProgram" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <style type="text/css">
        body
        {
            height: 286px; 
            width: 764px;
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
<body style="height: 587px; width: 1040px">
    <form id="form1" runat="server">
    <div style="height: 403px; width: 622px" id="div1">
    
        添加编程题<br />
        <br />
        题目：<asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        答案：<asp:TextBox ID="TextBox2" runat="server" Height="157px" 
            TextMode="MultiLine" Width="354px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;
        <asp:Button ID="Button1" runat="server" Height="38px" Text="添加" Width="64px" 
            onclick="Button1_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="38px" Text="取消" Width="64px" 
            onclick="Button2_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="38px" Text="返回" Width="64px" />
    
    </div>
    </form>
</body>
</html>
