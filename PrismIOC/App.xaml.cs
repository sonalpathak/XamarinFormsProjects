using Prism.Unity;
using PrismIOC.Implementation;
using PrismIOC.Services;
using PrismIOC.ViewModels;
using PrismIOC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Navigation;

using Xamarin.Forms;

namespace PrismIOC
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/AddBooks");

        }
        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();

            //Container.RegisterTypeForNavigation<HomePage>();
            Container.RegisterTypeForNavigation<AddBooks>();
            Container.RegisterTypeForNavigation<ViewBooks>();
            Microsoft.Practices.Unity.UnityContainerExtensions.RegisterType<IBooksDB, BooksDB>(Container);


        }
    }
}
