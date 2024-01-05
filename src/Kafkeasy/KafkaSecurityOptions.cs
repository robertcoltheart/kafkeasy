using Kafkeasy.Authentication;

namespace Kafkeasy;

public class KafkaSecurityOptions
{
    public string SaslUsername { get; set; }

    public string SaslPassword { get; set; }

    public Action<IOAuthBearerAuthentication> OAuthBearerTokenRefreshHandler { get; set; }
}
