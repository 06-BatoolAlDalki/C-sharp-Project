<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question-page.aspx.cs" Inherits="C_sharp_project.question_page" %>

<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="question-page.css">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <nav class="navbar bg-light">
  <div class="container-fluid">
      <img src="home-images\logo1.PNG"  width="70px" height="" style=" position:absolute; left :10px ; top:5px" alt="no image" />
    <a class="navbar-brand " style="margin-left:7% ; color:#126266 ;"  >PEGASUS</a>
    <form class="d-flex" role="search" >
      <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx"style="text-decoration:none;color: #126266;"  >Home</a></button>
        <button class="btn btn-outline-success nav-bar" type="submit"><a href ="home-page.aspx" style="text-decoration:none;color: #126266;" >Logout</a></button>
       <%-- <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>

    <br />
      <div  style=" background-color: #F4F4F4; height:2700px ; margin-top:0px;">
      <form id="form1" runat="server">
            
    <div class="employee-id-date" >
      
        <div class="id"><span>-Employee ID:</span></div>
            <asp:Label ID="Label1" runat="server" Text="ID-employee"></asp:Label>
            <br />
             <div class="date"><span>-Date:</span></div>
            <asp:Label ID="Label2" runat="server" Text="Date of Survey"></asp:Label>
           </div>
 


          
            <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label3" runat="server" Text="Label">Question1</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label4" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button1" runat="server" Text="Poor" OnClick="Button1_Click" />
                      <asp:Button ID="Button2" runat="server" Text="Good" OnClick="Button2_Click1" />
                      <asp:Button ID="Button3" runat="server" Text="Very Good" OnClick="Button3_Click" />
                      <asp:Button ID="Button4" runat="server" Text="Excellent" OnClick="Button4_Click" />
             
                         
                </div>
                </div>

       <%--   question2--%>

           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label5" runat="server" Text="Label">Question2</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label6" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button5" runat="server" Text="Poor" OnClick="Button5_Click" />
                      <asp:Button ID="Button6" runat="server" Text="Good" />
                      <asp:Button ID="Button7" runat="server" Text="Very Good" />
                      <asp:Button ID="Button8" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>



        <%--  question3--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label7" runat="server" Text="Label">Question3</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label8" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button9" runat="server" Text="Poor" />
                      <asp:Button ID="Button10" runat="server" Text="Good" />
                      <asp:Button ID="Button11" runat="server" Text="Very Good" />
                      <asp:Button ID="Button12" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

         <%-- question4--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label9" runat="server" Text="Label">Question4</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label10" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button13" runat="server" Text="Poor" />
                      <asp:Button ID="Button14" runat="server" Text="Good" />
                      <asp:Button ID="Button15" runat="server" Text="Very Good" />
                      <asp:Button ID="Button16" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question5--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label11" runat="server" Text="Label">Question5</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label12" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button17" runat="server" Text="Poor" />
                      <asp:Button ID="Button18" runat="server" Text="Good" />
                      <asp:Button ID="Button19" runat="server" Text="Very Good" />
                      <asp:Button ID="Button20" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question6--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label13" runat="server" Text="Label">Question6</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label14" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button21" runat="server" Text="Poor" />
                      <asp:Button ID="Button22" runat="server" Text="Good" />
                      <asp:Button ID="Button23" runat="server" Text="Very Good" />
                      <asp:Button ID="Button24" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question7--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label15" runat="server" Text="Label">Question7</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label16" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button25" runat="server" Text="Poor" />
                      <asp:Button ID="Button26" runat="server" Text="Good" />
                      <asp:Button ID="Button27" runat="server" Text="Very Good" />
                      <asp:Button ID="Button28" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question8--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label17" runat="server" Text="Label">Question8</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label18" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button29" runat="server" Text="Poor" />
                      <asp:Button ID="Button30" runat="server" Text="Good" />
                      <asp:Button ID="Button31" runat="server" Text="Very Good" />
                      <asp:Button ID="Button32" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question9--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label19" runat="server" Text="Label">Question9</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label20" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button33" runat="server" Text="Poor" />
                      <asp:Button ID="Button34" runat="server" Text="Good" />
                      <asp:Button ID="Button35" runat="server" Text="Very Good" />
                      <asp:Button ID="Button36" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>

            <%-- question 10--%>
           <div class="question-box">
                <div class="question-text-style">
                <asp:Label ID="Label21" runat="server" Text="Label">Question 10</asp:Label>
                    <br />
                    <br />
                     <asp:Label ID="Label22" runat="server" Text="Label">Question</asp:Label>
                    </div>
                  <div class="button-style">
                    <asp:Button ID="Button37" runat="server" Text="Poor" />
                      <asp:Button ID="Button38" runat="server" Text="Good" />
                      <asp:Button ID="Button39" runat="server" Text="Very Good" />
                      <asp:Button ID="Button40" runat="server" Text="Excellent" />
             
                         
                </div>
                </div>
                 
            <asp:Button ID="Button41" runat="server" Text="Submit" class="submit-button" />
                 
            </form>          
           </div> 
  

   


     
     <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
</body>
</html>
