using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
    public class ReturnBookData
    {
        private string _patron; //Borrower
        private int _patronID;
        private int _bookISBN;
        private string _book;
        private string _loanedDate;

        
        public int PatronId { get => _patronID; set => _patronID = value; }
        public string Patron { get => _patron; set => _patron = value; }
        public int BookISBN { get => _bookISBN; set => _bookISBN = value; }
        public string Book { get => _book; set => _book = value; }
        public string LoanedDate { get => _loanedDate; set => _loanedDate = value; }
        //public string ReturnDate { get => _returnDate; set => _returnDate = value; }


        //  Drop down list //
        public ReturnBookData(int patronId, string patron, int bookISBN, string book, string loanedDate)
        {
            BookISBN = bookISBN;
            Book = book;
            LoanedDate = loanedDate;
        }

        public int GetPatronID()
        {
            return PatronId;
        }

        public string GetPatron()
        {
            return Patron;
        }
        public int GetBookISBN()
        {
            return BookISBN;
        }

        public string GetBook()
        {
            return Book;
        }
        public string GetLoanedDate()
        {
            return LoanedDate;
        }


    }
}
