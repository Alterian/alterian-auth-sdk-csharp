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
    /// ChangePasswordRequest
    /// </summary>
    [DataContract(Name = "ChangePassword_request")]
    public partial class ChangePasswordRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="loginId">Login Id of the password to change..</param>
        /// <param name="password">New password.  If this is a SAML or NTLM login, it can be NULL..</param>
        public ChangePasswordRequest(Guid loginId = default(Guid), string password = default(string))
        {
            this.LoginId = loginId;
            this.Password = password;
        }

        /// <summary>
        /// Login Id of the password to change.
        /// </summary>
        /// <value>Login Id of the password to change.</value>
        [DataMember(Name = "LoginId", EmitDefaultValue = false)]
        public Guid LoginId { get; set; }

        /// <summary>
        /// New password.  If this is a SAML or NTLM login, it can be NULL.
        /// </summary>
        /// <value>New password.  If this is a SAML or NTLM login, it can be NULL.</value>
        [DataMember(Name = "Password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangePasswordRequest {\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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