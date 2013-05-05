using Cirrious.MvvmCross.ViewModels;
using TestFragment.Core.ViewModels;

namespace TestFragment.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            RegisterAppStart<MainViewModel>();
        }

        public void RegisterData()
        {
        }
    }
}
