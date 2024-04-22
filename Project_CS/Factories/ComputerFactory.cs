using Project_CS.Models;
using Project_CS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS.Factories
{
    public class ComputerFactory : IComputerFactory
    {
        public IGenericNature<T> CreateFactory<T>() where T : BaseNature
        {
            return new GenericNature<T>();
        }
    }
}
