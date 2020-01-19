![AppVeyor](https://img.shields.io/appveyor/ci/jordansrowles/carbonintensityuk?style=flat-square)
[![NuGet (CarbonIntensityUK)](https://img.shields.io/nuget/v/carbonintensityuk.svg?style=flat-square)](https://www.nuget.org/packages/CarbonIntensityUK/)


# UK Carbon Intensity
.NET wrapper around the British Carbon Intensity API provided by the National Grid. Provides real-time and calculated (+48 hour forecast) of CO2 carbon emissions relating to electricity generation.

> The Carbon Intensity API uses state-of-the-art Machine Learning and sophisticated power system modelling to forecast the carbon intensity and generation mix 96+ hours ahead for each region in Great Britain. 
>Our OpenAPI allows consumers and smart devices to schedule and minimise CO2 emissions at a local level

[Website](https://carbonintensity.org.uk/)
 | [Docs](https://carbon-intensity.github.io/api-definitions/)
 | [Endpoint](https://api.carbonintensity.org.uk/)


---------------------

### NationalGeneration
Factors of emissions, represented with a percentage. 
### NationalIntensity
Provides emission factors and intensity for GB. 
### NationalStatistics
Provides GB intensity statistics. Includes the minimum, maximum, and average co2 levels between two dates, and provides an index to represent that. 
### RegionalIntensity
Provides intensity statistics for specific regions of Great Britian, including all regions in a specified country: England, Scotland or Wales. 


