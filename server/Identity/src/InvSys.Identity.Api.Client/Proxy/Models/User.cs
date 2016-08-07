// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace InvSys.Identity.Api.Client.Proxy.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class User
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User(bool? isProfessionalInvestor = default(bool?), string id = default(string), string userName = default(string), string normalizedUserName = default(string), string email = default(string), string normalizedEmail = default(string), bool? emailConfirmed = default(bool?), string passwordHash = default(string), string securityStamp = default(string), string concurrencyStamp = default(string), string phoneNumber = default(string), bool? phoneNumberConfirmed = default(bool?), bool? twoFactorEnabled = default(bool?), DateTime? lockoutEnd = default(DateTime?), bool? lockoutEnabled = default(bool?), int? accessFailedCount = default(int?), IList<IdentityUserRoleString> roles = default(IList<IdentityUserRoleString>), IList<IdentityUserClaimString> claims = default(IList<IdentityUserClaimString>), IList<IdentityUserLoginString> logins = default(IList<IdentityUserLoginString>))
        {
            IsProfessionalInvestor = isProfessionalInvestor;
            Id = id;
            UserName = userName;
            NormalizedUserName = normalizedUserName;
            Email = email;
            NormalizedEmail = normalizedEmail;
            EmailConfirmed = emailConfirmed;
            PasswordHash = passwordHash;
            SecurityStamp = securityStamp;
            ConcurrencyStamp = concurrencyStamp;
            PhoneNumber = phoneNumber;
            PhoneNumberConfirmed = phoneNumberConfirmed;
            TwoFactorEnabled = twoFactorEnabled;
            LockoutEnd = lockoutEnd;
            LockoutEnabled = lockoutEnabled;
            AccessFailedCount = accessFailedCount;
            Roles = roles;
            Claims = claims;
            Logins = logins;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isProfessionalInvestor")]
        public bool? IsProfessionalInvestor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedUserName")]
        public string NormalizedUserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "normalizedEmail")]
        public string NormalizedEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailConfirmed")]
        public bool? EmailConfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "securityStamp")]
        public string SecurityStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "concurrencyStamp")]
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumberConfirmed")]
        public bool? PhoneNumberConfirmed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "twoFactorEnabled")]
        public bool? TwoFactorEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockoutEnd")]
        public DateTime? LockoutEnd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockoutEnabled")]
        public bool? LockoutEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessFailedCount")]
        public int? AccessFailedCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<IdentityUserRoleString> Roles { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claims")]
        public IList<IdentityUserClaimString> Claims { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logins")]
        public IList<IdentityUserLoginString> Logins { get; private set; }

    }
}
