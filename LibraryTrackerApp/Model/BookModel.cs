using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LibraryTrackerApp.Model
{
    internal class BookModel
    {
        public int S_no { get; set; }

        //Book_Id
        public String? Book_Id { get; set; }
        // book_Title
        public string? Book_Title { get; set; }

        //short description
        public string? Book_Description { get; set; }

        // author name
        public string? Author { get; set; }

        // Category
     public string? category { get; set; }

        //published year
        public string? Year { get; set; }
    }
}
