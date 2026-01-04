using MaaldoCom.Services.Api.Endpoints.Knowledge;

namespace Tests.Unit.Api.Endpoints.Knowledge.ListKnowledgeEndpointTests;

public class Configure
{
    [Fact]
    public void Configure_Invoked_SetsUpEndpointCorrectly()
    {
        // arrange
        var endpoint = Factory.Create<ListKnowledgeEndpoint>();

        // act
        endpoint.Configure();

        // assert
        endpoint.Definition.Verbs.ShouldHaveSingleItem();
        endpoint.Definition.Verbs.ShouldContain("GET");
        endpoint.Definition.Routes.ShouldHaveSingleItem();
        endpoint.Definition.Routes.ShouldContain(UrlMaker.KnowledgeRoute);
    }
}