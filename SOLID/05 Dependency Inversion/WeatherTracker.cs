using System;

namespace SOLID._05_Dependency_Inversion
{
    public abstract class WeatherTracker
    {
        public readonly INotificationWay _notificationWay;

        public WeatherTracker(INotificationWay notificationWay)
        {
            _notificationWay = notificationWay;
        }
        public abstract void SetCurrentConditions(String weatherDescription);
    }
    public class WeatherTrackerSunny : WeatherTracker
    {

        public WeatherTrackerSunny(Emailer emailer) : base ( emailer)
        {
        }

        public override void SetCurrentConditions(String weatherDescription)
        {            
                String alert = _notificationWay.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);            
        }        
    }

    public class WeatherTrackerRainy : WeatherTracker
    {
        public WeatherTrackerRainy(Phone phone) : base(phone)
        {
        }
        public override void SetCurrentConditions(String weatherDescription)
        {
            String alert = _notificationWay.generateWeatherAlert(weatherDescription);
            Console.WriteLine(alert);
        }
    }
}
