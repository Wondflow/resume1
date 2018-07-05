<%@ Page Language="C#" AutoEventWireup="true" CodeFile="neiweb.aspx.cs" Inherits="text_neiweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>北京协和医院心内科</title>

    <style type="text/css">
        body
        {
            width:900px;
            margin:0 auto;
            }
        #header
        {
            width:900px;
            height:200px;
            
            }
         #header img
         {
             width:900px;
             height:200px;
             }
 /*-----------------------------------------------------------*/
          #nav
        {
            width:900px;
            height:40px;
            background-color:#800;
            margin-bottom:5px;
            
            }
            #nav ul
            {
                width:700px;
                height:30px;
                list-style-type:none;
                margin:5px auto;
                }
               #nav ul li
               {
                   width:100px;
                   height:30px;
                   line-height:30px;
                   float:left;
                  /*background:url(../images/nav.png) repeat-y right;*/
                   }
                 #nav ul li a
                 {
                     text-decoration:none;
                     color:white;
                     display:block;
                     text-align:center;
                     font-size:14px;
                     }
 /*-----------------------------------------------------------*/            
           #left
        {
            width:200px;
            height:600px;
            border:1px solid red;
            float:left;
            margin-right:5px;
            font-size:11px;
            
            
            }
            .left1 a
            {
                color:Black;
                text-decoration:none;
                margin-left:7px;
            }
            .left1 a:hover
            {
                color:Blue;
                text-decoration:underline;
            }
            #left .left1
            {
                width:200px;
                height:200px;
                }
               .left1 p
               {
                   width:200px;
                   height:30px;
                   }
                
 /*-----------------------------------------------------------*/           
          #middle
        {
            width:480px;
            height:600px;
            
            margin-right:5px;
            float:left;
            }
            #up
            {
                width:480px;
                height:300px;
                border:1px solid #fcc;
                font-size:14px;
                               
                }
                #DataList4
                {
                    text-indent:2em;
                    margin-top:20px;
                }
             #down
             {
                 width:480px;
                height:290px;
                margin-top:5px;
                border:1px solid #fcc;
                font-size:12px;
                 }
                 #down #Image3
                 {
                     float:left;
                     text-align:center;
                    
                 }
             #middle img
               {
                    width:480px;
                   height:50px;
        } 
 /*-----------------------------------------------------------*/            
          #right
        {
            width:200px;
            height:600px;
            
            float:left;
            }
            #right a
            {
                text-decoration:none;
                color:White;
            }
           #up1
            {
                width:200px;
                height:250px;
                 border:1px solid #ccc;
                
                }
             #down1
             {
                 width:200px;
                height:350px;
                border:1px solid #ccc;
                margin-top:-8px;
                 }
                 #DataList6
                 {
                     margin:3px auto;
                 }
                 
               #right img
               {
                   width:200px;
                   height:30px;
                   }
                 #up1 #DataList5
                   {
                       margin:10px auto;
                   }
                   #down1 a:hover
                   {
                      color:Red;
                   }
 /*-----------------------------------------------------------*/           
           #footer
        {
            width:900px;
            height:100px;
            padding-top:20px;
           margin-top:5px;
            background-color:#ccc;
            clear:left;
            
            }
            #footer p
            {
                width:700px;
                height:25px;
                margin:0px auto;
                font-size:14px;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
        <img src="../images/head.png" />
    </div>
    <div id="nav">
        <ul>
            <li><a href="#">科室首页</a></li>
            <li><a href="#">科室简介</a></li>
            <li><a href="#">科室动态</a></li>
            <li><a href="#">医师介绍</a></li>
            <li><a href="#">特殊检查项目</a></li>
            <li><a href="#">科研教学</a></li>
            <li><a href="#">健康教育</a></li>
        </ul>
    </div>
    <div id="left">
        <div class="left1">
            <p><img src="../images/keshi.PNG" /></p>
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <a href="#"><asp:Label ID="Label2" runat="server" Text='<%# Eval("title") %>'></asp:Label></a>
                    </ItemTemplate>
                </asp:DataList>
            
        </div>
        <div class="left1">
            <p><img src="../images/keyan.PNG" /></p>
            <asp:DataList ID="DataList2" runat="server">
                <ItemTemplate>
                   <a href="#"><asp:Label ID="Label5" runat="server" Text='<%# Eval("title") %>'></asp:Label></a>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div class="left1">
            <p><img src="../images/jiankang.PNG" />
            <asp:DataList ID="DataList3" runat="server" >
                <ItemTemplate>
                    <a href="#"><asp:Label ID="Label6" runat="server"  Text='<%# Eval("title") %>'></asp:Label></a>
                </ItemTemplate>
                </asp:DataList>
            </p>
        </div>
    </div>
    <div id="middle">
        <div id="up">
            <img src="../images/jianjie.PNG" />
            <asp:DataList ID="DataList4" runat="server">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" 
    Text='<%# Eval("content") %>'></asp:Label>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div id="down">
            <img src="../images/yishi.PNG" />
            <asp:DataList ID="DataList7" runat="server" RepeatColumns="4" 
                RepeatDirection="Horizontal" style="margin-bottom: 1142px">
                <ItemTemplate>
                    <asp:Image ID="Image3" runat="server" Height="100px" 
                        ImageUrl='<%# Eval("pname") %>' Width="80px" /><br />
                    &nbsp;
                    <asp:Label ID="Label8" runat="server" Text='<%# Eval("title") %>'></asp:Label><br />
                    <asp:Label ID="Label9" runat="server" Text='<%# Eval("content") %>'></asp:Label>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <div id="right">
        <div id="up1">
            <img src="../images/jiu.PNG" />
            <asp:DataList ID="DataList5" runat="server">
                <ItemTemplate>
                   <a href="#"><asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("pname") %>'
                        Height="60px" Width="180px" /></a>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div id="down1">
            <img src="../images/te.PNG" />
            <asp:DataList ID="DataList6" runat="server">
                <ItemTemplate>
                 <a href="#"><asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("pname") %>' /></a>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
    <div id="footer">
        <p>地址：（东院）北京市东城区帅府园一号，100730；（西院）北京市西城区大木仓胡同41号，100032ights Reserved © 北京协和医院<img src="../images/pic1.gif" /> </p>

    </div>
    </form>
</body>
</html>
