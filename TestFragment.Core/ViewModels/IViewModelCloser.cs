using Cirrious.MvvmCross.ViewModels;

namespace TestFragment.Core.ViewModels
{
    public interface IViewModelCloser
    {
        void RequestClose(IMvxViewModel viewModel);
    }
}
