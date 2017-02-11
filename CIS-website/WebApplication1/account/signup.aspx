<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  
  <link rel="stylesheet" type="text/css" href="../css/StyleSheet1.css"/>
  <script type="text/javascript" src="../javascript/JavaScript1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <nav class="navbar navbar-default">
        <div class="row">
            <div class="col-xs-3 navlinks" style="font-size: large; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: normal; color: #000000"><a href="../home.aspx">Home</a></div>
            <div class="col-xs-6 navlinks"></div>
            <div class="col-xs-1 navlinks" style="font-size: large; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: normal; color: #000000"><a href="#about">About</a></div>
            <div class="col-xs-1 navlinks" style="font-size: large; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: normal; color: #000000"><a href="signup.aspx">Sign Up</a></div>
            <div class="col-xs-1 navlinks" style="font-size: large; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: normal; color: #000000"><a href="login.aspx">Login</a></div>
        </div>
        </nav>
    </div>
   
        <asp:Label ID="LabelName" runat="server" Text="Name"  style="top: 260px; left: 420px; position: absolute; height: 16px; width: 35px; right: 766px;" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"   style="position: absolute; top: 260px; left: 640px;"></asp:TextBox>

        <asp:Label ID="LabelMobile" runat="server" Text="Mobile" style="top: 360px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:TextBox ID="TextBoxMobile" runat="server" style="position: absolute; top: 360px; left: 640px;"></asp:TextBox>

        <asp:Label ID="LabelEmail" runat="server" Text="Email" style="top: 460px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server" style="position: absolute; top: 460px; left: 640px;"></asp:TextBox>

        <asp:Label ID="LabelPassword" runat="server" Text="Password" style="top: 560px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="position: absolute; top: 560px; left: 640px;"></asp:TextBox>

        
        
        <asp:Button ID="Button1" runat="server" style="position: absolute; top: 660px; left: 740px;" Text="Submit" Font-Size="Large" />

        
        
    </form>
</body>
</html>
