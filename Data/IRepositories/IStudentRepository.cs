using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tussentijdsexamen.Data.IRepositories
{
    public interface IStudentRepository
    {
        public List<Student> GetStudenten();
        public List<Student> GetByDocentId(int docentId);
    }
}
