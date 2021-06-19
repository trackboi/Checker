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
        private int score;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CC_Checker01);
            string st = Intent.GetSerializableExtra("score");

            // Create your application here
        }
        [Export("btn_weiter")]

        public void btn_weiter(View v)
        {
            Intent intent = new Intent(this, typeof(CC_Checker02));
            intent.PutExtra("score", JsonConvert.SerializeObject(score));
            score = JsonConvert.DeserializeObject<score>(Intent.GetStringExtra("score"));
            
            StartActivity(intent);
        }
    }
}