using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ChemApp.Droid
{
	[Activity (Label = "ChemApp.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            EditText et = FindViewById<EditText>(Resource.Id.editText1);
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
                String input = et.Text;
			};
		}
	}
}


