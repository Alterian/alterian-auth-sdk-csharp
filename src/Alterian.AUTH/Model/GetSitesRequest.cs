/*
 * Authentication API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 6.35.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Alterian.AUTH.Client.OpenAPIDateConverter;

namespace Alterian.AUTH.Model
{
    /// <summary>
    /// GetSitesRequest
    /// </summary>
    [DataContract(Name = "GetSites_request")]
    public partial class GetSitesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSitesRequest" /> class.
        /// </summary>
        /// <param name="siteTypeId">Optionally filter to a specific site type, use @see(GetSiteTypes) to obtain a list of acceptable parameters.</param>
        public GetSitesRequest(int? siteTypeId = default(int?))
        {
            this.SiteTypeId = siteTypeId;
        }

        /// <summary>
        /// Optionally filter to a specific site type, use @see(GetSiteTypes) to obtain a list of acceptable parameters
        /// </summary>
        /// <value>Optionally filter to a specific site type, use @see(GetSiteTypes) to obtain a list of acceptable parameters</value>
        [DataMember(Name = "SiteTypeId", EmitDefaultValue = true)]
        public int? SiteTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSitesRequest {\n");
            sb.Append("  SiteTypeId: ").Append(SiteTypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}