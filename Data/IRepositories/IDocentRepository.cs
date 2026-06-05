using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijdsexamen.Data.IRepositories
{
    public interface IDocentRepository
    {
        public List<Docent> GetDocenten();
        public Docent GetById(int id);
    }
}
