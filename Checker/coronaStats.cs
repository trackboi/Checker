using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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

            string webseite = "https://api.corona-zahlen.org/districts/08136";

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
            // holt sich den dataStream von response
            using (Stream dataStream = response.GetResponseStream())
            {
               //Initialsiert StreamReader
                StreamReader reader = new StreamReader(dataStream);
                // Liest den Stream und schreibt Daten in den String
                string responseFromServer = reader.ReadToEnd();
               
                //Ungleichen Json Format deshalb wird der string nach Inzidenz durchsucht
                int pos = responseFromServer.IndexOf("weekIncidence", 0, responseFromServer.Length - 1) + 15;
               
               //wird leer initialisiert 
                string inz_str = "";

               //5 nachfolgende zeichen werden ausgelsen 
                for (int i = 0; i<5; i++)
                {
                    inz_str = inz_str + responseFromServer[pos + i];
                }
                //umwandeln von string in ein float 
                float inz_flo = float.Parse(inz_str);


                var imageView = FindViewById<ImageView>(Resource.Id.ampel_view);

                TextView Ausgabe = FindViewById<TextView>(Resource.Id.textView6);

                Ausgabe.Text = inz_str;


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

            
        }
    }
}