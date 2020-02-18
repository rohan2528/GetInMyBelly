using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetInMyBelly.Login_Service;

namespace GetInMyBelly
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnCollections_Click(object sender, EventArgs e)
        {
            Response.Redirect("Restaurant_Establishments.aspx");
        }

        protected void btnEstablishments_Click(object sender, EventArgs e)
        {
            Response.Redirect("Restaurant_Collections.aspx");
        }

        protected void btnNear_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44300/api/Restaurant/GetRestaurant_Models");
        }

        protected void btnSoap_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
               
        }
    }
}