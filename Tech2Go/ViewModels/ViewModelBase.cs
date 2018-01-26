using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Tech2Go.ViewModels {
	public class ViewModelBase : BindableBase, INavigatedAware {
		private INavigationService _navigationService;
		private string _title;

		public string Title {
			get => _title;
			set => SetProperty( ref _title, value );
		}

		public ViewModelBase( INavigationService navigationService ) {
			_navigationService = navigationService;
			Title = string.Empty;
		}

		public virtual void OnNavigatedFrom( NavigationParameters parameters ) { }

		public virtual void OnNavigatedTo( NavigationParameters parameters ) { }
	}
}