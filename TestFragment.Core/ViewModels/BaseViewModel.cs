using Cirrious.MvvmCross.ViewModels;
using System.Diagnostics;
using System.Windows.Input;
using Cirrious.CrossCore;

namespace TestFragment.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public ICommand CommandCancel
        {
            get
            {
                return new MvxCommand(RequestClose);
            }
        }

        protected virtual void RequestClose()
        {
            var closer = Mvx.Resolve<IViewModelCloser>();
            closer.RequestClose(this);
        }

        public virtual void BackPressed()
        {
            Debug.WriteLine(GetType() + "/BackPressed()");
            RequestClose();
        }

        public override void Start()
        {
            Debug.WriteLine(GetType().Name + "/Start()");
            base.Start();
        }
    }
}
