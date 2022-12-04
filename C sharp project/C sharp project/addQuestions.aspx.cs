using System;
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
            string gg = TextBox1.Text;
            for (int y=1; y<=10; y++)
            {
                string[] text= new string[y];
                text[y-1]= $"TextBox{[y].Text}";
                Response.Write(text[y-1]);
            }
            //for(int i=1;i<=10;i++) 
            //{
            //    string[] print = new string[10] ;
            //    print[i] = TextBox1.Text;
            //}

        }
    }
}