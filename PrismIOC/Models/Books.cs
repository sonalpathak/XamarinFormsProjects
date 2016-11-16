using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismIOC.Models
{
   public class Books
    {
        [PrimaryKey, AutoIncrement]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Image { get; set; }
        public string SubTitle { get; set; }
    }
}
