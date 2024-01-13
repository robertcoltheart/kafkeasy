using Amazon;
using AWS.MSK.Auth;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Kafkeasy.Tests;

public class Framework
{
    [Fact]
    public void Test()
    {
        var services = new ServiceCollection();

        var generator = new AWSMSKAuthTokenGenerator();

        services.AddKafka(builder =>
        {
            builder.AddCluster(cluster =>
            {
                cluster.ConfigureSecurity(options =>
                {
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
            });
        });
    }
}
