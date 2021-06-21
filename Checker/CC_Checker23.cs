﻿using Android.App;
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

namespace Checker
{
    [Activity(Label = "CC_Checker23")]
    public class CC_Checker23 : Activity
    {
        private int score;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CC_Checker23);
            TextView Ausgabe = FindViewById<TextView>(Resource.Id.textView5);
            score = JsonConvert.DeserializeObject<int>(Intent.GetStringExtra("score"));
            Ausgabe.Text = score.ToString();

            // Create your application here
        }

    }
}