using MicroservicesArchitecture.Controller;
using MicroservicesArchitecture.View;

namespace MicroservicesArchitecture;
class Program
{
    public static void Main(string[] args)
    {
        MainMenu();
    }
    public static void MainMenu()
    {
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("SILAHKAN PILIH SERVICES");
            Console.WriteLine("1. Book Management Services");
            Console.WriteLine("2. User Management Services");
            Console.WriteLine("3. Book Loan Management Services");
            Console.WriteLine("4. Exit");
            var menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    BookView.BookManagementServicesMenu();
                    break;
                case "2":
                    UserView.UserManagementServicesMenu();
                    break;
                case "3":
                    break;
                case "4":
                    isLoop = false;
                    break;
                default:
                    break;
            }

        }

    }
}

