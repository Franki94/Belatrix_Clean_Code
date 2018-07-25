using System;

namespace SOLID._03_Liskov_substitution
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format($"ID : {ID} Name : {Name}");
        }
    }  
    public class PermanentEmployee : Employee , IEmployeeWithBonus
    {
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee, IEmployeeWithBonus
    {
        public  decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractEmployee : Employee
    {
      
    }

    public interface IEmployeeWithBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
