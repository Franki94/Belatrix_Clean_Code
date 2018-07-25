using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Presentator()
        {
            var sum = Sum(5,9);
            Console.WriteLine(string.Format("The sum is: {0} and is in range {1}", sum, NumberBetween(sum)));
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public string NumberBetween(int number)
        {
            var m = "";
            if (number > 0 && number <= 10) m = "Value between 0 and 10";
            else if (number > 10 && number <= 20) m = "Value between 11 and 20";
            else if (number > 20 && number <= 30) m = "Value between 11 and 20";
            return m;
        }
    }
}
