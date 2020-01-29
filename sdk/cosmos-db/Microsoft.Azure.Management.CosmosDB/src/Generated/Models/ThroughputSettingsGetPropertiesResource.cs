// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ThroughputSettingsGetPropertiesResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ThroughputSettingsGetPropertiesResource class.
        /// </summary>
        public ThroughputSettingsGetPropertiesResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ThroughputSettingsGetPropertiesResource class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput</param>
        /// <param name="minimumThroughput">The minimum throughput of the
        /// resource</param>
        /// <param name="offerReplacePending">The throughput replace is
        /// pending</param>
        /// <param name="_rid">A system generated property. A unique
        /// identifier.</param>
        /// <param name="_ts">A system generated property that denotes the last
        /// updated timestamp of the resource.</param>
        /// <param name="_etag">A system generated property representing the
        /// resource etag required for optimistic concurrency control.</param>
        public ThroughputSettingsGetPropertiesResource(int throughput, string minimumThroughput = default(string), string offerReplacePending = default(string), string _rid = default(string), object _ts = default(object), string _etag = default(string))
        {
            Throughput = throughput;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            this._rid = _rid;
            this._ts = _ts;
            this._etag = _etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int Throughput { get; set; }

        /// <summary>
        /// Gets the minimum throughput of the resource
        /// </summary>
        [JsonProperty(PropertyName = "minimumThroughput")]
        public string MinimumThroughput { get; private set; }

        /// <summary>
        /// Gets the throughput replace is pending
        /// </summary>
        [JsonProperty(PropertyName = "offerReplacePending")]
        public string OfferReplacePending { get; private set; }

        /// <summary>
        /// Gets a system generated property. A unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "_rid")]
        public string _rid { get; private set; }

        /// <summary>
        /// Gets a system generated property that denotes the last updated
        /// timestamp of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_ts")]
        public object _ts { get; private set; }

        /// <summary>
        /// Gets a system generated property representing the resource etag
        /// required for optimistic concurrency control.
        /// </summary>
        [JsonProperty(PropertyName = "_etag")]
        public string _etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}