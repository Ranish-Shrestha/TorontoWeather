# Weather App for Toronto

### Package dependencies

- net8.0
- NETStandard.Library (>= 2.0.3)
- Newtonsoft.Json (>= 13.0.3)
- System.Net.Http (>= 4.3.4)

### Release Notes

In this version Json data is convert into string format which contains days with corresponding to maximum temperatures.

### Description

This is a package get weather detail for Toronto from open-meteo.

### How to use it

Define the variable for service as:

```sh
private readonly WeatherService _weatherService
```

Use method `GetTorontoWeatherAsync` to get weather data in string format.

```sh
await _weatherService.GetTorontoWeatherAsync()
```

### Sample output:

```sh
2024-11-12 (Tuesday): 4.4°C
2024-11-13 (Wednesday): 5.1°C
2024-11-14 (Thursday): 9°C
2024-11-15 (Friday): 6.7°C
2024-11-16 (Saturday): 10.9°C
2024-11-17 (Sunday): 9.8°C
2024-11-18 (Monday): 11.2°C
```

### Copyright

Ranish Shrestha 2024
