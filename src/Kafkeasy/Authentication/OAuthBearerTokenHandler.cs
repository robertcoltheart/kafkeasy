using Confluent.Kafka;

namespace Kafkeasy.Authentication;

public readonly struct OAuthBearerTokenHandler
{
    private readonly IClient client;

    internal OAuthBearerTokenHandler(IClient client)
    {
        this.client = client;
    }

    public void SetToken(string tokenValue, long lifetimeMs, string principalName = "unspecified", IDictionary<string, string>? extension = null)
    {
        client.OAuthBearerSetToken(tokenValue, lifetimeMs, principalName, extension);
    }

    public void SetTokenFailure(string error)
    {
        client.OAuthBearerSetTokenFailure(error);
    }
}
