using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Together.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class TogetherOpenApiClientRunnerTests : FixturedUnitTest
{
    public TogetherOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
