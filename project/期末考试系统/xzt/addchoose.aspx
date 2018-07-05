<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addchoose.aspx.cs" Inherits="xzt_addchoose" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 239px;
        }
        .style2
        {
            width: 239px;
            height: 20px;
        }
        .style3
        {
            height: 20px;
        }
        .style4
        {
            width: 239px;
            height: 43px;
        }
        .style5
        {
            height: 43px;
        }
        .style6
        {
            height: 61px;
        }
        body {
            margin:0 auto;
        }
       #div1
        {
            margin:0 auto;
        }
        .style7
        {
            width: 239px;
            height: 33px;
        }
        .style8
        {
            height: 33px;
        }
        table
        {
            margin-top:20px;
        }
    </style>
</head>
<body style="height: 394px; width: 759px">
    <form id="form1" runat="server">
    <div style="height: 345px; width: 741px" id="div1">
    
        <table style="width:65%; height: 309px; border-collapse: collapse; border-spacing: 1px; background-image: url('../pic/7.jpg');" 
            align="center">
            <tr>
                <td colspan="2" align="center" class="style6" 
                    
                    style="font-family: 幼圆; border: thin solid #00FFFF; font-weight: bolder; font-size: 20px;">
                    添加2016——2017学年下半年期末考试选择题</td>
            </tr>
            <tr>
                <td class="style2" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    题目：</td>
                <td class="style3" style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    A：</td>
                <td style="font-family: 幼圆; border: thin solid #00FFFF" class="style8">
                    <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    B：</td>
                <td style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C:</td>
                <td style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:TextBox ID="TextBox4" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    D：</td>
                <td style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:TextBox ID="TextBox5" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" style="font-family: 幼圆; border: thin solid #00FFFF" 
                    align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    答案：</td>
                <td style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:TextBox ID="TextBox6" runat="server" Height="29px" Width="324px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4" align="left" 
                    style="font-family: 幼圆; border: thin solid #00FFFF">
                   &nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="Button1" runat="server" Text="添加" Height="39px" Width="72px" 
                        onclick="Button1_Click" BackColor="#FF99CC" BorderColor="#FF99CC" />
                </td>
                <td align="center" class="style5" 
                    style="font-family: 幼圆; border: thin solid #00FFFF">
                    <asp:Button ID="Button2" runat="server" Text="返回" Height="39px" Width="72px" 
                        onclick="Button2_Click" BackColor="#FF99CC" BorderColor="#FF99CC" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
