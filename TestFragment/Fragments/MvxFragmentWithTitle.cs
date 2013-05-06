using System.Text;
using Android.OS;
using Android.Views;
using Android.Widget;
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

        public MvxFragmentWithTitle(int resourceId, string content)
            : this(resourceId)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < 20; i++)
            {
                if (i != 19)
                    builder.Append(content).Append(" ");
                else
                    builder.Append(content);
            }
            Title = builder.ToString();

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

            // Text
            var text = new TextView(Activity)
                {
                    Gravity = GravityFlags.Center,
                    Text = Title,
                    TextSize = (20 * Resources.DisplayMetrics.Density)
                };
            text.SetPadding(20, 20, 20, 20);

            // Content
            var view = this.BindingInflate(_resourceId, null);

            // Layout encapsulating Text & Content
            var layout = new LinearLayout(Activity)
                {
                    LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent)
                };
            layout.SetGravity(GravityFlags.Center);

            layout.AddView(text);
            layout.AddView(view);

            return layout;
        }
    }
}