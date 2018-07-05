<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addaspx.aspx.cs" Inherits="picture_addaspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style type="text/css">
        
        body
        {
            width:500px;
            margin:20px auto;
        }
        #div1
        {
            width:500px;
            height:153px;
            margin:10px auto;
            text-align:center;
        }
        td,tr
        {
            border:1px solid blue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    <table width="100%" cellspacing="0">
   <tr> 
        <td colspan="2" style="font-size: 30px">添加图片</td>
   </tr>
    <tr>
        <td bgcolor="#00CCFF">图片文件名：</td>
        <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
    </tr>
   <tr> 
       <td bgcolor="#00CCFF">图片所在的类型：</td>
       <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
   </tr>
    <tr>
        <td bgcolor="#00CCFF">图片录入时间：</td>
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td><asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click1" /></td>   
        <td><asp:Button ID="Button2" runat="server" Text="取消" onclick="Button2_Click" /></td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
