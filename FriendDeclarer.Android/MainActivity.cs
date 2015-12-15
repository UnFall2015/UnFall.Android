using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Toolbar=Android.Support.V7.Widget.Toolbar;


namespace FriendDeclarer.Android
{
	[Activity (Label = "FriendDeclarer.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ActionBarActivity
	{
		

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);

			var tabs = FindViewById<PagerSlidingTabStrip.PagerSlidingTabStrip> (Resource.Id.tabs);
			var pager = FindViewById<ViewPager> (Resource.Id.viewpager);
			var adapter = new FormFragmentPagerAdapter (SupportFragmentManager);

			adapter.AddFragmentView ((i,v,b)=>{
				var view = i.Inflate (Resource.Layout.SeguradoLayout,v,false);
				//var textview = view.FindViewById<TextView> (Resource.Id.apelidoText);

				//textview.Text = "Page 1";

				return view;
			});

			adapter.AddFragmentView ((i,v,b)=>{
				var view = i.Inflate (Resource.Layout.VehicleLayout,v,false);

				return view;
				});

			adapter.AddFragmentView ((i,v,b)=>{
				var view = i.Inflate (Resource.Layout.PagerLayout,v,false);
				var textview = view.FindViewById<TextView> (Resource.Id.textview1);

				textview.Text = "Page 24";

				return view;
				});
			adapter.AddFragmentView ((i,v,b)=>{
				var view = i.Inflate (Resource.Layout.PagerLayout,v,false);
				var textview = view.FindViewById<TextView> (Resource.Id.textview1);

				textview.Text = "Page 24";

				return view;
			});
			adapter.AddFragmentView ((i,v,b)=>{
				var view = i.Inflate (Resource.Layout.PagerLayout,v,false);
				var textview = view.FindViewById<TextView> (Resource.Id.textview1);

				textview.Text = "Page 24";

				return view;
			});

			
			pager.Adapter = adapter;
			tabs.SetViewPager (pager);
			SetSupportActionBar (toolbar);
			//SupportActionBar.Title = "Formulário";

	
			

		}
	}
}


