using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(DateRange dateRange, Location location, int? customerId = null)
        {
            if (dateRange.dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(DateRange dateRange,User user, Location location)
        {
            if (dateRange.dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.dateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.dateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }
    public class DateRange
    {
        public DateTime dateFrom { get; set; }
        public DateTime dateTo { get; set; }
    }
    public class Location
    {
        public User user { get; set; }
        public int locationId { get; set; }
        public LocationType locationType { get; set; }
    }
    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
