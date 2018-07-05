<%@ Page Language="C#" AutoEventWireup="true" CodeFile="choose.aspx.cs" Inherits="xzt_choose" %>

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
           
        }
        </style>
</head>
<body style="height: 358px; width: 1110px">
    <form id="form1" runat="server">
    <div style="height: 367px; width: 1049px" id="div1">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" Height="296px" Width="929px" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="题号" />
                <asp:BoundField DataField="title" HeaderText="题目" />
                <asp:BoundField DataField="xuanA" HeaderText="A" />
                <asp:BoundField DataField="xuanB" HeaderText="B" />
                <asp:BoundField DataField="xuanC" HeaderText="C" />
                <asp:BoundField DataField="xuanD" HeaderText="D" />
                <asp:BoundField DataField="answer" HeaderText="答案" />
                <asp:CommandField HeaderText="修改" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White" />
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
