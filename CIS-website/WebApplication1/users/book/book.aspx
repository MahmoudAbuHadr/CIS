<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="WebApplication1.users.book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  
  <script type="text/javascript" src="book.js"></script>


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
                <a class="navbar-brand active" href="#">WebSiteName</a>
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
                <li><a href="../../account/signup.aspx"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
                <li><a href="../../account/login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-log-out"></span> Sign Out</a></li>
            </ul>
        </div>
    </nav>
            </div>

        <div id="container" style="margin-top:100px;">
             <form runat="server" class="form-horizontal">
            
            <div class="form-group">
                <label id="LabelBookDate" class="control-label col-sm-2" for="TextboxBookDate">Date:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxBookDate" type="date" class="form-control"/>
                </div>
            </div>

                 
            <div class="form-group">
                <label id="LabelBookTime" class="control-label col-sm-2" for="TextboxBookTime">Time:</label>
                <div class="col-sm-10"> 
                    <asp:TextBox runat="server" id="TextboxBookTime" type="time" class="form-control"/>
                </div>
            </div>
                     
            <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <div class="p">
                        <p>Available Times Are:</p>
                    </div>
                </div>
            </div>
          
           <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button runat="server" id="ButtonBookSubmit" type="submit" class="btn btn-default" Text="Submit" OnClick="ButtonBookSubmit_Click"/>
                </div>
            </div>
                 
       </form>


        </div>
        
        <div id="footer"></div>
        
    
    </div>


</body>
</html>

