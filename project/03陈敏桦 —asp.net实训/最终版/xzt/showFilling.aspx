<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showFilling.aspx.cs" Inherits="fill_showFilling" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            height: 363px; 
            width: 761px;
            margin:0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Height="215px" Width="649px">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="题号" />
                <asp:BoundField DataField="title" HeaderText="题目" />
                <asp:BoundField DataField="answer" HeaderText="答案" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
