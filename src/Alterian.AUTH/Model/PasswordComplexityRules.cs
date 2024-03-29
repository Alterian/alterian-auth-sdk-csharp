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
    /// PasswordComplexityRules
    /// </summary>
    [DataContract(Name = "PasswordComplexityRules")]
    public partial class PasswordComplexityRules : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordComplexityRules" /> class.
        /// </summary>
        /// <param name="minimumLength">Total minimum length of password.</param>
        /// <param name="numChars">Minimum number of non-numeric, non-special characters.</param>
        /// <param name="numNumeric">Minimum number of numeric values in password.</param>
        /// <param name="numSpecial">Minimum number of special characters in password (special characters include %[&#x60;!@#$%&amp;*()_&#x3D;+\\|{};\&quot;,/]).</param>
        /// <param name="requireMixedCase">Are Upper and Lower case characters required.</param>
        /// <param name="passwordReuse">Can the password be changed to a previously used value.</param>
        public PasswordComplexityRules(byte[] minimumLength = default(byte[]), byte[] numChars = default(byte[]), byte[] numNumeric = default(byte[]), byte[] numSpecial = default(byte[]), bool requireMixedCase = default(bool), byte[] passwordReuse = default(byte[]))
        {
            this.MinimumLength = minimumLength;
            this.NumChars = numChars;
            this.NumNumeric = numNumeric;
            this.NumSpecial = numSpecial;
            this.RequireMixedCase = requireMixedCase;
            this.PasswordReuse = passwordReuse;
        }

        /// <summary>
        /// Total minimum length of password
        /// </summary>
        /// <value>Total minimum length of password</value>
        [DataMember(Name = "MinimumLength", EmitDefaultValue = false)]
        public byte[] MinimumLength { get; set; }

        /// <summary>
        /// Minimum number of non-numeric, non-special characters
        /// </summary>
        /// <value>Minimum number of non-numeric, non-special characters</value>
        [DataMember(Name = "NumChars", EmitDefaultValue = false)]
        public byte[] NumChars { get; set; }

        /// <summary>
        /// Minimum number of numeric values in password
        /// </summary>
        /// <value>Minimum number of numeric values in password</value>
        [DataMember(Name = "NumNumeric", EmitDefaultValue = false)]
        public byte[] NumNumeric { get; set; }

        /// <summary>
        /// Minimum number of special characters in password (special characters include %[&#x60;!@#$%&amp;*()_&#x3D;+\\|{};\&quot;,/])
        /// </summary>
        /// <value>Minimum number of special characters in password (special characters include %[&#x60;!@#$%&amp;*()_&#x3D;+\\|{};\&quot;,/])</value>
        [DataMember(Name = "NumSpecial", EmitDefaultValue = false)]
        public byte[] NumSpecial { get; set; }

        /// <summary>
        /// Are Upper and Lower case characters required
        /// </summary>
        /// <value>Are Upper and Lower case characters required</value>
        [DataMember(Name = "RequireMixedCase", EmitDefaultValue = true)]
        public bool RequireMixedCase { get; set; }

        /// <summary>
        /// Can the password be changed to a previously used value
        /// </summary>
        /// <value>Can the password be changed to a previously used value</value>
        [DataMember(Name = "PasswordReuse", EmitDefaultValue = false)]
        public byte[] PasswordReuse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordComplexityRules {\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  NumChars: ").Append(NumChars).Append("\n");
            sb.Append("  NumNumeric: ").Append(NumNumeric).Append("\n");
            sb.Append("  NumSpecial: ").Append(NumSpecial).Append("\n");
            sb.Append("  RequireMixedCase: ").Append(RequireMixedCase).Append("\n");
            sb.Append("  PasswordReuse: ").Append(PasswordReuse).Append("\n");
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
