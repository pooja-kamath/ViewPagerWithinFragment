using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;

namespace App3
{
    public class ViewPagerAdapter : FragmentPagerAdapter
    {
        List<Fragment> fragmentList = new List<Fragment>();
        List<String> fragmentTitles = new List<string>();
        public ViewPagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public ViewPagerAdapter(FragmentManager fm) : base(fm)
        {
        }

        public override int Count
        {
            get { return fragmentList.Count; }
        }
        public override Fragment GetItem(int position)
        {
            return fragmentList.ElementAt(position);
        }
        public void addFragment(Fragment fragment, String name)
        {
            fragmentList.Add(fragment);
            fragmentTitles.Add(name);
        }
    }
    public class HomeFragment :  Fragment
    {
        ViewPagerAdapter _mCustomPagerAdapter;
        ViewPager viewPager;
        TabLayout tabLayout;
        private View _view;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var inflaters = (LayoutInflater)Activity.GetSystemService(Context.LayoutInflaterService);
            _view = inflaters.Inflate(Resource.Layout.homeFragment, null);

            viewPager = (ViewPager)_view.FindViewById(Resource.Id.pager);
            tabLayout = (TabLayout)_view.FindViewById(Resource.Id.tab);

            // Create your fragment here
            SetViewPager();
            tabLayout.SetupWithViewPager(viewPager);
            return _view;

        }

        private void SetViewPager()
        {

            ViewPagerAdapter viewPagerAdapter = new ViewPagerAdapter(ChildFragmentManager);
            viewPagerAdapter.addFragment(new Fragment1(), "First");
            viewPagerAdapter.addFragment(new Fragment2(),   "Secound");
            viewPager.Adapter = viewPagerAdapter;
            
        }
      
    }
}
