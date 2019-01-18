// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Tag count.
    /// </summary>
    public partial class TagCount
    {
        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        public TagCount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagCount class.
        /// </summary>
        /// <param name="type">Type of count.</param>
        /// <param name="value">Value of count.</param>
        public TagCount(string type = default(string), int? value = default(int?))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of count.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets value of count.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int? Value { get; set; }

    }
}