using Amazon;
using AWS.MSK.Auth;

namespace Kafkeasy.Tests;

public static class SecurityExtensions
{
    public static IKafkaClusterBuilder UseAWSIAMSecurity(this IKafkaClusterBuilder builder)
    {
        var generator = new AWSMSKAuthTokenGenerator();

        return builder
            .ConfigureSecurity(options =>
            {
                options.SaslUsername = "user";
                options.SaslPassword = "password";
                options.OAuthBearerTokenRefreshHandler = handler =>
                {
                    try
                    {
                        var (token, expiryMs) =
                            generator.GenerateAuthTokenAsync(RegionEndpoint.APSoutheast2).Result;

                        handler.SetToken(token, expiryMs);
                    }
                    catch (Exception e)
                    {
                        handler.SetTokenFailure(e.ToString());
                    }
                };
            });
    }
}
