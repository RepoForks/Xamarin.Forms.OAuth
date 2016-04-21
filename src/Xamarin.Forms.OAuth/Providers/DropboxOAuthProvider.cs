﻿namespace Xamarin.Forms.OAuth.Providers
{
    public sealed class DropboxOAuthProvider : OAuthProvider
    {
        internal DropboxOAuthProvider(string clientId, string redirectUrl, params string[] scopes)
            : base(new OAuthProviderDefinition(
                "Dropbox",
                "https://www.dropbox.com/1/oauth2/authorize",
                null,
                null,
                "https://api.dropbox.com/1/account/info",
                clientId,
                null,
                redirectUrl,
                scopes)
            {
                AuthorizationType = AuthorizationType.Token,
                GraphIdProperty = "uid",
                GraphNameProperty = "display_name"
            })
        { }
    }
}
