﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C_sharp_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {


            int countTB = 0;
            foreach (Control c in form1.Controls) //here is the minor change
            {
                if (c.GetType() == typeof(TextBox))
                {
                    countTB++;
                }
            }
          Response.Write(countTB.ToString());
            for(int i = 1; i <= 10; i++)
            {
                string[] moath= new string[countTB];
                moath[i-1]= (TextBox)(TextBox[i]).Text;
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}