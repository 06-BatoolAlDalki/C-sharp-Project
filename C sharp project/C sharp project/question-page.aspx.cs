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


            //Response.Redirect("page3.aspx?ID="+ Label1.Text+"&password="+Label2.Text);

        }
       
          protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
           string answer1 = RadioButton1.Text;

            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer1 + "1,");

        }


         protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
         {

            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer1 = RadioButton2.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer1 + "1,");

        }
        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer1 = RadioButton3.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer1 + "1,");
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer1 = RadioButton4.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer1 + "1,");
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2 = RadioButton5.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2 = RadioButton6.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2 = RadioButton7.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2 = RadioButton8.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        }

        protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer3 = RadioButton9.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");

        }

        protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer3 = RadioButton10.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");

        }

        protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer3 = RadioButton11.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");
        }

        protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer3 = RadioButton12.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3+ "3,");
        }

        protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer4 = RadioButton13.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer4 = RadioButton14.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer4 = RadioButton15.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");

        }

        protected void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer4 = RadioButton16.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        }

        protected void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer5= RadioButton17.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");
        }

        protected void RadioButton18_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer5 = RadioButton18.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");
        }

        protected void RadioButton19_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer5 = RadioButton19.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");

        }

        protected void RadioButton20_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer5 = RadioButton20.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");

        }

        protected void RadioButton21_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer6 = RadioButton21.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton22_CheckedChanged(object sender, EventArgs e)
        {

            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer6 = RadioButton22.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton23_CheckedChanged(object sender, EventArgs e)
        {

            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer6 = RadioButton23.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton24_CheckedChanged(object sender, EventArgs e)
        {

            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer6 = RadioButton24.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        }

        protected void RadioButton25_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer7 = RadioButton25.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");

        }

        protected void RadioButton26_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer7 = RadioButton26.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        }

        protected void RadioButton27_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer7 = RadioButton27.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");

        }

        protected void RadioButton28_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer7 = RadioButton28.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        }

        protected void RadioButton29_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer8 = RadioButton29.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton30_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer8 = RadioButton30.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton31_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer8 = RadioButton31.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton32_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer8 = RadioButton32.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        }

        protected void RadioButton33_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer9 = RadioButton33.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton34_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer9 = RadioButton34.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton35_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer9 = RadioButton35.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton36_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer9 = RadioButton36.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        }

        protected void RadioButton37_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer10 = RadioButton37.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        }

        protected void RadioButton38_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer10 = RadioButton38.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        }

        protected void RadioButton39_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer10 = RadioButton39.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        }

        protected void RadioButton40_CheckedChanged(object sender, EventArgs e)
        {
            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer10 = RadioButton40.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        }



        //    protected void Button5_Click(object sender, EventArgs e)
        //{

        //    string s = "";
        //    int i;
        //    for ( i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer2;
        //    answer2 = Button5.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\"+s, answer2 + "2,");
        //    Button5.Style["background-color"] = "#99FF66";
        //}

        //protected void Button6_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer2;
        //    answer2 = Button6.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        //    Button6.Style["background-color"] = "#99FF66";
        //}

        //protected void Button7_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer2;
        //    answer2 = Button7.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");
        //    Button7.Style["background-color"] = "#99FF66";
        //}

        //protected void Button8_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer2;
        //    answer2 = Button8.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "2,");


        //    //string s1 = File.ReadAllText("C:\\Users\\t\\source\\repos\\1-12-practice\\1-12-practice\\orange.txt");
        //    ////string[] ss=File.ReadAllLines(s);
        //    ////Label2.Text = s;
        //    //string[] ss = File.ReadAllLines("C:\\Users\\t\\source\\repos\\1-12-practice\\1-12-practice\\orange.txt");


        //    //foreach (string lines in ss)
        //    //{
        //    //    Label2.Text += lines + "<br>";

        //    //}

        //    Button8.Style["background-color"] = "#99FF66";
        //}

        //protected void Button9_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer3;
        //    answer3 = Button9.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");

        //}

        //protected void Button10_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer3;
        //    answer3 = Button10.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");
        //}

        //protected void Button11_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer3;
        //    answer3 = Button11.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3 + "3,");
        //}

        //protected void Button12_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer3;
        //    answer3 = Button12.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer3+"3,");
        //}

        //protected void Button13_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer4;
        //    answer4 = Button13.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        //}

        //protected void Button14_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer4;
        //    answer4 = Button14.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        //}

        //protected void Button15_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer4;
        //    answer4 = Button15.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        //}

        //protected void Button16_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer4;
        //    answer4 = Button16.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer4 + "4,");
        //}

        //protected void Button17_Click(object sender, EventArgs e)
        //{

        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer5;
        //    answer5 = Button17.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");
        //}

        //protected void Button18_Click(object sender, EventArgs e)
        //{

        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer5;
        //    answer5 = Button18.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5+ "5,");
        //}

        //protected void Button19_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer5;
        //    answer5 = Button19.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");
        //}

        //protected void Button20_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer5;
        //    answer5 = Button20.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer5 + "5,");
        //}

        //protected void Button21_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer6;
        //    answer6= Button21.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        //}

        //protected void Button22_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer6;
        //    answer6 = Button22.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        //}

        //protected void Button23_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer6;
        //    answer6 = Button23.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        //}

        //protected void Button24_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer6;
        //    answer6 = Button24.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer6 + "6,");
        //}

        //protected void Button25_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer7;
        //    answer7 = Button25.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        //}

        //protected void Button26_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer7;
        //    answer7 = Button26.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        //}

        //protected void Button27_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer7;
        //    answer7 = Button27.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        //}

        //protected void Button28_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer7;
        //    answer7 = Button28.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer7 + "7,");
        //}

        //protected void Button29_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer8;
        //    answer8 = Button29.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        //}

        //protected void Button30_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer8;
        //    answer8 = Button30.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        //}

        //protected void Button31_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer8;
        //    answer8 = Button31.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        //}

        //protected void Button32_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer8;
        //    answer8 = Button32.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer8 + "8,");
        //}

        //protected void Button33_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer9;
        //    answer9 = Button33.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        //}

        //protected void Button34_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer9;
        //    answer9 = Button34.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        //}

        //protected void Button35_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer9;
        //    answer9 = Button35.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        //}

        //protected void Button36_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer9;
        //    answer9 = Button36.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer9 + "9,");
        //}

        //protected void Button37_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer10;
        //    answer10 = Button37.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        //}

        //protected void Button38_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer10;
        //    answer10 = Button38.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        //}

        //protected void Button39_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer10;
        //    answer10 = Button39.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        //}

        //protected void Button40_Click(object sender, EventArgs e)
        //{
        //    string s = "";
        //    int i;
        //    for (i = 0; i < 35; i++)
        //    {
        //        string ID = Request.QueryString["ID"];
        //        if (ID == Convert.ToString(i))
        //        { s = Convert.ToString(i); }
        //    }
        //    string answer10;
        //    answer10 = Button40.Text;
        //    //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
        //    File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer10 + "10,");
        //}









        protected void Button41_Click(object sender, EventArgs e)
        {

            string s = "";
            int i;
            for (i = 0; i < 35; i++)
            {
                string ID = Request.QueryString["ID"];
                if (ID == Convert.ToString(i))
                { s = Convert.ToString(i); }
            }
            string answer2;
            answer2 = Button41.Text;
            //string text2 = "A class is the most powerful data type in C#. Like a structure,a class defines the data and behavior of the data type.";
            File.AppendAllText(@"C:\Users\t\C-sharp-Project\C sharp project\C sharp project\TextFile\" + s, answer2 + "1,");

        }

    }
}