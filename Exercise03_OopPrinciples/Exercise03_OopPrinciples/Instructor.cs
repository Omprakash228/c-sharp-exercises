using Exercise03_OopPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_OopPrinciples
{
    internal class Instructor : IInstructorService
    {
        private DateTime joinDate;
        private Department DepartmentName;

        public decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }

        double IInstructorService.CalculateExperience()
        {
            return (DateTime.Now - joinDate).TotalDays;
        }
    }
}
