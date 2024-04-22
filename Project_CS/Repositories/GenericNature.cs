using Project_CS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_CS.Repositories
{
    public class GenericNature<T> : IGenericNature<T> where T : BaseNature
    {
        private readonly IList<T> data;
        public GenericNature() { 
            this.data = new List<T>();
        }
        public List<T> GetAll()
        {
            return this.data.ToList();
        }
        public T Get(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }
        public void Add(T Nature)
        {
            this.data.Add(Nature);
        }
        public void AddRange(IEnumerable<T> Natures)
        {
            foreach(var Nature in Natures)
            {
                this.data.Add(Nature);
            }
        }
        public void Update(T Nature)
        {
            int i = this.data.IndexOf(Nature);
            this.data.RemoveAt(i);
            this.data.Add(Nature);
        }
        public void Delete(int id)
        {
            var Nature = this.data.FirstOrDefault(x => x.Id == id);
            if(Nature != null)
            {
                this.data.Remove(Nature);
            }
        }        
    }
}
