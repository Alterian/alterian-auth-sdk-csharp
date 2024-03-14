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
    /// How can you use these settings?             Please note that this it possible to combine these             For instance, for a setting which is available for both logins and sites, a value of 3 is used             For SAML Assertions, it would typically be 6 because they are applied at both the issuer and the login              Issuer settings don&#39;t actually have values associated with the issuer; the issuer settings are the assertions which are applied to the login             Values 1,2,3 will be what is returned when you populate a @see(LoginInfo)             Showing where the value for this login came from.
    /// </summary>
    /// <value>How can you use these settings?             Please note that this it possible to combine these             For instance, for a setting which is available for both logins and sites, a value of 3 is used             For SAML Assertions, it would typically be 6 because they are applied at both the issuer and the login              Issuer settings don&#39;t actually have values associated with the issuer; the issuer settings are the assertions which are applied to the login             Values 1,2,3 will be what is returned when you populate a @see(LoginInfo)             Showing where the value for this login came from.</value>
    public enum SettingAppliesTo
    {
        /// <summary>
        /// Enum Site for value: 1
        /// </summary>
        Site = 1,

        /// <summary>
        /// Enum Login for value: 2
        /// </summary>
        Login = 2,

        /// <summary>
        /// Enum Issuer for value: 4
        /// </summary>
        Issuer = 4
    }

}