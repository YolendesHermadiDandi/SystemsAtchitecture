using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesArchitecture.Model
{
    internal class Book
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public string Pengarang { get; set; }
        public string NomorISBN { get; set; }

        public override string? ToString()
        {
            return $"Id : {Id}\nJudul : {Judul}\nPengarang : {Pengarang}\nNomor ISBN {NomorISBN}\n";
        }
    }
}
