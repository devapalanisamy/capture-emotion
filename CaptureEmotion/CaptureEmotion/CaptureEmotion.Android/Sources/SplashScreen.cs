﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace CaptureEmotion.Droid.Sources
{
    [Activity(Label = "Feelings Diary", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}