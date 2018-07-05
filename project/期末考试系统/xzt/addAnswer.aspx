<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addAnswer.aspx.cs" Inherits="S_answer_addAnswer" %>

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
             height: 460px; 
             width: 547px;
             margin-top:20px;
             border:1px solid blue;
             margin:20px auto;
             text-align:center;
         }
         h2
         {
             text-align:center;
         }
    </style>
</head>
<body style="height: 654px; width: 763px">
    <form id="form1" runat="server">
    <div id="div1">
    
        <h2>添加简答题</h2><br />
        &nbsp;
        题目：<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="329px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;
        答案：<asp:TextBox ID="TextBox2" runat="server" Height="169px" 
            TextMode="MultiLine" Width="332px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="35px" Text="添加" Width="73px" 
            onclick="Button1_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="35px" Text="清空" 
            Width="73px" onclick="Button2_Click" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="35px" Text="返回" 
            Width="73px" />
    
    </div>
    </form>
</body>
</html>
