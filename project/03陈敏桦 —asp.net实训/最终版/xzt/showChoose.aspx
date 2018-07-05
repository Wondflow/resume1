<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showChoose.aspx.cs" Inherits="xzt_showChoose" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style type="text/css">

          body
        {
            margin:0 auto;
            width:959px;
            height:371px;
          }
       #div1
        {
            margin:0 auto;
              height: 367px;
              width: 971px;
          }
          #GridView1
          {
              background-image:no-repeat;
          }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" Height="216px" Width="923px" 
            onpageindexchanging="GridView1_PageIndexChanging" BorderColor="Black" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="题号" />
                <asp:BoundField DataField="title" HeaderText="题目" />
                <asp:BoundField DataField="xuanA" HeaderText="A" />
                <asp:BoundField DataField="xuanB" HeaderText="B" />
                <asp:BoundField DataField="xuanC" HeaderText="C" />
                <asp:BoundField DataField="xuanD" HeaderText="D" />
                <asp:BoundField DataField="answer" HeaderText="答案" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle HorizontalAlign="Center" BackColor="#FFCC66" ForeColor="#333333" />
            <RowStyle HorizontalAlign="Center" BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
