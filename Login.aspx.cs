using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetInMyBelly.Login_Service;


namespace GetInMyBelly
{
    public partial class Login : System.Web.UI.Page
    {
        LoginService loginService = new LoginService();
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

            a = Convert.ToString(lblRestaurantName.Text);
            b = Convert.ToString(lblAddress.Text);

        }
    }
}