using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Cirrious.MvvmCross.Droid.Fragging;
using TestFragment.Core.ViewModels;
using TestFragment.Core.ViewModels.Tabs;
using TestFragment.Droid.Fragments;
using TestFragment.Droid.Views.Tabs;
using ViewPagerIndicator.Droid;

namespace TestFragment.Droid.Views
{
    [Activity(MainLauncher = true, Icon = "@null", Label = "TestFragment!!!")]
    public class MainView : MvxFragmentActivity
    {
        private List<MvxFragmentWithTitle> _fragments;

        private FragmentTextAdapter _adapter;
        private ViewPager _pager;
        private PageIndicator _indicator;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            _fragments = new List<MvxFragmentWithTitle>
                {
                    new Tab1Fragment(),
                    new Tab2Fragment(),
                    new Tab3Fragment(),
                    new Tab3Fragment(),
                    new Tab3Fragment(),
                    new Tab3Fragment(),
                    new Tab3Fragment(),
                    new Tab3Fragment()
                };

            _adapter = new FragmentTextAdapter(SupportFragmentManager, _fragments);

            _pager = FindViewById<ViewPager>(Resource.Id.pager);
            _pager.Adapter = _adapter;

            _indicator = FindViewById<TitlePageIndicator>(Resource.Id.indicator);
            _indicator.SetViewPager(_pager);
        }

        public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }

            set { base.ViewModel = value; }
        }
    }
}