namespace Kafkeasy.Authentication;

public interface IOAuthBearerAuthentication
{
    void SetToken(string tokenValue, long lifetimeMs, string principalName, IDictionary<string, string>? extension = null);

    void SetTokenFailure(string error);
}
