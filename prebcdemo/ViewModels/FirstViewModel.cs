using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MvvmCross.Core.ViewModels;

namespace prebcdemo.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		readonly IMappySuggestRequestGeneratorService mappySuggestRequestGenerator;


		public FirstViewModel(IMappySuggestRequestGeneratorService mappySuggestRequestGenerator)
		{
			this.mappySuggestRequestGenerator = mappySuggestRequestGenerator;;
		}

		private ObservableCollection<Suggest> _data;
		public ObservableCollection<Suggest> Data
		{
			get { return _data; }
			set { SetProperty(ref _data, value); }
		}

		public async void Init() { 
			var res = await this.mappySuggestRequestGenerator.InterfaceAndMethodToRequest<ISuggest, RootObject>(x => x.Get("131 rue de rom", "all"));
			Data = new ObservableCollection<Suggest>(res.suggests.Select(x => new Suggest() { address = x.address.StripHtml() }));
		}
    }
}
