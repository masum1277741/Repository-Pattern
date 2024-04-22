using Project_CS.Factories;
using Project_CS.Models;
using Project_CS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CS.DITests
{
    public class TestClass
    {
        IComputerFactory factory;
        
        public TestClass(IComputerFactory factory) {  this.factory = factory; }
        public void Run()
        {
            IGenericNature<ComputerSegments> intel = factory.CreateFactory<ComputerSegments>();
            intel.AddRange(new ComputerSegments[] { 
                new ComputerSegments{ Id=1, ComputerSegment="Super-Computer"},
                new ComputerSegments{ Id=2, ComputerSegment="Mainframe-Computer"},
                new ComputerSegments{ Id=3, ComputerSegment="Mini-Computer"},
                new ComputerSegments{ Id=4, ComputerSegment="Personal-Computer(PC)"},
                new ComputerSegments{ Id=5, ComputerSegment="DigitalComputer"}
            });
            //GetAll
            Console.WriteLine("#####################GetAll######################################");
            intel.GetAll().ToList()
                .ForEach(c=> Console.WriteLine($"Gen: {c.Id}, ComputerSegment: {c.ComputerSegment}"));
            //Get by Genaration
            Console.WriteLine("###################Get by Genaration ################################");
            var cat = intel.Get(3);
            Console.WriteLine($"Gen: {cat.Id}, ComputerSegment: {cat.ComputerSegment}");
            //Update
            Console.WriteLine("#################Update############################");
            cat.ComputerSegment = "Microprocessor based";
            intel.Update(cat);
            intel.GetAll().ToList()
               .ForEach(c => Console.WriteLine($"Gen: {c.Id}, ComputerSegment: {c.ComputerSegment}"));
            //Delete
            Console.WriteLine("################Delete######################");
            intel.Delete(3);
            intel.GetAll().ToList()
              .ForEach(c => Console.WriteLine($"Gen: {c.Id}, ComputerSegment: {c.ComputerSegment}"));
            Console.WriteLine("******************");
            IGenericNature<Product> Amd = factory.CreateFactory<Product>();
            Amd.AddRange(new Product[]
            {
                    new Product{ Id=1, processorName="Core-i9", Price=7900.00M, Stock=300, Model="13900KS"},
                    new Product{ Id=2, processorName="Core-i7", Price=1790.00M, Stock=300, Model="13900K"},
                    new Product{ Id=3, processorName="Core-i5", Price=1500.00M, Stock=300, Model="13900KF"},
                    new Product{ Id=4, processorName="Core-i3", Price=1000.00M, Stock=300, Model="13900F"}
            });
            //GetAll
            Console.WriteLine("################# Get_All############################");
            Amd.GetAll().ToList()
                .ForEach(p => Console.WriteLine($"Model:{p.Model}, Name: {p.processorName}, Price: {p.Price}, Stock: {p.Stock}"));
            //Get
            Console.WriteLine("######################## Get##############################");
            var product = Amd.Get(2);
            Console.WriteLine($"Model:{product.Model}, Name: {product.processorName}, Price: {product.Price}, Stock: {product.Stock}");
            //Update
            Console.WriteLine("###########################Update##############################");
            product.Price = 1900;
            Amd.Update(product);
            Amd.GetAll().ToList()
               .ForEach(p => Console.WriteLine($"Model:{p.Model}, Name: {p.processorName}, Price: {p.Price}, Stock: {p.Stock}"));
            //Delete
            Console.WriteLine("##########################Delete#################################");
            Amd.Delete(2);
            Amd.GetAll().ToList()
               .ForEach(p => Console.WriteLine($"Model:{p.Model}, Name: {p.processorName}, Price: {p.Price}, Stock: {p.Stock}"));

        }

    }
}
