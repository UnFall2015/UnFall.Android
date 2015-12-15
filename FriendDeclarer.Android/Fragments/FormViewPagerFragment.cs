using System;
using Android.Support.V4.App;
using Android.Views;
using Android.OS;

namespace FriendDeclarer.Android
{
	public class FormViewPagerFragment : Fragment
	{
		private Func<LayoutInflater,ViewGroup,Bundle,View> _view;

		public FormViewPagerFragment(Func<LayoutInflater,ViewGroup,Bundle,View> view){
			_view = view;
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState){
			base.OnCreateView (inflater, container, savedInstanceState);
			return _view (inflater, container, savedInstanceState);
		}
	}
}

