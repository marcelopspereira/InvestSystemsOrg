// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace InvSys.Companies.Api.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class PageCompany
    {
        /// <summary>
        /// Initializes a new instance of the PageCompany class.
        /// </summary>
        public PageCompany() { }

        /// <summary>
        /// Initializes a new instance of the PageCompany class.
        /// </summary>
        public PageCompany(IList<Company> items = default(IList<Company>), int? itemsCount = default(int?), int? totalPages = default(int?), int? totalItemsCount = default(int?), int? currentPage = default(int?), int? itemsPerPage = default(int?))
        {
            Items = items;
            ItemsCount = itemsCount;
            TotalPages = totalPages;
            TotalItemsCount = totalItemsCount;
            CurrentPage = currentPage;
            ItemsPerPage = itemsPerPage;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<Company> Items { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsCount")]
        public int? ItemsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalPages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalItemsCount")]
        public int? TotalItemsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentPage")]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsPerPage")]
        public int? ItemsPerPage { get; set; }

    }
}