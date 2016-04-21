﻿namespace Xamarin.Forms.OAuth.Providers
{
    public sealed class GoogleOAuthProvider : OAuthProvider
    {
        internal GoogleOAuthProvider(string clientId, string redirectUrl, params string[] scopes)
            : base(new OAuthProviderDefinition(
                "Google",
                "https://accounts.google.com/o/oauth2/v2/auth",
                null,
                "https://www.googleapis.com/plus/v1/people/me",
                null,
                clientId,
                null,
                redirectUrl,
                scopes)
            {
                AuthorizationType = AuthorizationType.Token,
                MandatoryScopes = new[] { "profile" },
                GraphNameProperty = "displayName"
            })
        { }
    }
}