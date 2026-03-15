using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTrackerApp.Model
{
    internal class IssueBookModel
    {
        public int? Member_Id { get; set; }
        public int? Book_Id { get; set; }
        public string? Issue_Date{ get; set; }
         public string? Due_Date { get; set; }


    }
}
