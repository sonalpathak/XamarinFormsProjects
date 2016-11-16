using Prism.Mvvm;
using Prism.Navigation;
using PrismIOC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismIOC.ViewModels
{
    public class HomePageViewModel:BindableBase
    {
        INavigationService _navigationService;
        public Command AddBooksCommand { get { return addbookscmd; } }
        private Command addbookscmd;


        public Command viewbookscmd { get; set; }

        public Command deletebookscmd { get; set; }

        public Command TestProp { get; set; }

        IBooksDB _booksDB;


        public HomePageViewModel(INavigationService navigationService,IBooksDB booksDB)
        {
            _booksDB = booksDB;
            /* withourt IOC INagavigationService has to new up a concrete version of service
 _navigationService= new SomeService()*/

            _navigationService = navigationService;
            addbookscmd = new Command(addbooksimplementation);
            viewbookscmd = new Command(ViewBooksFromDb);
            deletebookscmd = new Command(DeleteBooksFromDB);


           
        }
        private void DeleteBooksFromDB()
        {
            _booksDB.DeleteBooks();
        }

        private async void addbooksimplementation()
        {

            await _navigationService.NavigateAsync("AddBooks");

        }
        private async void ViewBooksFromDb()
        {
            await _navigationService.NavigateAsync("ViewBooks");
        }

    }
}

