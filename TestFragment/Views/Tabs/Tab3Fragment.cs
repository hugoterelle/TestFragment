using Android.OS;
using Android.Views;
using TestFragment.Core.ViewModels.Tabs;
using TestFragment.Droid.Fragments;

namespace TestFragment.Droid.Views.Tabs
{
    public class Tab3Fragment : MvxFragmentWithTitle
    {
        public Tab3Fragment()
            : base(Resource.Layout.Page3, "MyTab3")
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ViewModel = new Page3ViewModel();
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}