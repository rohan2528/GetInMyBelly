using System;
using System.IO;
using System.Net;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;


namespace GetInMyBelly
{
    public partial class Restaurant_Establishments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://developers.zomato.com/api/v2.1/collections?city_id=31");

            httpWebRequest.Headers.Add("user-key", "c640a9e12e1073914f46b9fe01c61cbe");
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