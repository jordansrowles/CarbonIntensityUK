# UK Carbon Intensity
.NET wrapper around the British Carbon Intensity API provided by the National Grid. Provides real-time and calculated (+48 hour forecast) of CO2 carbon emissions relating to electricity generation.

[Carbon Intensity Website](https://carbonintensity.org.uk/)

[Carbon Intensity API docs](https://carbon-intensity.github.io/api-definitions/)

[Carbon Intensity API Endpoint](https://api.carbonintensity.org.uk/)


| Method                  | API                             | Description                           |
|-------------------------|---------------------------------|---------------------------------------|
| GetCurrent()            | /intensity                      | Get data for current half hour        |
| GetToday()              | /intensity/date                 | Get data for today                    |
| GetDate(s)              | /intensity/date/{date}          | Get data for specific day             |
| GetDate(s,s)            | /intensity/date/{date}/{period} | Get data for specific period in day   |
| GetFactors()            | /intensity/factors              | Get factors for fuel types            |
| GetFrom(s)              | /intensity/{from}               | Get from specific datetime            |
| GetFromFoward24Hour(s)  | /intensity/{from}/fw24h         | Get data 24 hour forecast             |
| GetFromForward48Hour(s) | /intensity/{from}/fw48h         | Get data 48 hour forecast             |
| GetFromPast24Hour(s)    | /intensity/{from}/pt24h         | Get past 24 hours of datetime         |
| GetFromRange(s)         | /intensity/{from}/{to}          | Get data between to and from datetime |

Most methods have these variants:
- Base, Json, Dynamic
- BaseAsync, JsonAsync, DynamicAsync












