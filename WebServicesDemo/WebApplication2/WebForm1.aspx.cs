using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void get_Click(object sender, EventArgs e)
        {
            WebServicesDemo.WebService1 clint = new WebServicesDemo.WebService1();
            Label1.Text = clint.GetMessage(TextBox1.Text);
        }
    }
}