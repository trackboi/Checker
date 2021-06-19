﻿using Android.App;
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
    [Activity(Label = "Datenschutz")]
    public class Datenschutz : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Datenschutz);

            // Create your application here
        }

        [Export("btn_weiter")]

        public void btn_weiter(View v)
        {
            var intent = new Intent(this, typeof(PersonenDaten));
            StartActivity(intent);
        }
    }
}