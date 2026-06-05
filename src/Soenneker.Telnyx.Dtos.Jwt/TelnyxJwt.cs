using System.Text.Json.Serialization;

namespace Soenneker.Telnyx.Dtos.Jwt;

/// <summary>
/// A Telnyx JWT payload in DTO form
/// </summary>
public sealed class TelnyxJwt
{
    /// <summary>
    /// Gets or sets aud.
    /// </summary>
    [JsonPropertyName("aud")]
    public string Aud { get; set; } = null!;

    /// <summary>
    /// Gets or sets exp.
    /// </summary>
    [JsonPropertyName("exp")]
    public long Exp { get; set; }

    /// <summary>
    /// Gets or sets iat.
    /// </summary>
    [JsonPropertyName("iat")]
    public long Iat { get; set; }

    /// <summary>
    /// Gets or sets iss.
    /// </summary>
    [JsonPropertyName("iss")]
    public string Iss { get; set; } = null!;

    /// <summary>
    /// Gets or sets jti.
    /// </summary>
    [JsonPropertyName("jti")]
    public string Jti { get; set; } = null!;

    /// <summary>
    /// Gets or sets nbf.
    /// </summary>
    [JsonPropertyName("nbf")]
    public long Nbf { get; set; }

    /// <summary>
    /// Gets or sets sub.
    /// </summary>
    [JsonPropertyName("sub")]
    public string Sub { get; set; } = null!;

    /// <summary>
    /// Gets or sets tel token.
    /// </summary>
    [JsonPropertyName("tel_token")]
    public string TelToken { get; set; } = null!;

    /// <summary>
    /// Gets or sets typ.
    /// </summary>
    [JsonPropertyName("typ")]
    public string Typ { get; set; } = null!;
}
