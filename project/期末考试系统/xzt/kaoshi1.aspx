<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kaoshi1.aspx.cs" Inherits="xzt_kaoshi" %>

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
<body style="height: 2412px">
    <form id="form1" runat="server">
    <div style="height: 2605px">
    
        <p>2016——2017学年下半年ASP.NET期末考试试题</p>
       <p> 学号：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 班级：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p> 
    
      完成题目后请按提交按钮： 
        <asp:Button ID="Button1" runat="server" Height="30px" onclick="Button1_Click" 
            Text="提交" Width="79px" />
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
        <br />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server"  ForeColor="#333333" 
            Width="573px">
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
    
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label6" runat="server" 
    Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>对</asp:ListItem>
                    <asp:ListItem>错</asp:ListItem>
                </asp:RadioButtonList>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:DataList ID="DataList3" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label7" runat="server" 
    Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="70px" TextMode="MultiLine" 
                    Width="213px"></asp:TextBox>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:DataList ID="DataList4" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label8" runat="server" 
    Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Height="80px" TextMode="MultiLine" 
                    Width="182px"></asp:TextBox>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <br />
        <asp:DataList ID="DataList5" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label9" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
            </ItemTemplate>
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
