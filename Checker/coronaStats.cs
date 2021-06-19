using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace Checker
{
    [Activity(Label = "coronaStats")]
    public class coronaStats : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.coronaStats);


            ImageView ampel = FindViewById<ImageView>(Resource.Id.ampel_view);

            string webseite = "https://api.corona-zahlen.org/districts/08118";

            WebRequest request = WebRequest.Create(webseite);
            request.Method = "GET";
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fehlermeldung" + e);

            }

            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                

                Dictionary<string, Dictionary<string, Dictionary<string, string>>> res = 
                    JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(responseFromServer);

                Console.WriteLine(responseFromServer);

                string inzidenz = res["data"]["081118"]["weekIncidence"];
            }

            // Create your application here
        }
    }
}