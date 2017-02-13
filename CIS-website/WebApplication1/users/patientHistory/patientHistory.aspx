<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="patientHistory.aspx.cs" Inherits="WebApplication1.users.patientHistory" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  
  <script type="text/javascript" src="patientHistory.js"></script>


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

                       <!-- General Information-->
					<h1 style= "color:#858585") >1- General Information</h1>
					<br>
                <div class="target">

            <div class="form-group">
                <label id="LabelPatientHistoryFirstname" class="control-label col-sm-2" for="TextboxPatientHistoryFirstname">Fitst Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxPatientHistoryFirstname" type="text" class="form-control"/>
                 <!--   
                    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                        ControlToValidate="TextboxPatientHistoryFirstname"
                        ErrorMessage="First Name is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
               --> 
                </div>
            </div>
                    <!--
            <div class="form-group">
                <label id="LabelPatientHistoryMobile" class="control-label col-sm-2" for="TextboxPatientHistoryMobile">Mobile:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxPatientHistoryMobile" type="tel" class="form-control"/>
                    
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorTextboxPatientHistoryMobile" runat="server"
                        ControlToValidate="TextboxPatientHistoryMobile"
                        ErrorMessage="Mobile is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                
                </div>
            </div>
                    -->
					<!-- Gender -->
                    <label for="gender" class="grid_3 omega">*Gender:</label>
					<input type="radio" value="Male" name="Gender" id="gender" width: 400px; margin-left: 0px; style="height:30px" required>Male
                    <input type="radio" value="Female" name="Gender" id="gender" width: 400px; margin-left: 0px; style="height:30px">Female<br><br>
                    <!-- Birthday -->
                    <label for="birthday" class="grid_3 omega">*Birthday:</label>
					<input type="date" name="Birthday" id="birthday" width: 200px; margin-left: 0px; style="height:30px" required><br><br>
                    <!-- Height -->
                    <label for="height" class="grid_3 omega">Height:</label>
					<input type="number" name="Height" id="height" width: 200px; margin-left: 0px; style="height:30px">  cm<br><br>
					<!-- Weight -->
                    <label for="weight" class="grid_3 omega">Weight:</label>
					<input type="number" name="Weight" id="weight" width: 200px; margin-left: 0px; style="height:30px">  kgm<br><br>
                    <!-- <input type="radio" name="gender" value="Male" id="male"><label for="male">Male</label><br>
					<input type="radio" name="gender" value="Female" id="female"><label for="female">Female</label><br> -->
                </div>
                    <span id="healthRiskAssessment"></span>
				</fieldset>
				<br>
              
          <!--  
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
                    <asp:Button runat="server" id="ButtonBookSubmit" type="submit" class="btn btn-default" Text="Submit"/>
                </div>
            </div>
            -->     
       </form>


        </div>
        
        <div id="footer"></div>
        
    
    </div>



</body>
</html>
