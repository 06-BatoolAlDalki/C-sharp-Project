﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C_sharp_project
{
    public partial class loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] id = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35" };
        
            string[] pass = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35" };
       for(int i=0;i<35;i++)
            {

                if ((id[i]==  TextBox1.Text) && (pass[i]== TextBox2.Text)) {

                    Response.Redirect("question-page.aspx");
                }
                else if((id[i] == "") && (pass[i] == ""))
                {
                    Response.Redirect("loginpage.aspx");
                }
                else if ((id[i] != TextBox1.Text) || (pass[i] != TextBox2.Text))
                {
                  
                    Label3.Visible= true;
                    Label3.Text = "your Id or Password not correct";
                }
            }
        
      
        }
   
    
    
    
    }

}