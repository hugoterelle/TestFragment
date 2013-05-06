using Android.OS;
using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Droid.Fragging.Fragments;

namespace TestFragment.Droid.Fragments
{
    public class MvxFragmentWithTitle : MvxFragment
    {
        private const string KeyContent = "TestFragment:Content";
        public string Title { get; set; }
        private readonly int _resourceId;

        public MvxFragmentWithTitle(int resourceId)
        {
            _resourceId = resourceId;
        }

        public MvxFragmentWithTitle(int resourceId, string title)
            : this(resourceId)
        {
            Title = title;
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutString(KeyContent, Title);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Why?
            base.OnCreateView(inflater, container, savedInstanceState);

            // Title saved?
            if ((savedInstanceState != null) && savedInstanceState.ContainsKey(KeyContent))
            {
                Title = savedInstanceState.GetString(KeyContent);
            }

            // Content
            return this.BindingInflate(_resourceId, null);
        }
    }
}