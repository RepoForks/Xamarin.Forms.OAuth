﻿namespace Xamarin.Forms.OAuth.Providers
{
    public sealed class SalesforceOAuthProvider : OAuthProvider
    {
        private const string _redirectUrl = "https://login.salesforce.com/services/oauth2/success";

        public SalesforceOAuthProvider(string clientId, string clientSecret, params string[] scopes) 
            : base(new OAuthProviderDefinition(
                "Salesforce",
                "https://login.salesforce.com/services/oauth2/authorize",
                "https://login.salesforce.com/services/oauth2/token",
                "https://login.salesforce.com/services/oauth2/userinfo",
                clientId,
                clientSecret,
                _redirectUrl,
                scopes)
            {
                AuthorizationType = AuthorizationType.Implicit,
                MandatoryScopes = new[] { "id", "openid", "refresh_token" },
                ScopeSeparator = "%20",
                RefreshesToken = true,
                TokenRequestUrlParameter = "oauth_token",
                GraphIdProperty = "user_id"
            })
        { }
    }
}
