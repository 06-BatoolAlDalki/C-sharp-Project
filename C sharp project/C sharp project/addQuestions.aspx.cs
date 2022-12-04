using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

<<<<<<< HEAD

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
                //moath[i-1]= (TextBox)(TextBox[i]).Text;
            }
=======
            string[] questions = String.Join(",", Form.Controls.OfType<TextBox>().Select(c => c.Text)).Split(',');
>>>>>>> 5f492bc65e75293390e8260a931bf615284cd75f

            
          




        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}