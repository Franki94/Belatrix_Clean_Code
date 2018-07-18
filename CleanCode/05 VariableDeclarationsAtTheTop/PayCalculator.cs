
namespace CleanCode.VariableDeclarationsAtTheTop
{
    public class PayCalculator
    {
        private PayFrequency _payFrequency;

        public PayCalculator(PayFrequency payFrequency)
        {
            _payFrequency = payFrequency;
        }

        public decimal CalcGross(decimal rate, decimal hours)
        {
            var hoursWorked = CalcHoursWorkedByFrecuency(hours);
            var regularPay = (hoursWorked.RegularHours * rate);

            if (hoursWorked.OverTimeHours <= 0m) return hoursWorked.RegularHours * rate;

            var overtimePay = (rate * 1.5m) * hoursWorked.OverTimeHours;
            return regularPay + overtimePay;
        }

        private HoursWorked CalcHoursWorkedByFrecuency(decimal hours)
        {
            if (_payFrequency == PayFrequency.Fortnightly) return CalcHourWorked((int)Hours.Fortnightly, hours);

            else return CalcHourWorked((int)Hours.Weekly, hours);
        }

        private HoursWorked CalcHourWorked(int hoursEstimate, decimal hours)
        {
            if (hours < hoursEstimate) return new HoursWorked { RegularHours = hours };

            return new HoursWorked { OverTimeHours = hours - hoursEstimate, RegularHours = hoursEstimate };
        }

        public class HoursWorked
        {
            public decimal OverTimeHours { get; set; }
            public decimal RegularHours { get; set; }
        }
        public enum PayFrequency
        {
            Weekly,
            Fortnightly
        }
        public enum Hours
        {
            Fortnightly = 80,
            Weekly = 40
        }

    }
}
