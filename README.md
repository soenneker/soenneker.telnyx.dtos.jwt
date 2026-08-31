[![](https://img.shields.io/nuget/v/soenneker.telnyx.dtos.jwt.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.dtos.jwt/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.telnyx.dtos.jwt/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.telnyx.dtos.jwt/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.telnyx.dtos.jwt.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.telnyx.dtos.jwt/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.telnyx.dtos.jwt/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.telnyx.dtos.jwt/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Telnyx.Dtos.Jwt

Maps Telnyx JWT payload claims, including `aud`, `iss`, `sub`, timestamps, token ID, type, and `tel_token`, to a serializable .NET type.

## Installation

```bash
dotnet add package Soenneker.Telnyx.Dtos.Jwt
```

## Usage

```csharp
using System.Text.Json;
using Soenneker.Telnyx.Dtos.Jwt;

TelnyxJwt? claims = JsonSerializer.Deserialize<TelnyxJwt>(verifiedPayloadJson);

DateTimeOffset expiresAt = DateTimeOffset.FromUnixTimeSeconds(claims!.Exp);
string subject = claims.Sub;
string telnyxToken = claims.TelToken;
```

This package only represents the decoded payload. It does not split JWTs, verify signatures, enforce issuer or audience, or check `exp` and `nbf`; perform those checks with a JWT validation library before trusting any property.
