﻿using PublicApiGenerator;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace MetaFac.Platform.UnitTests
{
    public class RegressionTests
    {
        [Fact]
        public async Task PublicApi_HasNotChanged()
        {
            // act
            var options = new ApiGeneratorOptions()
            {
                IncludeAssemblyAttributes = false
            };
            string currentApi = ApiGenerator.GeneratePublicApi(typeof(IPlatform).Assembly, options);

            // assert
            await Verifier.Verify(currentApi);
        }
    }
}