using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Content.Res;

using SQLite;

using System.Collections.Generic;
using System;
//using System.Runtime.Remoting.Contexts;

namespace Familia
{
	[Activity (Label = "Familia", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		ListView lvRelatives;
		List<Relative> items = new List<Relative>()	;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			RequestWindowFeature (Android.Views.WindowFeatures.NoTitle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			lvRelatives = FindViewById<ListView> (Resource.Id.lvRelatives);



			items.Add(new Relative(this, this.PackageName, "Mário Martins","Icon"));

			lvRelatives.Adapter = new HomeScreenAdapter (this,items);

			lvRelatives.ItemClick += OnListItemClick;


			/*Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};*/
		}

		void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var kustVuew = sender as ListView;
			var t = items [e.Position];
			//Toast.MakeText (this, t.Nome, ToastLength.Short).Show ();
			string a = " " + t.Foto;
			Toast.MakeText (this, a, ToastLength.Short).Show ();
		}

	}
}


