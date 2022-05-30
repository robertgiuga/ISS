using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Status
    {
        pending,
        delivered,
        finish
    }
    public class Comanda: Entity<int>
    {
        public Comanda()
        {
        }

        public Comanda(int Id, string descriere, Status status)
        {
            base.Id = Id;
            Descriere = descriere;
            Status = status;
        }

        public string Descriere { get; set; }
        public Status Status { get; set; }
    }
}
