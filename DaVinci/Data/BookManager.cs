using System;
using System.Collections.Generic;
using System.Linq;

namespace DaVinci.Data
{
    public class BookManager
    {
        private static List<Book> bookList = PopulateListManager.GetBookDetails();

        public BookManager()
        {
        }

        public static List<Book> FindMatchingBooks(string userSearchInput, string category, string authorName, string language)
        {
            var matchingBooks = bookList
                .Where(b =>
                    (string.IsNullOrEmpty(userSearchInput) || b.Title.Equals(userSearchInput, StringComparison.OrdinalIgnoreCase))
                    && (string.IsNullOrEmpty(category) || category.Equals("any", StringComparison.OrdinalIgnoreCase) || b.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    && (string.IsNullOrEmpty(authorName) || authorName.Equals("any", StringComparison.OrdinalIgnoreCase) || b.AuthorName.Equals(authorName, StringComparison.OrdinalIgnoreCase))
                    && (string.IsNullOrEmpty(language) || language.Equals("any", StringComparison.OrdinalIgnoreCase) || b.Language.Equals(language, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            if (matchingBooks.Count == 0)
            {
                matchingBooks.Add(new Book()
                {
                    Title = "No books found for the search",
                    AuthorName = "",
                    Category = "",
                    Isbn = "",
                    Language = ""
                }
                );

            }

            return matchingBooks;
        }
    }
}
