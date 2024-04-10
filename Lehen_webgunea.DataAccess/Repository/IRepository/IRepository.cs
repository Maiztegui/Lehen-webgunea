using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehen_webgunea.DataAccess.Repository.IRepository
{
    internal interface IRepository<T> where T : class
    {
        // T- Category
        IEnumerable<T> GetAll();

    }
}
