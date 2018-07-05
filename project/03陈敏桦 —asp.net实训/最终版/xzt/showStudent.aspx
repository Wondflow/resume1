<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showStudent.aspx.cs" Inherits="xzt_showStudent" %>

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
<body style="height: 296px; width: 928px">
    <form id="form1" runat="server">
    <div style="height: 274px; width: 887px" id="div1">
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" Height="200px" 
            onpageindexchanging="GridView1_PageIndexChanging" Width="650px" 
            BackImageUrl="~/pic/7.jpg">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="题号" />
                <asp:BoundField DataField="xh" HeaderText="学号" />
                <asp:BoundField DataField="sname" HeaderText="姓名" />
                <asp:BoundField DataField="banji" HeaderText="班级" />
            </Columns>
            <RowStyle HorizontalAlign="Center" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
