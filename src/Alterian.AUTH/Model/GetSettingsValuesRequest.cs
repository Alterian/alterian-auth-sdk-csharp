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
    /// GetSettingsValuesRequest
    /// </summary>
    [DataContract(Name = "GetSettingsValues_request")]
    public partial class GetSettingsValuesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsValuesRequest" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="issuerId">Issuer Id the Setting Applies to.</param>
        /// <param name="loginId">Login Id the Setting Applies to.</param>
        /// <param name="settingIds">List of setting Ids.</param>
        /// <param name="siteId">Site Id the Setting Applies to.</param>
        public GetSettingsValuesRequest(APICursor cursor = default(APICursor), int? issuerId = default(int?), Guid? loginId = default(Guid?), List<int> settingIds = default(List<int>), int? siteId = default(int?))
        {
            this.Cursor = cursor;
            this.IssuerId = issuerId;
            this.LoginId = loginId;
            this.SettingIds = settingIds;
            this.SiteId = siteId;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APICursor Cursor { get; set; }

        /// <summary>
        /// Issuer Id the Setting Applies to
        /// </summary>
        /// <value>Issuer Id the Setting Applies to</value>
        [DataMember(Name = "IssuerId", EmitDefaultValue = true)]
        public int? IssuerId { get; set; }

        /// <summary>
        /// Login Id the Setting Applies to
        /// </summary>
        /// <value>Login Id the Setting Applies to</value>
        [DataMember(Name = "LoginId", EmitDefaultValue = true)]
        public Guid? LoginId { get; set; }

        /// <summary>
        /// List of setting Ids
        /// </summary>
        /// <value>List of setting Ids</value>
        [DataMember(Name = "SettingIds", EmitDefaultValue = false)]
        public List<int> SettingIds { get; set; }

        /// <summary>
        /// Site Id the Setting Applies to
        /// </summary>
        /// <value>Site Id the Setting Applies to</value>
        [DataMember(Name = "SiteId", EmitDefaultValue = true)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSettingsValuesRequest {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  SettingIds: ").Append(SettingIds).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
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
