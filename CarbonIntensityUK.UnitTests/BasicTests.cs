using System;
using System.Threading.Tasks;
using CarbonIntensityUK.Models;
using Xunit;

namespace CarbonIntensityUK.UnitTests
{
    public static class Basics
    {
        public static class NationalIntensityTests
        {
            [Fact]
            public static async Task Test_Get()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get()));
                Assert.Null(result);
            }

            [Fact]
            public static async Task Test_Factors()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Factors()));
                Assert.Null(result);
            }

            [Fact]
            public static async Task Test_GetToday()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.GetToday()));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_WithVar()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(DateTime.Now)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Range()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(
                        new DateTime(2019, 01, 01),  
                        new DateTime(2019, 01, 02))));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Period()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(
                        new DateTime(2019, 01, 01),
                        3)));
                Assert.Null(result);
            }
            
            [Fact] 
            public static async Task Test_Get_Period_ArgumentOutOfRangeException()
            {
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => 
                    await Controllers.NationalIntensity.Get(
                    new DateTime(2019, 01, 01),
                    50));
            }
            
            [Fact]
            public static async Task Test_GetByDateTime()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.GetByDateTime(DateTime.Now)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Past24Hour()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(
                        new DateTime(2019, 01, 01),
                        IntensityUriOption.Pt24H)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Forward24Hour()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(
                        new DateTime(2019, 01, 01),
                        IntensityUriOption.Fw24H)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Forward48Hour()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalIntensity.Get(
                        new DateTime(2019, 01, 01),
                        IntensityUriOption.Fw48H)));
                Assert.Null(result);
            }
        }

        public static class NationalStatisticTests
        {
            [Fact]
            public static async Task Test_Get()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalStatistics.Get(
                        new DateTime(2019, 01, 01),
                        new DateTime(2019, 01, 02))));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Block()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalStatistics.Get(
                        new DateTime(2019, 01, 01),
                        new DateTime(2019, 01, 02),
                        24)));
                Assert.Null(result);
            }
            
            [Fact] 
            public static async Task Test_Get_Block_ArgumentOutOfRangeException()
            {
                await Assert.ThrowsAsync<ArgumentOutOfRangeException>(async () => 
                    await Controllers.NationalStatistics.Get(
                        new DateTime(2019, 01, 01),
                        new DateTime(2019, 01, 02),
                        35));
            }
        }

        public static class NationalGenerationTests
        {
            [Fact]
            public static async Task Test_Get()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalGeneration.Get()));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Date()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalGeneration.Get(
                        new DateTime(2019, 01, 01))));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Range()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.NationalGeneration.Get(
                        new DateTime(2019, 01, 01),
                        new DateTime(2019, 01, 02))));
                Assert.Null(result);
            }
        }

        public static class RegionalIntensityTests
        {
            [Fact]
            public static async Task Test_Get()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get()));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Postcode()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get("MK1")));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Country()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(Country.England)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Region()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(RegionIDs.EastEngland)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_From_Past24Hours()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        IntensityUriOption.Pt24H,
                        new DateTime(2019, 01, 01))));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_From_Past24Hours_Postcode()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        IntensityUriOption.Pt24H,
                        new DateTime(2019, 01, 01),
                        "MK1")));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_From_Past24Hours_Region()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        IntensityUriOption.Pt24H,
                        new DateTime(2019, 01, 01),
                        RegionIDs.EastEngland)));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Range()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        new DateTime(2019,01,01),
                        new DateTime(2019, 01, 02))));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Range_Postcode()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        new DateTime(2019,01,01),
                        new DateTime(2019, 01, 02),
                        "MK1")));
                Assert.Null(result);
            }
            
            [Fact]
            public static async Task Test_Get_Range_Region()
            {
                var result = await Record.ExceptionAsync((async () =>
                    await Controllers.RegionalIntensity.Get(
                        new DateTime(2019,01,01),
                        new DateTime(2019, 01, 02),
                        RegionIDs.EastEngland)));
                Assert.Null(result);
            }
        }
    }
}