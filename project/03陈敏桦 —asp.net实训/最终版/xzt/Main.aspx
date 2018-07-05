<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="xzt_Main" %>

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
            margin:0 auto;
             border:1px solid blue;
        }
        p
        {
            text-align:center;
            font-family:@幼圆;
            font-size:20px;
        }
        </style>
</head>
<body style=" width: 944px">
    <form id="form1" runat="server">
    <div style="height: 3594px; width: 914px" id="div1">
    
        <p>2016——2017学年下半年ASP.NET期末考试试题</p>
       <p> 学号：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; 班级：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
       </p> 
        <p>试题类型：<asp:Button 
            ID="Button1" runat="server" Height="36px" Text="选择题" 
            Width="79px" onclick="Button1_Click" />
    
        &nbsp;&nbsp;&nbsp; 完成试题后提交：<asp:Button ID="Button2" runat="server" 
            Height="36px" Text="提交" Width="80px" onclick="Button2_Click" /></p>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" 
            onitemcommand="DataList1_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                &nbsp;<asp:Label ID="Label5" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                &nbsp;<asp:Label ID="Label4" runat="server" Text='<%# Eval("title") %>'></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Text="A、"></asp:Label>
                <asp:RadioButton ID="RadioButton1" runat="server" Text='<%# Eval("xuanA") %>' 
                    GroupName="xz" AutoPostBack="True" />
                <br />
                <asp:Label ID="Label7" runat="server" Text="B、"></asp:Label>
                <asp:RadioButton ID="RadioButton2" runat="server" Text='<%# Eval("xuanB") %>'  
                    GroupName="xz" AutoPostBack="True" />
                <br />
                <asp:Label ID="Label8" runat="server" Text="C、"></asp:Label>
                <asp:RadioButton ID="RadioButton3" runat="server" Text='<%# Eval("xuanC") %>'  
                    GroupName="xz" AutoPostBack="True" />
                &nbsp;
                <br />
                <asp:Label ID="Label9" runat="server" Text="D、"></asp:Label>
                <asp:RadioButton ID="RadioButton4" runat="server" Text='<%# Eval("xuanD") %>'  
                    GroupName="xz" AutoPostBack="True"/>
                &nbsp;&nbsp;&nbsp;
            </ItemTemplate>
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
