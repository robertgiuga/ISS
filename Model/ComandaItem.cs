using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ComandaItem: Entity<int>
    {
        public ComandaItem(int Id, int cantitate)
        {
            base.Id = Id;
            Cantitate = cantitate;
        }

        [Browsable(false)]
        public int ComandaId { get; set; }
        public int Cantitate { get; set; }
    }
}
