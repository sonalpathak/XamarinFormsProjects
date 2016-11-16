using Prism.Navigation;
using Prism.Mvvm;
using PrismIOC.ViewModels;
//using PrismUnitySampleApp.Interfaces;
//using PrismIOC.
//using PrismUnitySampleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PrismIOC.Services;

using System.IO;
using PrismIOC.Models;

namespace PrismIOC.ViewModels
{
    public class AddBooksViewModel : BindableBase
    {
        INavigationService _navigationService;
        public Command AddBookCommand { get; set; }
        public Command ImageCommand { get; set; }
        IBooksDB _bookDB;
        private string _booktitle;
        public string BookTitle
        {
            get
            {
                return _booktitle;

            }
            set
            {
                SetProperty(ref _booktitle, value);
            }
        }

        private string _bookSubtitle;
        public string BookSubtitle
        {
            get
            {
                return _bookSubtitle;

            }
            set
            {
                SetProperty(ref _bookSubtitle, value);
            
            }
        }

  
        public AddBooksViewModel(IBooksDB bookDB, INavigationService navigationService)
        {
            _navigationService = navigationService;
            AddBookCommand = new Command(AddBookToDb);
           _bookDB = bookDB;
           }

        private async void AddBookToDb()
        {
            Books b = new Books
            {
                BookName = BookTitle,
                SubTitle = BookSubtitle
            };
            _bookDB.AddBooks(b);
            await _navigationService.NavigateAsync("HomePage");
        }
    }
}











