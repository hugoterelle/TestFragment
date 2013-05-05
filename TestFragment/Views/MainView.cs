using System;
using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Fragging;
using TestFragment.Core.ViewModels;
using TestFragment.Droid.Views.Tabs;
using Debug = System.Diagnostics.Debug;

namespace TestFragment.Droid.Views
{
    [Activity(MainLauncher = true, Icon = "@null", Label = "TestFragment!!!")]
    public class MainView : MvxTabsFragmentActivity
    {
        public MainView() : base(Resource.Layout.Main, Resource.Id.actualtabcontent)
        {
        }

        public new MainViewModel ViewModel
        {
            get
            {
                return (MainViewModel)base.ViewModel;
            }

            set
            {
                base.ViewModel = value;
            }
        }

        protected override void AddTabs(Bundle args)
        {
            AddTab<Tab1Fragment>("Tab1", "Tab 1", args, ViewModel.Vm1);
            AddTab<Tab2Fragment>("Tab2", "Tab 2", args, ViewModel.Vm2);
            AddTab<Tab3Fragment>("Tab3", "Tab 3", args, ViewModel.Vm3);
        }

        protected bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

        public override void OnBackPressed()
        {
            Debug.WriteLine(GetType() + "/OnBackPressed()");
            Debug.WriteLine("ViewModel.GetType=" + ViewModel.GetType());
            if (IsSubclassOfRawGeneric(typeof(BaseViewModel), ViewModel.GetType()))
            {
                Debug.WriteLine("ViewModel = BaseViewModel");
                var vm = (BaseViewModel)ViewModel;
                vm.BackPressed();
            }
            else
            {
                Debug.WriteLine("ViewModel != BaseViewModel");
                base.OnBackPressed();
            }
        }
    }
}