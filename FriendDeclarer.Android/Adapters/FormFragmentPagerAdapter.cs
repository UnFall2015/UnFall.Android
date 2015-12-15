using System;
using System.Collections.Generic;
using Android.OS;
using Android.Views;
using Android.Support.V4.View;
using Android.Support.V4.App;
using String = Java.Lang.String;
using Java.Lang;

namespace FriendDeclarer.Android
{
	public class FormFragmentPagerAdapter : FragmentPagerAdapter
	{
		private List<Fragment> fragmentList = new List<Fragment>();
		private readonly string[] Titles =
		{
			"Segurado", "Veículo", "Seguradora","Condutor","Embate"
		};
		public FormFragmentPagerAdapter (FragmentManager fm) : base (fm)
		{
		}

		public override int Count {
			get {
				return fragmentList.Count;
			}
		}
		public override Fragment GetItem (int position)
		{
			return fragmentList [position];
		}

		public void AddFragment(FormViewPagerFragment fragment){
			fragmentList.Add (fragment);
		}

		public void AddFragmentView(Func<LayoutInflater,ViewGroup,Bundle,View> view){
			fragmentList.Add (new FormViewPagerFragment(view));
		}

		public override ICharSequence GetPageTitleFormatted (int position)
		{
			return new String(Titles[position]);
		}
	}
		
}

