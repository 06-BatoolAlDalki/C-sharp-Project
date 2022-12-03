using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace C_sharp_project
{
    public partial class question_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             string ID = Request.QueryString["ID"];

            Label1.Text = ID;

            DateTime now = DateTime.Today;
            Label2.Text =Convert.ToString( now.Date);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID== Convert.ToString( i))
                { s = Convert.ToString(i); }
            }
                string answer1 = Button1.Text;
                //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
                File.WriteAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\"+s, answer1);
            
        }
        
        
        protected void Button2_Click1(object sender, EventArgs e)
        {
            //string q1 = "Q1";
            string answer1 = Button2.Text;
            File.WriteAllText(@"C:\\Users\\t\\C-sharp-Project\\C sharp project\\C sharp project\\TextFile1.txt", answer1);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string answer1 = Button3.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.WriteAllText(@"C:\\Users\\t\\C-sharp-Project\\C sharp project\\C sharp project\\TextFile1.txt", answer1);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string answer1 = Button4.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.WriteAllText(@"C:\\Users\\t\\C-sharp-Project\\C sharp project\\C sharp project\\TextFile1.txt", answer1);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2;
            answer2 = Button1.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.WriteAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\"+s, answer2);
        }
    }
}