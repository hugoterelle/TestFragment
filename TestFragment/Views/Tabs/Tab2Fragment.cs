using Android.OS;
using Android.Views;
using TestFragment.Core.ViewModels.Tabs;
using TestFragment.Droid.Fragments;

namespace TestFragment.Droid.Views.Tabs
{
    public class Tab2Fragment : MvxFragmentWithTitle
    {
        public Tab2Fragment()
            : base(Resource.Layout.Page2, "MyTab2")
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewModel = new Page2ViewModel();
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}