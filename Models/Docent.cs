using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijdsexamen.Models
{
    public class Docent: Persoon
    {
        public override bool Equals(object? obj)
        {
            return obj is Docent d && d.Id == Id;
        }
    }
}
