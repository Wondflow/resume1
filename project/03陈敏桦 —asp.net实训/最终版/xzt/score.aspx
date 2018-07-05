<%@ Page Language="C#" AutoEventWireup="true" CodeFile="score.aspx.cs" Inherits="xzt_score" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            height: 258px;
        }
        body
        {
            margin:20px auto;
        }
    </style>
</head>
<body style="height: 273px; width: 1338px">
    <form id="form1" runat="server">
    <div style="height: 257px" align="center">
    
       <p align="center" style="background-color: #66CCFF; font-size: 28px;"> 2016——2017学年下半年ASP.NET期末考试</p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="47px" onclick="Button1_Click" 
            Text="改卷" Width="92px" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="47px" onclick="Button3_Click" 
            Text="返回" Width="97px" />
    
        <br />
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="692px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="xh" HeaderText="学号" />
                <asp:BoundField DataField="sname" HeaderText="姓名" />
                <asp:BoundField DataField="xzt" HeaderText="选择题" />
                <asp:BoundField DataField="pdt" HeaderText="判断题" />
                <asp:BoundField DataField="tkt" HeaderText="填空题" />
                <asp:BoundField DataField="jdt" HeaderText="简答题" />
                <asp:BoundField DataField="bct" HeaderText="编程题" />
                <asp:BoundField DataField="result" HeaderText="总分" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
