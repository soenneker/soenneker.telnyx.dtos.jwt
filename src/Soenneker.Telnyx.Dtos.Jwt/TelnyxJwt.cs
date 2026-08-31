using System.Text.Json.Serialization;

namespace Soenneker.Telnyx.Dtos.Jwt;

/// <summary>
/// Represents the claims in a decoded Telnyx JWT payload.
/// </summary>
public sealed class TelnyxJwt
{
    /// <summary>
    /// Gets or sets the audience claim.
    /// </summary>
    [JsonPropertyName("aud")]
    public string Aud { get; set; } = null!;

    /// <summary>
    /// Gets or sets the expiration time as Unix seconds.
    /// </summary>
    [JsonPropertyName("exp")]
    public long Exp { get; set; }

    /// <summary>
    /// Gets or sets the issued-at time as Unix seconds.
    /// </summary>
    [JsonPropertyName("iat")]
    public long Iat { get; set; }

    /// <summary>
    /// Gets or sets the issuer claim.
    /// </summary>
    [JsonPropertyName("iss")]
    public string Iss { get; set; } = null!;

    /// <summary>
    /// Gets or sets the token identifier.
    /// </summary>
    [JsonPropertyName("jti")]
    public string Jti { get; set; } = null!;

    /// <summary>
    /// Gets or sets the not-before time as Unix seconds.
    /// </summary>
    [JsonPropertyName("nbf")]
    public long Nbf { get; set; }

    /// <summary>
    /// Gets or sets the subject claim.
    /// </summary>
    [JsonPropertyName("sub")]
    public string Sub { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Telnyx-specific token claim.
    /// </summary>
    [JsonPropertyName("tel_token")]
    public string TelToken { get; set; } = null!;

    /// <summary>
    /// Gets or sets the token type claim.
    /// </summary>
    [JsonPropertyName("typ")]
    public string Typ { get; set; } = null!;
}
