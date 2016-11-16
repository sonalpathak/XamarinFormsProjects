using PrismIOC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismIOC.Models;
using SQLite.Net;

namespace PrismIOC.Implementation
{
    public class BooksDB : IBooksDB
    { 
          private SQLiteConnection _connection;
    ISQlite _con;
    Books _books;

    public BooksDB(ISQlite sql)

    {
        _con = sql;
        _connection = _con.connection();

        _connection.CreateTable<Books>();
    }
    
        public void AddBooks(Books books)
        {
            _books = new Books
            {
                BookName = books.BookName,
                SubTitle = books.SubTitle

            };


            _connection.Insert(_books);

        }

        public void DeleteBooks()
        {
            _connection.DeleteAll<Books>();
        }

        public Books GetBook(string name)
        {
            return (_connection.Table<Books>().FirstOrDefault(b => b.BookName == name));
        }

        public List<Books> GetBooks()
        {
            return (from book in _connection.Table<Books>() select book).ToList();
        }
    }
}
