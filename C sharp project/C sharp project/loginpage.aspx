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
      <img src="home-images\logo.PNG"  width="5%" height="" style="margin-left:10px" alt="no image"/>
    <a class="navbar-brand " style="margin-right:60% ;color:#D9686C ; font-weight:bold" >PEGASUS</a>
    <form class="d-flex" role="search" >
      <button class="btn btn-outline-success nav-bar" type="submit">Home</button>
        <button class="btn btn-outline-success nav-bar" type="submit">Sign in</button>
          </form>
  </div>
</nav>
    <div class="contain"> 
        <div class="login-image" > <img src="login-images\login-page.PNG"   /></div>
        <div class="container-login">
           
             <form id="form1" runat="server">
       <div class="username"> </div>
       
    </form>
        </div>

    </div>
   
   
</body>
</html>
