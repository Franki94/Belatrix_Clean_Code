namespace SOLID._02_OpenClosed
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public decimal Bonus { get { return CalculateBonus(Salary); } }

        internal abstract decimal CalculateBonus(decimal salary);        
    }
    public class PermanentEmployee : Employee
    {
        internal override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class EventualEmployee : Employee
    {
        internal override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
