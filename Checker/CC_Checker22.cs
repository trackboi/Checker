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
    [Activity(Label = "CC_Checker22")]
    public class CC_Checker22 : Activity
    {
        private int score;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CC_Checker22);
            score = JsonConvert.DeserializeObject<int>(Intent.GetStringExtra("score"));


            // Create your application here
        }

        [Export("btn_weiter")]

        public void btn_weiter(View v)
        {

            Intent intent = new Intent(this, typeof(CC_Checker23));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
            JsonConvert.DeserializeObject<int>(Intent.GetStringExtra("score"));

            StartActivity(intent);
        }
    }
}