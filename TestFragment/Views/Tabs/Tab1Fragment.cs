using Android.OS;
using Android.Views;
using TestFragment.Core.ViewModels.Tabs;
using TestFragment.Droid.Fragments;

namespace TestFragment.Droid.Views.Tabs
{
    public class Tab1Fragment : MvxFragmentWithTitle
    {
        public Tab1Fragment()
            : base(Resource.Layout.Page1, "MyTab1")
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewModel = new Page1ViewModel();
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}