<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebApplication1.signup" %>

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


        <!-- footer -->

    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"/>
    <link href="http://fonts.googleapis.com/css?family=Cookie" rel="stylesheet" type="text/css"/>

</head>
<body class="container container-fluid">
<div id ="wrapper">    

    <div id="header">    
    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">WebSiteName</a>
            </div>

            <ul class="nav navbar-nav">
                <li><a href="../home.aspx">Home</a></li>
                <li><a href="#">Page 1</a></li>
                <li><a href="#">Page 2</a></li>
            </ul>

            <form class="navbar-form navbar-left">
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search"/>
                        <div class="input-group-btn">
                            <button class="btn btn-default" type="submit">
                                <i class="glyphicon glyphicon-search"></i>
                            </button>
                        </div>
                </div>
            </form>

            <ul class="nav navbar-nav navbar-right">
                <li><a href="signup.aspx"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
                <li><a href="login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
            </ul>
        </div>
    </nav>
    </div>
    <div id="contnent">
        <form runat="server">
            <asp:Label ID="LabelSignupName" runat="server" Text="Name"  style="top: 260px; left: 420px; position: absolute; height: 16px; width: 35px; right: 766px;" Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            <asp:TextBox ID="TextBoxSignupName" runat="server"   style="position: absolute; top: 260px; left: 640px;"></asp:TextBox>

            <asp:Label ID="LabelSignupMobile" runat="server" Text="Mobile" style="top: 360px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            <asp:TextBox ID="TextBoxSignupMobile" runat="server" style="position: absolute; top: 360px; left: 640px;"></asp:TextBox>

            <asp:Label ID="LabelSignupEmail" runat="server" Text="Email" style="top: 460px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            <asp:TextBox ID="TextBoxSignupEmail" runat="server" style="position: absolute; top: 460px; left: 640px;"></asp:TextBox>

            <asp:Label ID="LabelSignupPassword" runat="server" Text="Password" style="top: 560px; left: 420px; position: absolute; height: 15px; width: 35px"  Font-Bold="True" Font-Size="Large" Font-Underline="True"></asp:Label>
            <asp:TextBox ID="TextBoxSignupPassword" runat="server" style="position: absolute; top: 560px; left: 640px;"></asp:TextBox>
 
            <asp:Button ID="ButtonSignupSubmit" runat="server" style="position: absolute; top: 660px; left: 740px;" Text="Submit" Font-Size="Large" />   
          
        </form>
    </div>
    <div id="footer"></div>

</div>
</body>
</html>
