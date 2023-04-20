using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaVinci.Data
{
    public class ReturnBookData
    {
        private int _patronID;
        private int _bookISBN;
        private int _bookID;
        private string _book;
        private string _patron; //Borrower
        private string _loanedDate;
        private string _returnDate;

        
        public int PatronId { get => _patronID; set => _patronID = value; }
        public string Patron { get => _patron; set => _patron = value; }
        public int BookISBN { get => _bookISBN; set => _bookISBN = value; }
        public string Book { get => _book; set => _book = value; }
        public string LoanedDate { get => _loanedDate; set => _loanedDate = value; }
        public string ReturnDate { get => _returnDate; set => _returnDate = value; }



        public ReturnBookData(int patronId, string patron, int bookISBN, string book, string loanedDate, string returnDate)
        {
            PatronId = patronId;
            Patron = patron;
            BookISBN = bookISBN;
            Book = book;
            LoanedDate = loanedDate;
            ReturnDate = returnDate;
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
        public string GetReturnDate()
        {
            return LoanedDate;
        }


    }
}
