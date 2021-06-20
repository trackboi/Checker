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

                int pos = responseFromServer.IndexOf("weekIncidence", 0, responseFromServer.Length - 1) + 15;

                string inz_str = "";

                for (int i = 0; i<5; i++)
                {
                    inz_str = inz_str + responseFromServer[pos + i];
                }

                float inz_flo = float.Parse(inz_str);


                var imageView = FindViewById<ImageView>(Resource.Id.ampel_view);
                

                if (inz_flo < 35)
                {
                    imageView.SetImageResource(Resource.Drawable.green_dot);
                }
                else if (35 <= inz_flo  || inz_flo < 100)
                {
                    imageView.SetImageResource(Resource.Drawable.yellow_dot);
                }
                else
                {
                    imageView.SetImageResource(Resource.Drawable.red_dot);
                }

            }

            // Create your application here
        }
    }
}