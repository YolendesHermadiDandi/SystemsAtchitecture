using MicroservicesArchitecture.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesArchitecture.View
{
     class BookView
    {
    

        public static void BookManagementServicesMenu()
        {
            BookManagementServices BMS = new BookManagementServices();
            var isLoop = true;
            while (isLoop)
            {

                Console.WriteLine("BOOK MANAGEMENT SERVICES MENU");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Edit Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Get All Book");
                Console.WriteLine("5. Back");
                var menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("=========== INSERT BUKU ===========");
                        Console.Write("Judul : ");
                        var judul = Console.ReadLine();
                        Console.Write("Pengarang : ");
                        var pengarang = Console.ReadLine();
                        Console.Write("Nomor ISBN : ");
                        var nomorIsbn = Console.ReadLine();
                        BMS.InsertBook(judul, pengarang, nomorIsbn);
                        break;
                    case "2":
                        Console.WriteLine("=========== EDIT BUKU ===========");
                        Console.Write("Masukan id Buku : ");
                        var id = Console.ReadLine();

                        if (int.TryParse(id, out int getid) == true)
                        {
                            var result = BMS.EditBook(getid);
                            if (result == false)
                            {
                                Console.WriteLine("Buku tidak ditemukan");
                            }
                            else
                            {
                                Console.WriteLine("Buku berhasil diubah");
                            }
                        }


                        break;
                    case "3":
                        Console.WriteLine("=========== HAPUS BUKU ===========");
                        Console.Write("Masukan id Buku : ");
                        var removeId = Console.ReadLine();

                        if (int.TryParse(removeId, out int getRemoveId) == true)
                        {
                            var result = BMS.DeleteBook(getRemoveId);
                            if (result == false)
                            {
                                Console.WriteLine("Buku tidak ditemukan");
                            }
                            else
                            {
                                Console.WriteLine("Buku berhasil dihapus");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("=========== DAFTAR BUKU ===========");
                        BMS.GetAllBook();
                        break;
                    case "5":
                        isLoop = false;
                        break;
                    default:
                        break;
                }
            }



        }



    }
}
