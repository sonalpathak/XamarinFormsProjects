using PrismIOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismIOC.Services
{
    public interface IBooksDB
    {
        List<Books> GetBooks();
        Books GetBook(string name);
        void AddBooks(Books books);
        void DeleteBooks();
    }
}
