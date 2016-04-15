﻿namespace Xamarin.Forms.OAuth.Providers
{
    public sealed class GoogleOAuthProvider : OAuthProvider
    {
        public GoogleOAuthProvider(string clientId, string redirectUrl, params string[] scopes)
            : base(clientId, redirectUrl, scopes)
        { }

        public override string Name
        {
            get
            {
                return "Google";
            }
        }

        protected override string[] MandatoryScopes
        {
            get
            {
                return new[] { "profile" };
            }
        }

        protected override string AuthoizationUrl
        {
            get
            {
                return "https://accounts.google.com/o/oauth2/v2/auth";
            }
        }

        protected override string GraphUrl
        {
            get { return "https://www.googleapis.com/plus/v1/people/me"; }
        }

        internal override string NamePropertyName
        {
            get
            {
                return "displayName";
            }
        }
    }
}