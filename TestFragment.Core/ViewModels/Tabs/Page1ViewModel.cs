using System.Diagnostics;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace TestFragment.Core.ViewModels.Tabs
{
    public class Page1ViewModel : BaseViewModel
    {
        public ICommand CommandClick
        {
            get
            {
                return new MvxCommand(() => Debug.WriteLine("Click From Page1ViewModel"));
            }
        }
    }
}
