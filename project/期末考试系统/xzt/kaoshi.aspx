<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kaoshi.aspx.cs" Inherits="xzt_kaoshi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 47px;
        }
        p
        {
            text-align:center;
            font-family:@幼圆;
            font-size:20px;
        }
        </style>
</head>
<body style="height: 911px">
    <form id="form1" runat="server">
    <div style="height: 1168px">
    
        <p style="background-color: #00FF99; font-size: 26px">2016——2017学年下半年ASP.NET期末考试试题</p>
       <p style="font-size: 26px"> 你的学号：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 你的姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 你的班级：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p> 
    
      完成题目后请按提交按钮： 
        <asp:Button ID="Button1" runat="server" Height="30px" onclick="Button1_Click" 
            Text="提交" Width="79px" />
        &nbsp;
        <br />
        <br />
        <br />
      请选择题目类型：
        <asp:Button ID="Button2" runat="server" Height="26px" Text="选择题" Width="73px" 
                onclick="Button2_Click" />&nbsp;
        <asp:Button ID="Button3" runat="server" Height="26px" onclick="Button3_Click" 
            Text="判断题" Width="73px" />
        &nbsp; 
        <asp:Button ID="Button4" runat="server" Height="26px" onclick="Button4_Click" 
            Text="编程题" Width="73px" />
&nbsp;
        <asp:Button ID="Button5" runat="server" Height="26px" onclick="Button5_Click" 
            Text="简答题" Width="73px" />
&nbsp;
        <asp:Button ID="Button6" runat="server" Height="26px" onclick="Button6_Click" 
            Text="填空题" Width="73px" />
        &nbsp;<asp:Button ID="Button7" runat="server" Height="27px" 
            onclick="Button7_Click" Text="改卷" Width="65px" />
        <br />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server"  ForeColor="#333333" 
            Width="491px" Height="605px" >
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <table style="width: 98%;">
                    <tr>
                        <td class="style1" rowspan="4">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="47px">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>D</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("xuanA") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("xuanB") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("xuanC") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("xuanD") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
    
        <br />
    
    </div>
    </form>
</body>
</html>
