using TestFragment.Core.ViewModels.Tabs;

namespace TestFragment.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel Vm1 { get; set; }
        public BaseViewModel Vm2 { get; set; }
        public BaseViewModel Vm3 { get; set; }

        public MainViewModel()
        {
            Vm1 = new Page1ViewModel();
            Vm2 = new Page2ViewModel();
            Vm3 = new Page3ViewModel();
        }
    }
}
