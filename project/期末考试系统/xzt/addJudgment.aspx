<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addJudgment.aspx.cs" Inherits="judgment_addJudgment" %>

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
<body>
    <form id="form1" runat="server">
    <div style="height: 246px; width: 518px" id="div1">
    
        添加判断题<br />
        <br />
        题目：<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="391px"></asp:TextBox>
        <br />
        <br />
        <br />
        答案：<asp:RadioButton 
            ID="RadioButton1" runat="server" Text="对" GroupName="answer" />
&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" Text="错" GroupName="answer" />
    
        <br />
&nbsp;&nbsp;
        <br />
&nbsp;
        <br />
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="31px" Text="添加" Width="70px" 
            onclick="Button1_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="31px" Text="取消" Width="70px" 
            onclick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>
