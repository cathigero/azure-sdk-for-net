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
    /// Describes Windows Configuration of the OS Profile.
    /// </summary>
    public partial class WindowsConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WindowsConfiguration class.
        /// </summary>
        public WindowsConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the WindowsConfiguration class.
        /// </summary>
        public WindowsConfiguration(bool? provisionVMAgent = default(bool?), bool? enableAutomaticUpdates = default(bool?), string timeZone = default(string), IList<AdditionalUnattendContent> additionalUnattendContent = default(IList<AdditionalUnattendContent>), WinRMConfiguration winRM = default(WinRMConfiguration))
        {
            ProvisionVMAgent = provisionVMAgent;
            EnableAutomaticUpdates = enableAutomaticUpdates;
            TimeZone = timeZone;
            AdditionalUnattendContent = additionalUnattendContent;
            WinRM = winRM;
        }

        /// <summary>
        /// Gets or sets whether VM Agent should be provisioned on the Virtual
        /// Machine.
        /// </summary>
        [JsonProperty(PropertyName = "provisionVMAgent")]
        public bool? ProvisionVMAgent { get; set; }

        /// <summary>
        /// Gets or sets whether Windows updates are automatically installed
        /// on the VM
        /// </summary>
        [JsonProperty(PropertyName = "enableAutomaticUpdates")]
        public bool? EnableAutomaticUpdates { get; set; }

        /// <summary>
        /// Gets or sets the Time Zone of the VM
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the additional base-64 encoded XML formatted
        /// information that can be included in the Unattend.xml file.
        /// </summary>
        [JsonProperty(PropertyName = "additionalUnattendContent")]
        public IList<AdditionalUnattendContent> AdditionalUnattendContent { get; set; }

        /// <summary>
        /// Gets or sets the Windows Remote Management configuration of the VM
        /// </summary>
        [JsonProperty(PropertyName = "winRM")]
        public WinRMConfiguration WinRM { get; set; }

    }
}
