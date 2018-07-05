<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="xzt_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            margin:0 auto;
        }
        .style1
        {
            width: 38%;
        }
        #div1
        {
            margin:0 auto;
        }
        .style2
        {
            height: 49px;
        }
        table
        {
            margin-top:30px;
        }
    </style>
</head>
<body style="height: 375px; width: 928px">
    <form id="form1" runat="server">
    <div style="height: 278px; width: 734px" id="div1">
    
        <table style="border: thin solid #00FFFF; width:61%; height: 201px; background-image: url('../pic/1.jpg'); border-collapse: collapse; border-spacing: 1px;" 
            align="center">
            <tr>
                <td colspan="2" 
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 24px;" 
                    align="center" class="style2">
                    2016-2017学年下半年ASP.NET期末考试</td>
            </tr>
            <tr>
                <td  class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    学号：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆;">
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td  class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    姓名：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆;">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td  class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    班级：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆;">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td  class="style1" align="center" 
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bolder;">
                     &nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" 
                         runat="server" Height="40px" Text="登录" Width="68px" 
                         onclick="Button1_Click" BackColor="#9999FF" BorderColor="#9999FF" />
                </td>
                <td align="center" 
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bolder;">
                   &nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="Button2" runat="server" 
                        Height="40px" Text="进入考试" 
                        Width="68px" onclick="Button2_Click" BackColor="#9999FF" 
                        BorderColor="#9999FF" Visible="False" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
