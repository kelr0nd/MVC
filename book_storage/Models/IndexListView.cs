using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace book_storage.Models
{
    public class IndexListView
    {
        public int currentPage { get; set; }
        public int totalPage { get; set; }
        public List<Book> books { get; set; }
    }
}