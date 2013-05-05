using System;
using System.Diagnostics;
using Cirrious.MvvmCross.Droid.Views;
using TestFragment.Core.ViewModels;

namespace TestFragment.Droid.Views
{
    public class BaseView : MvxActivity
    {
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

        protected override void OnViewModelSet()
        {
            Debug.WriteLine(GetType() + "/OnViewModelSet()");
            base.OnViewModelSet();
        }

        protected override void OnStart()
        {
            Debug.WriteLine(GetType() + "/OnStart()");
            base.OnStart();
        }

        protected override void OnRestart()
        {
            Debug.WriteLine(GetType() + "/OnRestart()");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Debug.WriteLine(GetType() + "/OnResume()");
            base.OnResume();
        }

        protected override void OnStop()
        {
            Debug.WriteLine(GetType() + "/OnStop()");
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            Debug.WriteLine(GetType() + "/OnDestroy()");
            base.OnDestroy();
        }
    }
}