using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter01
{
    public class SalaryAdapter: SalaryCalculator
    {
        private Employee _emp;
        public SalaryAdapter()
        {
            _emp = new Employee();
        }
        public double CalcSalary(MachineOperator _operator) {
            _emp.BasicSalary = _operator.BasicSalary;
            return base.CalcSalary(_emp);
        }
    }
}