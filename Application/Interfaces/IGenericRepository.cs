using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(object id);
        Task<IEnumerable<T>> GetAll();
        Task<object> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(object id);
    }
}
