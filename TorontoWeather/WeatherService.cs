using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorontoWeather
{
    /// <summary>
    /// The WeatherService class provides functionality to fetch weather information for Toronto using the Open-Meteo API.
    /// </summary>
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        // Base URL for the Open-Meteo API
        private const string BaseUrl = "https://api.open-meteo.com/v1/forecast";

        /// <summary>
        /// Initializes a new instance of the WeatherService class and creates an HttpClient instance for making HTTP requests.
        /// </summary>
        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Asynchronously retrieves the maximum daily temperature for Toronto from the Open-Meteo API.
        /// </summary>
        /// <returns>A string containing date, day, maximum temperature for seven days.</returns>
        public async Task<string> GetTorontoWeatherAsync()
        {
            // Build the URL with query parameters for latitude, longitude, and required data (daily max temperature and timezone)
            var url = $"{BaseUrl}?latitude=43.7001&longitude=-79.4163&daily=temperature_2m_max&timezone=America%2FToronto";

            // Send an asynchronous GET request to the API and retrieve the response as a string
            var response = await _httpClient.GetStringAsync(url);

            // Parse the JSON response string into a JObject for easier manipulation or data extraction
            var weatherData = JObject.Parse(response);

            // Convert the JObject to a string and return it
            // return weatherData.ToString();
            return GetTemperatureWithDays(weatherData);
        }

        /// <summary>
        /// Extracts daily maximum temperatures with corresponding days from weather data.
        /// </summary>
        /// <param name="weatherData">The weather data as a JObject.</param>
        /// <returns>A formatted string with days and corresponding maximum temperatures.</returns>
        public string GetTemperatureWithDays(JObject weatherData)
        {
            // Extract the days and daily maximum temperatures from the JSON
            var days = weatherData["daily"]["time"].ToObject<string[]>();
            var temps = weatherData["daily"]["temperature_2m_max"].ToObject<double[]>();

            // Builds a formatted string with day and corresponding temperature
            var result = "";
            for (int i = 0; i < days.Length; i++)
            {
                // Convert the date string to DateTime to get the day of the week
                var date = DateTime.Parse(days[i]);
                var dayName = date.ToString("dddd");

                result += $"{days[i]} ({dayName}): {temps[i]}°C\n";
            }

            return result;
        }
    }
}
