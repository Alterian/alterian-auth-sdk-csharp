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
    /// SetEMServiceURLRequest
    /// </summary>
    [DataContract(Name = "SetEMServiceURL_request")]
    public partial class SetEMServiceURLRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetEMServiceURLRequest" /> class.
        /// </summary>
        /// <param name="eMServiceURL">New EM service URL.</param>
        public SetEMServiceURLRequest(string eMServiceURL = default(string))
        {
            this.EMServiceURL = eMServiceURL;
        }

        /// <summary>
        /// New EM service URL
        /// </summary>
        /// <value>New EM service URL</value>
        [DataMember(Name = "EMServiceURL", EmitDefaultValue = false)]
        public string EMServiceURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SetEMServiceURLRequest {\n");
            sb.Append("  EMServiceURL: ").Append(EMServiceURL).Append("\n");
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
