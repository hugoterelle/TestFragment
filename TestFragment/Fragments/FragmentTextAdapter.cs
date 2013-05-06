using System.Collections.Generic;
using Android.Support.V4.App;
using ViewPagerIndicator.Droid;

namespace TestFragment.Droid.Fragments
{
    public class FragmentTextAdapter : FragmentPagerAdapter, TitleProvider
    {
        private readonly List<MvxFragmentWithTitle> _fragments;
        private int _count;

        public FragmentTextAdapter(FragmentManager fm, List<MvxFragmentWithTitle> fragments)
            : base(fm)
        {
            _fragments = fragments;
            _count = _fragments.Count;
        }

        public override Fragment GetItem(int position)
        {
            return _fragments[position];
        }

        public override int Count
        {
            get
            {
                return _count;
            }
        }

        public string GetTitle(int position)
        {
            return _fragments[position].Title;
        }

		public void SetCount (int count)
		{
			if (count > 0 && count <= 10) 
            {
				_count = count;
				NotifyDataSetChanged();
			}
		}
    }
}
