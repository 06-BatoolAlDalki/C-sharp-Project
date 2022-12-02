<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home-page.aspx.cs" Inherits="C_sharp_project.WebForm1" %>

<!DOCTYPE html>
 <link rel="stylesheet" href="bootstrap-5.2.2-dist/css/bootstrap.css">
    <script src="https://kit.fontawesome.com/a8b56cb52b.js" crossorigin="anonymous"></script>
 

<link rel="stylesheet" href="homepage.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <nav class="navbar bg-light">
  <div class="container-fluid">
      <img src="home-images\logo.PNG"  width="5%" height="" style="margin-left:10px"/>
    <a class="navbar-brand " style="margin-right:60% ; color: #112780">PEGASUS</a>
    <form class="d-flex" role="search" >
      <button class="btn btn-outline-success nav-bar" type="submit">Home</button>
        <button class="btn btn-outline-success nav-bar" type="submit">Sign in</button>
          
    </form>
  </div>
</nav>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>


   
       <div class="footer">
           <div style="display:inline-block;"> <img src="home-images\logo.PNG"  width="15%" height="" style="margin-left:20px"/></div>
           <div style="float:right; font-size:30px; margin-left:5px; margin-right:33px;" ><i class="fa-brands fa-facebook fontawsome"></i>
               <i class="fa-brands fa-github fontawsome"></i><i class="fa-solid fa-envelope fontawsome" style="margin-left:10px;"></i>
           </div>
       </div>
  
</body>
</html>
