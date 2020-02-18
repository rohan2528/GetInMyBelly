using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetInMyBelly.Controllers;
using GetInMyBelly.Models;

namespace GetInMyBelly
{
    public partial class Restaurant_Near : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("/api/Restaurant/GetRestaurant_Models");

            //httpWebRequest.Headers.Add("user-key", "c640a9e12e1073914f46b9fe01c61cbe");
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                var text = Newtonsoft.Json.JsonConvert.DeserializeObject(responseText);
               Response.Write(text);
               
            }
        }
    }
}