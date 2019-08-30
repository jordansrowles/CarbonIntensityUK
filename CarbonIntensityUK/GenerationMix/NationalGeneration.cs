﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarbonIntensityUK.GenerationMix
{
    public static class NationalGeneration
    {
        public static async Task<List<GenerationMixResponse>> Get()
        {
            var json = await ApiClient.QueryAsync("https://api.carbonintensity.org.uk/generation/");
            return ApiClient.AttemptConvert<List<GenerationMixResponse>>(json);
        }
    }
}