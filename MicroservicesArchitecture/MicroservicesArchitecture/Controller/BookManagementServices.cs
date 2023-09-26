using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroservicesArchitecture.Model;

namespace MicroservicesArchitecture.Controller
{
    internal class BookManagementServices
    {
        private int _count = 0;
        private List<Book> books = new List<Book>();



        public string GetAllBook()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());

            }

            return "";
        }

        public string InsertBook(string judul, string pengarang, string nomorIsbn)
        {
            Book book = new Book();
            book.Id = ++_count;
            book.Judul = judul;
            book.Pengarang = pengarang;
            book.NomorISBN = nomorIsbn;

            books.Add(book);
            return "Buku berhasil ditambahkan";

        }

        public bool DeleteBook(int bookId)
        {

            var result = GetById(bookId);
            if (result.Id == 0)
            {
                return false;
            }

            foreach (Book book in books.ToList())
            {
                if (book.Id == bookId)
                {
                    books.Remove(book);

                }

            }


            return true;
        }

        public Book GetById(int id)
        {
            Book getBook = new Book();
            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    getBook.Id = book.Id;
                    getBook.Judul = book.Judul;
                    getBook.Pengarang = book.Pengarang;
                    getBook.NomorISBN = book.NomorISBN;
                }
            }
            return getBook;
        }

        public bool EditBook(int id)
        {

            var buku = GetById(id);

            if (buku.Id == 0)
            {
                return false;
            }
            Console.Write("Judul : ");
            var judul = Console.ReadLine();
            Console.Write("Pengarang : ");
            var pengarang = Console.ReadLine();
            Console.Write("Nomor ISBN : ");
            var nomorIsbn = Console.ReadLine();

            foreach (var book in books)
            {
                if (book.Id == id)
                {
                    book.Judul = judul == "" ? book.Judul : judul;
                    book.Pengarang = pengarang == "" ? book.Pengarang : pengarang;
                    book.NomorISBN = nomorIsbn == "" ? book.NomorISBN : nomorIsbn;

                }
            }
            return true;
        }
    }
}
