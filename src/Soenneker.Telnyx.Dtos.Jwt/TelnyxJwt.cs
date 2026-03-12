using System.Text.Json.Serialization;

namespace Soenneker.Telnyx.Dtos.Jwt;

/// <summary>
/// A Telnyx JWT payload in DTO form
/// </summary>
public sealed class TelnyxJwt
{
    [JsonPropertyName("aud")]
    public string Aud { get; set; } = null!;

    [JsonPropertyName("exp")]
    public long Exp { get; set; }

    [JsonPropertyName("iat")]
    public long Iat { get; set; }

    [JsonPropertyName("iss")]
    public string Iss { get; set; } = null!;

    [JsonPropertyName("jti")]
    public string Jti { get; set; } = null!;

    [JsonPropertyName("nbf")]
    public long Nbf { get; set; }

    [JsonPropertyName("sub")]
    public string Sub { get; set; } = null!;

    [JsonPropertyName("tel_token")]
    public string TelToken { get; set; } = null!;

    [JsonPropertyName("typ")]
    public string Typ { get; set; } = null!;
}
