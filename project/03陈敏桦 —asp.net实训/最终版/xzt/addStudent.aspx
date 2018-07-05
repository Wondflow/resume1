<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addStudent.aspx.cs" Inherits="xzt_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style1
        {
            width: 38%;
        }
        body
        {
            margin:0 auto;
        }
       #div1
        {
            margin:0 auto;
        }
        .style2
        {
            height: 54px;
        }
        table
        {
            margin-top:30px;
        }
        </style>
</head>
<body style="height: 298px; width: 754px">
    <form id="form1" runat="server">
    <div style="height: 290px; width: 707px" id="div1">
    
        <table style="border: thin solid #00FFFF; width:61%; height: 201px; border-collapse: collapse; border-spacing: 1px; background-image: url('../pic/6.jpg');" 
            align="center">
            <tr>
                <td colspan="2" 
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 20px; font-weight: bold;" 
                    align="center" class="style2">
                    添加ASP.NET期末考试考生信息</td>
            </tr>
            <tr>
                <td  class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    学号：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px;">
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    姓名：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px;">
                    <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td  class="style1" 
                    
                    
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px; font-family: 幼圆; font-size: 18px; font-weight: bold;">
                    班级：</td>
                <td style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px;">
                    <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="157px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td  class="style1" align="center" 
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px;">
                     &nbsp;&nbsp;&nbsp; 
                     <asp:Button ID="Button1" 
                         runat="server" Height="37px" Text="添加" Width="68px" 
                         onclick="Button1_Click" BackColor="#66FF99" BorderColor="#66FF99" />
                </td>
                <td align="center" 
                    style="border: thin solid #00FFFF; border-collapse: collapse; border-spacing: 1px;">
                   &nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="Button2" runat="server" Height="37px" Text="取消" 
                        Width="68px" onclick="Button2_Click" BackColor="#66FF99" 
                        BorderColor="#66FF99" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
