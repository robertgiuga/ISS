using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Entity<T>
    {
        public T Id { get; set; }

        public Entity()
        {

        }

        public Entity(T id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return obj is Entity<T> entiy &&
                   EqualityComparer<T>.Default.Equals(Id, entiy.Id);
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<T>.Default.GetHashCode(Id);
        }
    }
}
