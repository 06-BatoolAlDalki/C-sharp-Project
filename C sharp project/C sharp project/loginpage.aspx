<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="C_sharp_project.loginpage" %>

<!DOCTYPE html>
<meta name="viewport" content="width=device-width, initial-scale=1">
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="loginpage.css">
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
      <button class="btn btn-outline-success nav-bar" type="submit">Home</button>
        <button class="btn btn-outline-success nav-bar" type="submit">Sign in</button>
       <%-- <div class ="batool">batool walid</div>  --%>
    </form>
  </div>
</nav>
    <div class="contain"> 
      
        <div class="container-login">
           
             <form id="form1" runat="server">
       <div class="username"> </div>
       
    </form>
        </div>
          <div class="login-image" > <img src="login-images\loginimage.PNG"   /></div>
    </div>
   
   



     <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo1.PNG"  width="15%" height="" style=" position:relative; left :10px ; "/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
</body>
</html>
