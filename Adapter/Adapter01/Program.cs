

namespace Adapter01
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Employee emp = new Employee() { Name = "test", BasicSalary = 1000 };
            SalaryCalculator calculator = new SalaryCalculator();
            var salary = calculator.CalcSalary(emp);


            MachineOperator machineOperator = new MachineOperator() { Name = "machineTest", BasicSalary = 1000 };
            SalaryAdapter salaryAdapter = new SalaryAdapter();
            var machineSalary = salaryAdapter.CalcSalary(machineOperator);

            Console.WriteLine(salary);
            Console.WriteLine(machineSalary);
        }
    }
}