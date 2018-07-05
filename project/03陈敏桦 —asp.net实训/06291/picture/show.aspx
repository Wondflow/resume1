<%@ Page Language="C#" AutoEventWireup="true" CodeFile="show.aspx.cs" Inherits="picture_show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 442px; width: 893px">
    <form id="form1" runat="server">
    <div style="height: 434px; width: 884px">
    
        <br />
        <br />
&nbsp; 浏览、修改与更新图片表<br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Height="212px" onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" Width="832px">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="pname" HeaderText="图片文件名" />
                <asp:BoundField DataField="stype" HeaderText="类型" />
                <asp:BoundField DataField="sdate" HeaderText="录入日期" />
                <asp:CommandField HeaderText="修改" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
