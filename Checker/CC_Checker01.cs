using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Checker
{

    [Activity(Label = "CC_Checker01")]
    public class CC_Checker01 : Activity
    {
        private int score = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CC_Checker01);
           



            // Create your application here
        }

       
        [Export("btn_ja")]

        public void btn_ja(View v)
        {
            score += 1; 
            Intent intent = new Intent(this, typeof(CC_Checker02));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
          
            
            StartActivity(intent);
        }
        [Export("btn_nein")]

        public void btn_nein(View v)
        {

            Intent intent = new Intent(this, typeof(CC_Checker02));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
            

            StartActivity(intent);
        }
    }
}