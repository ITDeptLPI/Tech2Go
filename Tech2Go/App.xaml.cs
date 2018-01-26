using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace Tech2Go
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes( IContainerRegistry containerRegistry ) {
            containerRegistry.RegisterForNavigation<NavigationPage>(  );
        }
    }
}

