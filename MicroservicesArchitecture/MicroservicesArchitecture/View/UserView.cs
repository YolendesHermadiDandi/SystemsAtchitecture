using MicroservicesArchitecture.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesArchitecture.View
{
    internal class UserView
    {


        public static void UserManagementServicesMenu()
        {
            UserManagementServices BMS = new UserManagementServices();
            var isLoop = true;
            while (isLoop)
            {

                Console.WriteLine("USER MANAGEMENT SERVICES MENU");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Edit User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. Get All User");
                Console.WriteLine("5. Back");
                var menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("=========== INSERT USER ===========");
                        Console.Write("Nama : ");
                        var nama = Console.ReadLine();
                        Console.Write("Email : ");
                        var email = Console.ReadLine();
                        Console.Write("Nomor Keanggotaan : ");
                        var nomorKeanggotaan = Console.ReadLine();
                        BMS.InserUser(nama,email,nomorKeanggotaan);
                        break;
                    case "2":
                        Console.WriteLine("=========== EDIT BUKU ===========");
                        Console.Write("Masukan id Buku : ");
                        var id = Console.ReadLine();

                        if (int.TryParse(id, out int getid) == true)
                        {
                            var result = BMS.EditUser(getid);
                            if (result == false)
                            {
                                Console.WriteLine("User tidak ditemukan");
                            }
                            else
                            {
                                Console.WriteLine("User berhasil diubah");
                            }
                        }


                        break;
                    case "3":
                        Console.WriteLine("=========== HAPUS USER ===========");
                        Console.Write("Masukan id user : ");
                        var removeId = Console.ReadLine();

                        if (int.TryParse(removeId, out int getRemoveId) == true)
                        {
                            var result = BMS.DeleteUser(getRemoveId);
                            if (result == false)
                            {
                                Console.WriteLine("User tidak ditemukan");
                            }
                            else
                            {
                                Console.WriteLine("User berhasil dihapus");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("=========== DAFTAR BUKU ===========");
                        BMS.GetAllUser();
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
