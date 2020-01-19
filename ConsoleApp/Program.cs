using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CarbonIntensityUK.Controllers;
using CarbonIntensityUK.Models;

namespace ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await RegionalIntensity.Get(
                IntensityURIOption.pt24h,
                new DateTime(2019, 01, 01));
            Console.ReadLine();
        }

    }
}

