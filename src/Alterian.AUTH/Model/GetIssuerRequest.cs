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
    /// GetIssuerRequest
    /// </summary>
    [DataContract(Name = "GetIssuer_request")]
    public partial class GetIssuerRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIssuerRequest" /> class.
        /// </summary>
        /// <param name="issuerId">ID of a valid Issuer..</param>
        public GetIssuerRequest(int issuerId = default(int))
        {
            this.IssuerId = issuerId;
        }

        /// <summary>
        /// ID of a valid Issuer.
        /// </summary>
        /// <value>ID of a valid Issuer.</value>
        [DataMember(Name = "IssuerId", EmitDefaultValue = false)]
        public int IssuerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetIssuerRequest {\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
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
