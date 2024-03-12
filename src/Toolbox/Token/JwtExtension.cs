namespace Skarnes20.Toolbox.Token;

public static class JwtExtension
{
    public static string GetValue(this string jwt, string property)
    {
        var handler = new JwtSecurityTokenHandler();
        var token = handler.ReadJwtToken(jwt);

        var claims = token.Claims.Select(claim => (claim.Type, claim.Value)).ToList();

        return claims.FirstOrDefault(x => x.Type == property).Value;
    }

    public static List<(string Type, string Value)> GetClaims(this string jwt)
    {
        var handler = new JwtSecurityTokenHandler();
        var token = handler.ReadJwtToken(jwt);

        return token.Claims.Select(claim => (claim.Type, claim.Value)).ToList();
    }
}