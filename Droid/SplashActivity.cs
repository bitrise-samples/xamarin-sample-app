﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace XamarinSampleApp.Droid
{
	[Activity(Label = "Bitrise", Icon = "@drawable/icon", MainLauncher = true, Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class SplashActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			var intent = new Intent(this, typeof(MainActivity));
			StartActivity(intent);
		}
	}
}

