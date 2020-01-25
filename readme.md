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

### Carbon Intensity

Most of the __national__ intensity data is returned in "Intensity" objects (CarbonIntensityUK.Models.Intensity). Containing to/from timestamps, the forecasted and actual intensity measured in gCO2/kWh. It also has a string for an index (very low, low, moderate, high, very high).

__Regional__ data is formatted a little differently. They come in either of two responses: 'Regional From-To' or 'Regional ID'. Regional ID is a response received when you request intensity data about using a location query, either a postcode, region or country. It contains some metadata about the region in the root, contains an intensity object, and a generation mix object for that region. 

### Generation Mix (Energy Mix)

Fancy way of saying how much of our energy comes from which generation source, or where it is imported from. Data is returned as "GenerationMix" objects (CarbonIntensityUK.Models.GenerationMix). The returned object has a to/from timestamp, and a GenerationMix object, containing a list of the fuel type and the percentage of energy that is generated for that given datetime range.

### Statistics

The Statistics objects return general nonspecialised data about the datetime range. An Intensity object is returned with the values for forecast, actual and index.
