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

            string[] questions = String.Join(",", Form.Controls.OfType<TextBox>().Select(c => c.Text)).Split(',');

            
          




        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}