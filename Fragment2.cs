using System;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace App3
{
    public class Fragment2 : Android.Support.V4.App.Fragment
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
            t.Text = "Fragment Two";

            return _view;
        }
    }
}