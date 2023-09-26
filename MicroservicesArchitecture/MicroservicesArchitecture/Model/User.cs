using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesArchitecture.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NomorKeanggotaan { get; set; }

        public override string? ToString()
        {
            return $"Id : {Id}\nNama : {Nama}\nEmail : {Email}\nNomor Keanggotaan : {NomorKeanggotaan}";
        }
    }
}
