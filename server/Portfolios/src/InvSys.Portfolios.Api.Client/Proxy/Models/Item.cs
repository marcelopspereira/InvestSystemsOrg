// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace InvSys.Portfolios.Api.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Item
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item() { }

        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item(Guid? id = default(Guid?), Guid? companyId = default(Guid?), string companySymbol = default(string))
        {
            Id = id;
            CompanyId = companyId;
            CompanySymbol = companySymbol;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "companyId")]
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "companySymbol")]
        public string CompanySymbol { get; set; }

    }
}
