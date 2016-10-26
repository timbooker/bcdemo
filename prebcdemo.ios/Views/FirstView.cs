using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace prebcdemo.ios.Views
{
	[Register("FirstView")]
	public class FirstView : MvxTableViewController
    {
        public FirstView()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			var source = new MvxStandardTableViewSource(TableView, "TitleText address");
			TableView.Source = source;

			var set = this.CreateBindingSet<FirstView, ViewModels.FirstViewModel>();
			set.Bind(source).To(vm => vm.Data);
			   set.Apply();
        }
    }
}
