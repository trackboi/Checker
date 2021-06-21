using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Java.Interop;

namespace Checker
{
    [Activity(Label = "CC_Checker18")]
    public class CC_Checker18 : Activity
    {
        private int score;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CC_Checker18);
            score = JsonConvert.DeserializeObject<int>(Intent.GetStringExtra("score"));

            // Create your application here
        }
        [Export("btn_ja")]

        public void btn_ja(View v)
        {
            score += 3;
            Intent intent = new Intent(this, typeof(CC_Checker19));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
            

            StartActivity(intent);
        }

        [Export("btn_nein")]

        public void btn_nein(View v)
        {

            Intent intent = new Intent(this, typeof(CC_Checker19));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
      

            StartActivity(intent);
        }
    }
}