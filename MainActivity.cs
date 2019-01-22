using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        private TextView textMessage;
        private FragmentTransaction fragmentTransaction;
        private HomeFragment homeFragment;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
             fragmentTransaction = SupportFragmentManager.BeginTransaction();
             homeFragment = new HomeFragment();
            fragmentTransaction.Add(Resource.Id.BFT_Container, homeFragment, "tag");
            fragmentTransaction.Commit();

        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    homeFragment.View.Visibility = ViewStates.Visible;
                    textMessage.Visibility = ViewStates.Invisible;
                    return true;
                case Resource.Id.navigation_dashboard:
                    homeFragment.View.Visibility = ViewStates.Invisible;
                    textMessage.Visibility = ViewStates.Visible;

                    textMessage.SetText(Resource.String.title_dashboard);
                    return true;
                case Resource.Id.navigation_notifications:
                    homeFragment.View.Visibility = ViewStates.Invisible;
                    textMessage.Visibility = ViewStates.Visible;

                    textMessage.SetText(Resource.String.title_notifications);
                    return true;
            }
            return false;
        }
    }
}

