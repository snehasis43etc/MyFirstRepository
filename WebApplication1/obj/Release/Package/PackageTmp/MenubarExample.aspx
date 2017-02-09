﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenubarExample.aspx.cs" Inherits="Menubar.MenubarExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }

        .main_menu
        {
            width: 100px;
            background-color: #8AE0F2;
            color: #000;
            text-align: center;
            height: 30px;
            line-height: 30px;
            margin-right: 5px;
        }

        .level_menu
        {
            width: 110px;
            background-color: #000;
            color: #fff;
            text-align: center;
            height: 30px;
            line-height: 30px;
            margin-top: 5px;
        }

        .selected
        {
            background-color: #852B91;
            color: #fff;
        }
    </style>

        <%-- <script type="text/javascript">
             window.onload = function()
             { var e = document.getElementById("Menu1");
                 
                 alert("Hi there");}
</script>--%>
<script src="https://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script type="text/javascript"  >
        function validateForm() {
            //var e = document.getElementById("Menu1")
            //var x = document.forms["form1"]["Button1"].value;

            alert("Name must be filled out");
                
            }
        
        $(function () {
            $(".main_menu a").each(function (index) {
                $(this).click(function () {
                    alert($(this).attr("href"));
                   
                });
            });
        });
   
        //$(document).ready( function() {
        //    var e = document.getElementById("Menu1");

        //    $("#Menu1").on("click", function() {

        //        var what = $(e.target).html();
        //        alert("You have selected: " + what);

        //    });

      
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">

            <%-- <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false"/>
            --%>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
                DataFile="~/Data.xml" />
            <br />
            <asp:Menu ID="Menu1"  StaticDisplayLevels="2"
                DataSourceID="XmlDataSource1"
                Orientation="Horizontal"
                 runat="server"  >
             
               
                <LevelSubMenuStyles>

                    <asp:SubMenuStyle CssClass="main_menu" />
                </LevelSubMenuStyles>

                <LevelMenuItemStyles>
                    <asp:MenuItemStyle CssClass="main_menu" />
                </LevelMenuItemStyles>

                <DataBindings>
                    <asp:MenuItemBinding DataMember="Menu" TextField="text" ValueField="text"
                        NavigateUrlField="url" />
                    <asp:MenuItemBinding DataMember="SubMenu" NavigateUrlField="url" TextField="text"
                        ValueField="text" />
                </DataBindings>
                <%-- <Items>
        <asp:MenuItem Text="HOME"></asp:MenuItem>
        <asp:MenuItem Text="SERVICES">
            <asp:MenuItem Text="Consulting"></asp:MenuItem>
            <asp:MenuItem Text="Outsourcing"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="ABOUT"></asp:MenuItem>
        <asp:MenuItem Text="CONTACT"></asp:MenuItem>
    </Items>--%>
            </asp:Menu>


            <asp:Label ID="lblmessage" runat="server" Text="lblmessage" Visible="false"></asp:Label>


        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" OnClientClick="return validateForm();" />
    </form>
</body>
</html>
