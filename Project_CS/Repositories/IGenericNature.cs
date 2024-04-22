using Project_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS.Repositories
{
    public interface IGenericNature<T> where T : BaseNature
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T Nature);
        void AddRange(IEnumerable<T> Natures);
        void Update(T Nature);
        void Delete(int id);
    }
}
