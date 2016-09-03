using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.BookDSTableAdapters;

namespace DataAccessLayer
{
    public class BookDAO
    {

        private BookDS _bookDataSet;
        private TabBookTableAdapter _tabBookTableAdapter;
        private ViewBookTableAdapter _viewBookTableAdapter;

        public BookDAO()
        {
            //Initialize objects
            _bookDataSet = new BookDS();
            _tabBookTableAdapter = new TabBookTableAdapter();
            _viewBookTableAdapter = new ViewBookTableAdapter();
        }

        public BookDS.TabBookDataTable GetAllBooks()
        {
            _tabBookTableAdapter.FillAllBooks(_bookDataSet.TabBook);
            return _bookDataSet.TabBook;
        }

        public BookDS.ViewBookDataTable GetAllBooksView()
        {
            _viewBookTableAdapter.FillAllBooks(_bookDataSet.ViewBook);
            return _bookDataSet.ViewBook;
        }

        public BookDS.ViewBookDataTable GetAllBooksViewByAuthorName(string authorname)
        {
            _viewBookTableAdapter.GetDataByAuthorName(authorname);
            return _bookDataSet.ViewBook;
        }

        public BookDS.ViewBookDataTable GetAllBooksViewByBookName(string bookname)
        {
            _viewBookTableAdapter.GetDataByBookName(bookname);
            return _bookDataSet.ViewBook;
        }

        public BookDS.ViewBookDataTable GetAllBooksViewByBookName(string authorname, string bookname)
        {
            _viewBookTableAdapter.GetDataByBookNameAndAuthorName(bookname ,authorname);
            return _bookDataSet.ViewBook;
        }

        public BookDS.ViewBookDataTable GetAllBooksViewByISBN(string isbn)
        {
            _viewBookTableAdapter.GetDataByISBN(isbn);
            return _bookDataSet.ViewBook;
        }
    }
}
