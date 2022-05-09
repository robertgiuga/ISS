using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Rol
    {
        agent=0,
        admin= 1
    }

    public class Angajat : Entity<string>
    {
        public string Name { get; set; }

        public string Password { get; set; }
        public Rol Role { get; set; }
        //     public string UserName { get => base.Id; set => base.Id = value; }


        public Angajat(string name, string id, string password, Rol role)
        {
            Id = id;
            Name = name;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Role: " + Role;
        }
    }
}
