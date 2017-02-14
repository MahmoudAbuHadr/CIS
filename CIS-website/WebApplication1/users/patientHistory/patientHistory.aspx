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
                <li><a href="../../home.aspx">Home</a></li>
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
                <li><a href="../bill/bill.aspx"><span class="glyphicon glyphicon-euro"></span> Bill</a></li>
                <li><a href="../book/book.aspx"><span class="glyphicon glyphicon-book"></span> Book</a></li>
                <li><a href="#"><span class="glyphicon glyphicon-log-out"></span> Sign Out</a></li>
            </ul>
        </div>
    </nav>
            </div>

        <div id="container" style="margin-top:100px;">
             <form runat="server" class="form-horizontal">

        <!-- General Information-->
		<h1 style= "color:#858585") >1- General Information</h1>

            <div class="form-group">
                <label id="LabelPatientHistoryFirstname" class="control-label col-sm-2" for="TextboxPatientHistoryFirstname">First Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxPatientHistoryFirstname" type="text" class="form-control"/>
                   
                    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                        ControlToValidate="TextboxPatientHistoryFirstname"
                        ErrorMessage="First Name is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
               
                </div>
            </div>

            <div class="form-group">
                <label id="LabelPatientHistoryLastname" class="control-label col-sm-2" for="TextboxPatientHistoryLastname">First Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="TextboxPatientHistoryLastname" type="text" class="form-control"/>
                   
                    <asp:RequiredFieldValidator id="RequiredFieldValidatorPatientHistoryLastname" runat="server"
                        ControlToValidate="TextboxPatientHistoryLastname"
                        ErrorMessage="Last Name is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
               
                </div>
            </div>
                               
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

            <div class="form-group">
                <label id="LabelPatientHistoryGender" class="control-label col-sm-2" for="TextboxPatientHistoryMobile">Gender:</label>
                <div class="col-sm-10">
                    <asp:RadioButtonList ID="RadioButtonListPatientHistoryGender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table">
                            <asp:ListItem Text="Male" Value="Male" />
                            <asp:ListItem Text="Female" Value="Female" />
                    </asp:RadioButtonList>
                

                    <asp:RequiredFieldValidator id="RequiredFieldValidatorRadioButtonListGender" runat="server"
                        ControlToValidate="RadioButtonListPatientHistoryGender"
                        ErrorMessage="Gender is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-group">
                <label id="LabelPatientHistoryBirthday" class="control-label col-sm-2" for="TextboxPatientHistoryBirthday">Birthday:</label>
                <div class="col-sm-10">
                <asp:TextBox runat="server" id="TextboxPatientHistoryBirthday" type="date" class="form-control"/>

                    <asp:RequiredFieldValidator id="RequiredFieldTextboxPatientHistoryBirthday" runat="server"
                        ControlToValidate="TextboxPatientHistoryBirthday"
                        ErrorMessage="Birthday is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </div>
            </div>
                  
             <div class="form-group">
                <label id="LabelPatientHistoryHeight" class="control-label col-sm-2" for="TextboxPatientHistoryBirthday">Height:</label>
                <div class="col-sm-9">
                <asp:TextBox runat="server" id="TextboxPatientHistoryHeight" type="number" class="form-control"/>
                </div>

                <div class="col-sm-1">
                    <p> Cm</p>                           
                </div>              
             </div>
                              
             <div class="form-group">
                <label id="LabelPatientHistoryWeight" class="control-label col-sm-2" for="TextboxPatientHistoryWeight">Weight:</label>
                <div class="col-sm-9">
                <asp:TextBox runat="server" id="TextboxPatientHistoryWeight" type="number" class="form-control"/>
                </div>
                <div class="col-sm-1">
                    <p> Kg</p>
                 </div>  
                </div>


<!-- General Information-->
		<h1 style= "color:#858585") >1- Patient History</h1>

            <div class="form-group">
                <label id="" class="control-label col-sm-2" for="TextboxPatientHistoryFirstname">First Name:</label>
                <div class="col-sm-10">
                    <asp:TextBox runat="server" id="Textbox1" type="text" class="form-control"/>
                   
               
                </div>
            </div>

       </form>


        </div>
        
        <div id="footer"></div>
        
    
    </div>



</body>
</html>
