using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        String currentConditions;
        INotificationWay _notificationPhone;
        INotificationWay _notificationEmail;

        public WeatherTracker()
        {
            _notificationPhone = new Phone();
            _notificationEmail = new Emailer();
        }

        public void setCurrentConditions(String weatherDescription)
        {
            this.currentConditions = weatherDescription;
            if (weatherDescription == "rainy")
            {
                String alert = _notificationPhone.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
            if (weatherDescription == "sunny")
            {
                String alert = _notificationEmail.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
        }        
    }
}
