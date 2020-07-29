// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A WebLinkedService that uses client certificate based authentication to communicate with an HTTP endpoint. This scheme follows mutual authentication; the server must also provide valid credentials to the client. </summary>
    public partial class WebClientCertificateAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebClientCertificateAuthentication. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="pfx"> Base64-encoded contents of a PFX file. </param>
        /// <param name="password"> Password for the PFX file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/>, <paramref name="pfx"/>, or <paramref name="password"/> is null. </exception>
        public WebClientCertificateAuthentication(object url, SecretBase pfx, SecretBase password) : base(url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (pfx == null)
            {
                throw new ArgumentNullException(nameof(pfx));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Pfx = pfx;
            Password = password;
            AuthenticationType = WebAuthenticationType.ClientCertificate;
        }

        /// <summary> Initializes a new instance of WebClientCertificateAuthentication. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="pfx"> Base64-encoded contents of a PFX file. </param>
        /// <param name="password"> Password for the PFX file. </param>
        internal WebClientCertificateAuthentication(object url, WebAuthenticationType authenticationType, SecretBase pfx, SecretBase password) : base(url, authenticationType)
        {
            Pfx = pfx;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary> Base64-encoded contents of a PFX file. </summary>
        public SecretBase Pfx { get; set; }
        /// <summary> Password for the PFX file. </summary>
        public SecretBase Password { get; set; }
    }
}
