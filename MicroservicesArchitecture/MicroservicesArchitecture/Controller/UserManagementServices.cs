using MicroservicesArchitecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesArchitecture.Controller
{
    internal class UserManagementServices
    {
        private int _count = 0;
        private List<User> users = new List<User>();

 

        public string GetAllUser()
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());

            }

            return "";
        }

        public string InserUser(string nama, string email, string nomorKeangotaan)
        {
            User user = new User();
            user.Id = ++_count;
            user.Nama = nama;
            user.Email = email;
            user.NomorKeanggotaan = nomorKeangotaan;

            users.Add(user);
            return "User berhasil ditambahkan";

        }

        public bool DeleteUser(int userId)
        {

            var result = GetById(userId);
            if (result.Id == 0)
            {
                return false;
            }

            foreach (User user in users.ToList())
            {
                if (user.Id == userId)
                {
                    users.Remove(user);

                }

            }


            return true;
        }

        public User GetById(int id)
        {
            User getUser = new User();
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    getUser.Id = user.Id;
                    getUser.Nama = user.Nama;
                    getUser.Email = user.Email;
                    getUser.NomorKeanggotaan = user.NomorKeanggotaan;
                }
            }
            return getUser;
        }

        public bool EditUser(int id)
        {

            var user = GetById(id);

            if (user.Id == 0)
            {
                return false;
            }
            Console.Write("Nama : ");
            var nama = Console.ReadLine();
            Console.Write("Email : ");
            var email = Console.ReadLine();
            Console.Write("Nomor Keanggotaan : ");
            var nomorKeangotaan = Console.ReadLine();

            foreach (var user1 in users)
            {
                if (user1.Id == id)
                {
                    user1.Nama = nama == "" ? user1.Nama : nama;
                    user1.Email = email == "" ? user1.Email : email;
                    user1.NomorKeanggotaan = nomorKeangotaan == "" ? user1.NomorKeanggotaan : nomorKeangotaan;

                }
            }
            return true;
        }
    }
}
