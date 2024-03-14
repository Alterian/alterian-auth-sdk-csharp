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
    /// ApplicationDetails
    /// </summary>
    [DataContract(Name = "ApplicationDetails")]
    public partial class ApplicationDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDetails" /> class.
        /// </summary>
        /// <param name="siteID">siteID.</param>
        /// <param name="token">token.</param>
        /// <param name="settings">settings.</param>
        public ApplicationDetails(int siteID = default(int), Guid token = default(Guid), Dictionary<string, string> settings = default(Dictionary<string, string>))
        {
            this.SiteID = siteID;
            this.Token = token;
            this.Settings = settings;
        }

        /// <summary>
        /// Gets or Sets SiteID
        /// </summary>
        [DataMember(Name = "SiteID", EmitDefaultValue = false)]
        public int SiteID { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "Token", EmitDefaultValue = false)]
        public Guid Token { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "Settings", EmitDefaultValue = false)]
        public Dictionary<string, string> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationDetails {\n");
            sb.Append("  SiteID: ").Append(SiteID).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
