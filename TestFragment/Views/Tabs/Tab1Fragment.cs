using TestFragment.Droid.Fragments;

namespace TestFragment.Droid.Views.Tabs
{
    public class Tab1Fragment : MvxFragmentWithTitle
    {
        public Tab1Fragment()
            : base(Resource.Layout.Page1, "MyTab1")
        {
        }
    }
}