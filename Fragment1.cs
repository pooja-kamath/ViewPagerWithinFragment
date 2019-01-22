using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace App3
{
    public class Fragment1 : Fragment
    {
        private View _view;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
        
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var inflaters = (LayoutInflater)Activity.GetSystemService(Context.LayoutInflaterService);
            _view = inflaters.Inflate(Resource.Layout.fragmentLayout, null);

            TextView t = (TextView)_view.FindViewById(Resource.Id.txt);
            t.Text = "Fragment One";

            // Use this to return your custom view for this Fragment
            return _view;
        }
    }
}