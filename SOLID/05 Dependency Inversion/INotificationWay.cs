using System;

namespace SOLID._05_Dependency_Inversion
{
    public interface INotificationWay
    {
        String generateWeatherAlert(String weatherConditions);
    }
}
