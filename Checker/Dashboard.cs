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

namespace Checker
{
    [Activity(Label = "Dashboard")]
    public class Dashboard : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Dashboard);

            // Create your application here
        }

        [Export("coronaStats")]
        public void coronaStats(View v)
        {
            StartActivity(typeof(coronaStats));
        }
    }
}