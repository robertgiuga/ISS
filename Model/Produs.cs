using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produs: Entity<int>
    {
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public int Cantitate { get; set; }
        
        public Produs(int id, string descriere, int cantitate, string denumire)
        {
            Id = id;
            Descriere = descriere;
            Cantitate = cantitate;
            Denumire = denumire;
        }
    }
}
