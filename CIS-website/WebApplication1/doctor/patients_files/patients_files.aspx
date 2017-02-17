<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patients_files.aspx.cs" Inherits="WebApplication1.doctor.patients_files.patients_files" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">

<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

        <!-- footer -->

    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"/>
    <link href="http://fonts.googleapis.com/css?family=Cookie" rel="stylesheet" type="text/css"/>

</head>


<body>
 <div id="wrapper">
     <div id="header">
        <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">WebSiteName</a>
            </div>

            <ul class="nav navbar-nav">
                <li><a href="../../index.aspx">Home</a></li>
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
                <li><a href="../book/book.aspx"><span class="glyphicon glyphicon-book"></span> Patients files </a></li>
                <li><a href="../patientHistory/patientHistory.aspx"><span class="glyphicon glyphicon-folder-close"></span> Reservations </a></li>
                <li><a href="../../account/signout.aspx""><span class="glyphicon glyphicon-log-out"></span> Sign Out</a></li>            
            </ul>
        </div>
    </nav>
         </div>

     <div id="container" style="margin-top:100px;">
         <form runat="server" class="form-horizontal">


         </form>
     </div>


     <div id="footer"></div>
     </div>
    
</body>
</html>
