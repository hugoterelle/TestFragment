using System.Collections.Generic;
using Android.Support.V4.App;
using ViewPagerIndicator;

namespace TestFragment.Droid.Fragments
{
    public class FragmentTextAdapter : TestFragmentAdapter, TitleProvider
    {
        private readonly List<MvxFragmentWithTitle> _fragments;

        public FragmentTextAdapter(FragmentManager fm, List<MvxFragmentWithTitle> fragments)
            : base(fm)
        {
            _fragments = fragments;
        }

        public override Fragment GetItem(int position)
        {
            return _fragments[position];
        }

        public override int Count
        {
            get
            {
                return _fragments.Count;
            }
        }

        public string GetTitle(int position)
        {
            return _fragments[position].Title;
        }
    }
}
