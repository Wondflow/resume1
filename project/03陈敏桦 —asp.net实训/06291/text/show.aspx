<%@ Page Language="C#" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="text_show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 383px; width: 1249px">
    
        &nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp; 浏览、修改与删除<br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Height="295px" onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" Width="752px">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="type" HeaderText="类型" />
                <asp:BoundField DataField="title" HeaderText="标题" />
                <asp:BoundField DataField="content" HeaderText="内容" />
                <asp:BoundField DataField="sdate" HeaderText="录入日期" />
                <asp:CommandField HeaderText="修改" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
