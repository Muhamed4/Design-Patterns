using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter01
{
    public class SalaryCalculator
    {
        public double CalcSalary(Employee employee) => employee.BasicSalary * 1.5;
    }
}