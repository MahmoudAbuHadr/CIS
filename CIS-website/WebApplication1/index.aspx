<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="en">

<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

  <link rel="stylesheet" type="text/css" href="css/StyleSheet1.css"/>
  <script type="text/javascript" src="javascript/JavaScript1.js"></script>

        <!-- slider -->
    <link href='http://fonts.googleapis.com/css?family=Oswald:400,300' rel='stylesheet'>
    <link href="http://s3.amazonaws.com/codecademy-content/courses/ltp2/css/bootstrap.min.css" rel="stylesheet">
    <link href="StyleSheet1.css" rel="stylesheet">
    <script src="JavaScript1.js"></script>


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
                <li class="active"><a href="#">Home</a></li>
                <li><a href="/doctor/doctorHome.aspx">for doctors</a></li>
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
                <li><a href="./account/signup.aspx"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li>
                <li><a href="./account/login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
            </ul>
        </div>
    </nav>
         </div>

    <div id="container" style="margin-top:100px;">
    
    <div class="slider">

      <div class="slide active-slide">
        <div class="container">
          <div class="row">
            <div class="slide-copy col-xs-5">
              <h1>You woke up sick</h1>
              <p>It's a single place to discover, collect and share the news you care about.  Add your favorite social networks, publications and blogs to stay connected to the topics and people closest to you.</p>
              
              <ul class="get-app">
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/ios.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/android.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/windows.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/blackberry.png"></a></li>
              </ul>
            </div>
            <div class="slide-img col-xs-7">
                <!--first pic-->
              <img src="https://img.clipartfest.com/56a25e68391900e0cbdb3cbb0a127376_sick-sick_670-503.jpeg" width="540px">
            </div>
          </div>
        </div>      
      </div>
        <!-- second pic in slide feature-->
      <div class="slide slide-feature">
        <div class="container">
          <div class="row">
            <div class="col-xs-12">
                <!---->
              <a href="#"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Internet_Explorer_10_logo.svg/2000px-Internet_Explorer_10_logo.svg.png" width="250px"></a>
              <a href="#">Join Now</a>
            </div>
            
          </div>
        </div>      
      </div> 

      <div class="slide">
        <div class="container">
          <div class="row">
            <div class="slide-copy col-xs-5">
              <h1>See your doctor</h1>
              <h2>on the Web</h2>
              <p>Millions of people use Flipboard to read and collect the news they care about, curating their favorite stories into their own magazines on any topic imaginable. Now magazines created by our readers, from Dali to End Trafficking, can be shared and enjoyed on the Web by anyone, anywhere.</p>
              
            </div>
            <div class="slide-img col-xs-7">
                <!--third pic-->
              <img src="https://thumbs.dreamstime.com/x/medical-examination-4160655.jpg">
            </div>
          </div>
        </div>      
      </div> 


      <div class="slide">
        <div class="container">
          <div class="row">
            <div class="slide-copy col-xs-5">
              <h1>You are well again</h1>
              <p>Millions of people use Flipboard to read and collect the news they care about, curating their favorite stories into their own magazines. Now you can promote the ones you create or think are awesome.</p>
              
              <ul class="get-app">
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/ios.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/android.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/windows.png"></a></li>
                <li><a href="#"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/blackberry.png"></a></li>
              </ul>
            </div>
            <div class="slide-img col-xs-7">
                <!--fourth pic-->
              <img src="http://clipartix.com/wp-content/uploads/2016/04/Thumbs-up-clipart-3.png" width="450px">
            </div>
          </div>
        </div>      
      </div> 

    </div>
    
    <div class="slider-nav">
      <a href="#" class="arrow-prev"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/arrow-prev.png"></a>
      <ul class="slider-dots">
        <li class="dot active-dot">&bull;</li>
        <li class="dot">&bull;</li>
        <li class="dot">&bull;</li>
        <li class="dot">&bull;</li>
      </ul>
      <a href="#" class="arrow-next"><img src="http://s3.amazonaws.com/codecademy-content/courses/ltp2/img/flipboard/arrow-next.png"></a>
    </div>
    </div>

     <div id="footer"></div>
     
 </div>
    
</body>
</html>
