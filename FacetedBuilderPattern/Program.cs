using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives
                .At("Rio de Janeiro 546")
                .In("Buenos aires")
                .WithPostcode("1034")
                .Works
                .At("ITMotion")
                .AsA("Developer")
                .Earning(150000);

            Console.WriteLine(person);

            Console.ReadKey();
        }

    }
}
