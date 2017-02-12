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
  
  <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css"/ media="screen">
  <script type="text/javascript" src="../javascript/JavaScript1.js"></script>

        <!-- footer -->

    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"/>
    <link href="http://fonts.googleapis.com/css?family=Cookie" rel="stylesheet" type="text/css"/>

</head>
<body>
 <div id="wrapper" class="container container-fluid">

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
     
     <div id="container">
        <form runat="server" class="form-horizontal">
            
            <div class="form-group">
                <label id="LabelLoginMobile" class="control-label col-sm-2" for="TextboxLoginMobile">Mobile:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxLoginMobile" type="tel" class="form-control" placeholder="Enter Your Mobile"/>
                </div>
            </div>
            <div class="form-group">
                <label id="LabelLoginPassword" class="control-label col-sm-2" for="TextboxLoginPassword">Password:</label>
                <div class="col-sm-10"> 
                    <asp:TextBox runat="server" id="TextboxLoginPassword" type="password" class="form-control" placeholder="Enter Your Password"/>
                </div>
            </div>
            <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <div class="checkbox">
                        <label><asp:TextBox runat="server" id="CheckboxLoginRememberme" type="checkbox"/> Remember me</label>
                    </div>
                </div>
            </div>

            <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button runat="server" id="ButtonLoginSubmit" type="submit" class="btn btn-default" Text="Submit" OnClick="ButtonLoginSubmit_Click"/>
                </div>
            </div>
       </form>
    </div>

     <div id="footer"></div>

 </div>
   
   
</body>
</html>
