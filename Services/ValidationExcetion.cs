using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ValidationExcetion : Exception
    {
        public ValidationExcetion(string message) : base(message)
        {
        }

    }
}
