using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Pages
{
    public partial class ReturnBook
    {

        /// <summary>
        ///// this.bookId = bookId;
        //    this.title = title;
        //    this.isbn = isbn;
        //    this.AuthorName = authorName;
        /// </summary>


        /*  BOOK BORROWD FOR DROPDOWN SELECTOR*/
        private int _bookISBN;
        private string _bookTitle;
        private string _loanedDate;
        private string authorName;

        public int BookISBN { get => _bookISBN; set => _bookISBN = value; }
        public string BookTitle { get => _bookTitle; set => _bookTitle = value; }
        public string LoanedDate { get => _loanedDate; set => _loanedDate = value; }
        public string AuthorName { get => authorName; set => authorName = value; }



        /*  Constuctor for DropDownList*/
        public ReturnBook(int bookISBN, string bookTitle, string authourName, string loanedDate)
        {
            BookISBN = bookISBN;
            BookTitle = bookTitle;
            AuthorName = authourName;
            LoanedDate = loanedDate;

        }
    }
}
