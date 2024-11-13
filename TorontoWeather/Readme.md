# Title
Weather App

# Dependencies 
net8.0
NETStandard.Library (>= 2.0.3)
Newtonsoft.Json (>= 13.0.3)
System.Net.Http (>= 4.3.4)

# Release Notes (for this version)
This version only has Toronto weather.

# Description
This is a package for Toronto Weather App.


# How to use it
private readonly WeatherService _weatherService
await _weatherService.GetTorontoWeatherAsync() - This will fetch the weather data for Toronto.

# Sample output:
```sh
2024-11-12 (Tuesday): 4.4°C
2024-11-13 (Wednesday): 5.1°C
2024-11-14 (Thursday): 9°C
2024-11-15 (Friday): 6.7°C
2024-11-16 (Saturday): 10.9°C
2024-11-17 (Sunday): 9.8°C
2024-11-18 (Monday): 11.2°C
```

# Copyright
Ranish Shrestha 2024