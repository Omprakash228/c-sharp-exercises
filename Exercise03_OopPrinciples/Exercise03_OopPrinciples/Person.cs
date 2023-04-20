using Exercise03_OopPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_OopPrinciples
{
    internal class Person : IPersonService
    {
        public int Age;
        public List<string> Address;

        public decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
