using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CarbonIntensityUK.UnitTests
{
    public static class ValueTests
    {
        [Fact]
        public static async Task Test()
        {
            var result_class = await Controllers.NationalGeneration.Get();
            var result_value = await Controllers.NationalGeneration.GetAsValue();
        }

    }
}
