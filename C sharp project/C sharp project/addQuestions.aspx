<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addQuestions.aspx.cs" Inherits="C_sharp_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="addQuestionscss.css"/>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">
           
            <div class="table">

                <div class="adminhead">
                    <h2 > Admin page </h2>
            <p>welcome MOATH, <br /> Here you can add the survey questions  </p>
                </div> 

            <table style="width: 100%;">
                <tr>
                    <td>Question1</td>
                    <td><asp:TextBox ID="TextBoxes1" CssClass="TextBox" runat="server"></asp:TextBox></td>
                   
                </tr>
                <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                   <td>Question2</td>
                    <td><asp:TextBox ID="TextBoxes2" CssClass="TextBox" runat="server"></asp:TextBox></td>
                   
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question3</td>
                    <td><asp:TextBox ID="TextBoxes3" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question4</td>
                    <td><asp:TextBox ID="TextBoxes4" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question5</td>
                    <td><asp:TextBox ID="TextBoxes5" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question6</td>
                    <td><asp:TextBox ID="TextBoxes6" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
                <tr>
                    <td>Question7</td>
                    <td><asp:TextBox ID="TextBoxes7" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
              <tr>
                    <td>Question8</td>
                    <td><asp:TextBox ID="TextBoxes8" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
              <tr>
                    <td>Question9</td>
                    <td><asp:TextBox ID="TextBoxes9" CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
              <tr>
                    <td>Question10</td>
                    <td><asp:TextBox ID="TextBoxes10"  CssClass="TextBox" runat="server"></asp:TextBox></td>
                    
                </tr>
                 <tr></tr> <tr></tr> <tr></tr> <tr></tr>
           
               </table>
                 <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />
                <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
                </div>
        </div>

    </form>
</body>
</html>
