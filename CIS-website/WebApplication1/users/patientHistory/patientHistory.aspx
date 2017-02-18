<%@ Page Language="C#" MaintainScrollPositionOnPostBack="true" AutoEventWireup="true" CodeBehind="patientHistory.aspx.cs" Inherits="WebApplication1.users.patientHistory" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

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

    <div id="wrapper" class="container container-fluid">
        <div id="header">
    <nav class="navbar navbar-inverse navbar-fixed-top">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand active" href="#">WebSiteName</a>
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
                <li><a href="../bill/bill.aspx"><span class="glyphicon glyphicon-euro"></span> Bill</a></li>
                <li><a href="../book/book.aspx"><span class="glyphicon glyphicon-book"></span> Book</a></li>
                <li><a href="../../account/signout.aspx"><span class="glyphicon glyphicon-log-out"></span> Sign Out</a></li>
            </ul>
        </div>
    </nav> 
            </div>

        <div id="container" style="margin-top:100px;">
             <form runat="server" class="form-horizontal">

           <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button runat="server" id="ButtonRestore" type="submit" class="btn btn-default" Text="Restore Date" OnClick="ButtonRestore_Click"/>
                </div>
            </div>

        <!-- General Information-->
		<h1 style= "color:#858585") >1- General Information</h1>

            <div class="form-group">
                <label id="LabelPatientHistoryFirstname" class="control-label col-sm-2" for="TextboxPatientHistoryFirstname">First Name:</label>
                <div class="col-sm-10">
                    <input type="text" runat="server" id="TextboxPatientHistoryFirstname" class="form-control" required="required"/>
                   <!--
                    <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                        ControlToValidate="TextboxPatientHistoryFirstname"
                        ErrorMessage="First Name is a Required Field."
                        ForeColor="Red">
                    </asp:RequiredFieldValidator> -->
               
                </div>
            </div>

            <div class="form-group">
                <label id="LabelPatientHistoryLastname" class="control-label col-sm-2" for="TextboxPatientHistoryLastname">Last Name:</label>
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
                            <asp:ListItem ID="RadioButtonListPatientHistoryGenderMale" Text="Male" Value="Male" />
                            <asp:ListItem ID="RadioButtonListPatientHistoryGenderFemale" Text="Female" Value="Female" />
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
             </div><br/>
                              

             <div class="form-group">
                <label id="LabelPatientHistoryWeight" class="control-label col-sm-2" for="TextboxPatientHistoryWeight">Weight:</label>
                <div class="col-sm-9">
                <asp:TextBox runat="server" id="TextboxPatientHistoryWeight" type="number" class="form-control"/>
                </div>
                <div class="col-sm-1">
                    <p> Kg</p>
                 </div>  
                </div>

                 <br/><br/>
        <!-- Disease-->
		<h1 style= "color:#858585") >2- Disease</h1>

            <div class="form-group">
                <div class="col-sm-12">

                <label id="LabelPatientHistoryDisease" class="control-label col-sm-2" for="CheckBoxListDisease">Disease:</label>

                    <asp:CheckBoxList ID="CheckBoxListDisease" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                        <asp:ListItem runat="server" class="col-sm-12" Text="Anemia	" Value="Anemia	"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Asthma" Value="Asthma"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Epilepsy" Value="Epilepsy"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Depression" Value="Depression"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Diabetes" Value="Diabetes"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Diarrhea" Value="Diarrhea"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Heart Attack" Value="Heart Attack"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Hepatitis" Value="Hepatitis"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Rheumatism" Value="Rheumatism"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="Scarlet Fever" Value="Scarlet Fever"></asp:ListItem>
                        <asp:ListItem runat="server" class="col-sm-12" Text="STD" Value="STD"></asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
                 
                  <asp:ScriptManager runat="server" ID="sm"></asp:ScriptManager>
                    <asp:updatepanel runat="server">
                    <ContentTemplate>
                <label id="LabelPatientHistoryDiseaseOther" class="control-label col-sm-2" for="TextboxAddDiseaseOther">Other:</label>
                <div class="col-sm-7">
                    <asp:TextBox runat="server" id="TextboxDiseaseOther" class="form-control"/>
                 </div>  

                    <div class="col-sm-3">
                    <button runat="server" id="ButtonDiseaseOther" class="btn btn-default" onserverclick="ButtonDiseaseOther_Click"> Add </button>                    
                    </div>

            

                <div class="col-sm-12 col-sm-offset-2">    
                    <asp:BulletedList ID="BulletedListDisease" runat="server">
                    </asp:BulletedList>
                </div>

                <br/>
        <!-- Drugs-->
		<h1 style= "color:#858585") >3- Drugs</h1>            
            <div class="form-group">

                                                    
                <label id="LabelPatientHistoryDrugs" class="control-label col-sm-2" for="TextboxAddDrug">Write Your Drugs One By One:</label>
                <div class="col-sm-7">
                    <asp:TextBox runat="server" id="TextboxAddDrug" class="form-control"/>
                    </div>
                    <div class="col-sm-3">
                    <button runat="server" id="ButtonAddDrug" class="btn btn-default" onserverclick="ButtonAddDrug_Click"> Add </button>
                    </div>
                <div class="col-sm-12 col-sm-offset-2">    
                    <asp:BulletedList ID="BulletedListDrug" runat="server">
                    </asp:BulletedList>
                </div>

            </div><br/>
        <!-- Surgery-->
		<h1 style= "color:#858585") >4- Surgery</h1>
            <div class="form-group">  
  
                                                  
                <label id="LabelPatientHistorySurgery" class="control-label col-sm-2" for="TextboxAddSurgery">Write Your Surgery One By One:</label>
                <div class="col-sm-7">
                    <asp:TextBox runat="server" id="TextboxAddSurgery" class="form-control"/>
                    </div>
                    <div class="col-sm-3">
                    <button runat="server" id="ButtonAddSurgery" class="btn btn-default" onserverclick="ButtonAddSurgery_Click"> Add </button>
                    </div>
                <div class="col-sm-12 col-sm-offset-2">    
                    <asp:BulletedList ID="BulletedListSurgery" runat="server">
                    </asp:BulletedList>
                </div>

            </div><br/>
            <!-- Family History-->
		<h1 style= "color:#858585") >5- Family History</h1>
            <div class="form-group">   

                                                 
                <label id="LabelPatientHistoryFamilyHistoryRelative" class="control-label col-sm-2" for="TextboxAddRelative">Write Your Relative:</label>
                <div class="col-sm-3">
                    <asp:TextBox runat="server" id="TextboxFamilyHistoryRelative" class="form-control"/>
                    </div>
                <label id="LabelPatientHistoryFamilyHistoryDisease" class="control-label col-sm-2" for="TextboxAddFamilyHistoryDisease">Write His Disease:</label>
                <div class="col-sm-3">
                    <asp:TextBox runat="server" id="TextboxFamilyHistoryDisease" class="form-control"/>
                    </div>
                    <div class="col-sm-2">
                    <button runat="server" id="ButtonFamilyHistoryAdd" class="btn btn-default" onserverclick="ButtonFamilyHistoryAdd_Click"> Add </button>
                    </div>
                <div class="col-sm-12" style="display:inline">

         <div class="col-sm-12">
             <asp:Table ID="tableFamilyHistory" runat="server" class="col-sm-offset-2" Width="750" Font-Names="Palatino" BackColor="#ffffff" BorderColor="#000000" BorderWidth="2" ForeColor="#000000" CellPadding="7" CellSpacing="7">
            <asp:TableHeaderRow runat="server" ForeColor="Snow" BackColor="#858585" Font-Bold="true">
                <asp:TableHeaderCell>Relative</asp:TableHeaderCell>
                <asp:TableHeaderCell>Disease</asp:TableHeaderCell>
            </asp:TableHeaderRow>


           

         </asp:Table>
                </div>
                </div>

            </div>

            <br/><br/><br/>
           <div class="form-group">
               <div class="col-sm-offset-2 col-sm-10">
	      			<p> To the best of my knowledge, the questions on this form have been accurately answered. I understand that providing incorrect information can be dangerous to my patient's health. It is my responsibility to inform the office of any changes in medical status.</p><br>
                   <asp:CheckBox ID="CheckboxPatientHistoryAgree" runat="server" Text="I Agree" Value="Agree" /> 
               </div>
      	    </div>

           <div class="form-group"> 
                <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button runat="server" id="ButtonPatientHistorySubmit" type="submit" class="btn btn-default" Text="Submit" OnClick="ButtonPatientHistorySubmit_Click" />
                </div>
            </div>
                       
                        </ContentTemplate>
                        </asp:updatepanel>

       </form>


        </div>
        
        <div id="footer"></div>
        
    
    </div>



</body>
</html>
