using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Checker
{
    [Activity(Label = "PersonenDaten")]
    public class PersonenDaten : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PersonenDaten);

            // Create your application here
        }
        
        [Export("btn_weiter")]

         public void btn_weiter(View v)
         {
            
             TextView Spitzname = FindViewById<TextView>(Resource.Id.editText1);
             string m_Spitzname = Spitzname.Text;

            TextView Geschlecht = FindViewById<TextView>(Resource.Id.editText6);
            string m_Geschlecht = Geschlecht.Text;

            TextView Alter = FindViewById<TextView>(Resource.Id.editText8);
            string m_Alter = Alter.Text;

            TextView Gewicht = FindViewById<TextView>(Resource.Id.editText9);
            string m_Gewicht = Gewicht.Text;

            TextView Datum = FindViewById<TextView>(Resource.Id.editText3);
            string m_Datum = Datum.Text;


            string webseite = "http://10.0.2.2:4000/TakeCare?Spitzname=" + m_Spitzname + "&Geschlecht=" + m_Geschlecht + "&Alter=" + m_Alter + "&Gewicht=" + m_Gewicht + "&Datum=" + m_Datum;

             WebRequest request = WebRequest.Create(webseite);
             request.Method = "POST";
             try
             {
                 WebResponse response = request.GetResponse();
             }
             catch (Exception e)
             {
                Console.WriteLine("Fehlermeldung"+e);

             }
            
       
            StartActivity(typeof(Dashboard));

         }
        


    }
}