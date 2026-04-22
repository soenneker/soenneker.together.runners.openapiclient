using Soenneker.Tests.HostedUnit;

namespace Soenneker.Together.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TogetherOpenApiClientRunnerTests : HostedUnitTest
{
    public TogetherOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
