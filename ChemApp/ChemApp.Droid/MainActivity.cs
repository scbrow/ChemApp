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
            TextView balance = FindViewById<TextView>(Resource.Id.textView2);
            TextView massp = FindViewById<TextView>(Resource.Id.textView4);
            TextView pos = FindViewById<TextView>(Resource.Id.textView6);
            TextView neg = FindViewById<TextView>(Resource.Id.textView8);
            TextView g = FindViewById<TextView>(Resource.Id.textView10);
            TextView h = FindViewById<TextView>(Resource.Id.textView12);
            TextView s = FindViewById<TextView>(Resource.Id.textView14);
            TextView spont = FindViewById<TextView>(Resource.Id.textView16);
            TextView massr = FindViewById<TextView>(Resource.Id.textView18);
            Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
                String input = et.Text;
                if(input.Equals("MgSO4 + BaCO3"))
                {
                    balance.Text = "MgSO4 + BaCO3 = MgCO3 + BaSO4";
                    g.Text = "-2671.3 kj/mol";
                    massp.Text = "317.7035 g/mol";
                    massr.Text = "317.7035 g/mol";
                    pos.Text = "Mg2+ Ba2+";
                    neg.Text = "SO4(2-) CO3(2-)";
                    h.Text = "-2568.997 kj/mol";
                    s.Text = "197.9 J/mol*K";
                    spont.Text = "No. Negative Delta G";
                }
			};
		}
	}
}


