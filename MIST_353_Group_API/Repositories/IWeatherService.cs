﻿using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        public Task<List<Weather>> CarterProctorSPs(int WeatherID);//SPCarter1 Humidity SP
    }
}
