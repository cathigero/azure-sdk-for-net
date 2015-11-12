// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes Boot Diagnostics.
    /// </summary>
    public partial class BootDiagnostics
    {
        /// <summary>
        /// Initializes a new instance of the BootDiagnostics class.
        /// </summary>
        public BootDiagnostics() { }

        /// <summary>
        /// Initializes a new instance of the BootDiagnostics class.
        /// </summary>
        public BootDiagnostics(bool? enabled = default(bool?), string storageUri = default(string))
        {
            Enabled = enabled;
            StorageUri = storageUri;
        }

        /// <summary>
        /// Gets or sets whether VM Agent should be provisioned on the Virtual
        /// Machine.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostics storage Uri. It should be a
        /// valid Uri
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; set; }

    }
}
