<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editFilling.aspx.cs" Inherits="fill_editFilling" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
          
            margin:0 auto;
        }
    </style>
</head>
<body style="height: 315px; width: 843px">
    <form id="form1" runat="server">
    <div style="height: 266px; width: 625px" id="div1">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Height="195px" Width="582px" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="题号" />
                <asp:BoundField DataField="title" HeaderText="题目" />
                <asp:BoundField DataField="answer" HeaderText="答案" />
                <asp:CommandField HeaderText="修改" ShowEditButton="True" />
                <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
