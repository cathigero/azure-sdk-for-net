// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store firewall rule information
    /// </summary>
    public partial class FirewallRule
    {
        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        public FirewallRule() { }

        /// <summary>
        /// Initializes a new instance of the FirewallRule class.
        /// </summary>
        /// <param name="name">the firewall rule's name.</param>
        /// <param name="type">the namespace and type of the firewall
        /// Rule.</param>
        /// <param name="id">the firewall rule's full ID.</param>
        /// <param name="properties">the properties of the firewall
        /// rule.</param>
        public FirewallRule(string name = default(string), string type = default(string), string id = default(string), FirewallRuleProperties properties = default(FirewallRuleProperties))
        {
            Name = name;
            Type = type;
            Id = id;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the firewall rule's name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the namespace and type of the firewall Rule.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the firewall rule's full ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the properties of the firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public FirewallRuleProperties Properties { get; set; }

    }
}
