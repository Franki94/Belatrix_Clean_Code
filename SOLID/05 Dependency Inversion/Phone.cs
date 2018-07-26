using System;

namespace SOLID._05_Dependency_Inversion
{
    public class Phone : INotificationWay
    {
        public String generateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }
}
