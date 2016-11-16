
using Prism.Mvvm;
using PrismIOC.Models;
using PrismIOC.Services;
using PrismIOC.ViewModels;

using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismIOC.ViewModels
{
    public class ViewBooksViewModel : BindableBase
    {
        IBooksDB _booksDB;
        private ObservableCollection<Books> _books;
        public ObservableCollection<Books> MyBooks
        {
            get { return _books; }
            set { SetProperty(ref _books, value); }
            
            
        }
        public ViewBooksViewModel(IBooksDB BooksDB)
        {
            _booksDB = BooksDB;
            BooksList();
        }
       

        public void BooksList()
        {
           
            List<Books> bk = new List<Models.Books>();
            bk = _booksDB.GetBooks();
      
            MyBooks = new ObservableCollection<Books>(bk);
            


        }
    }
}
