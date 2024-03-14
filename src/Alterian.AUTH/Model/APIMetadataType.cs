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
    /// An enum which can be used to filter down the request to a particular type. If this is not specified then all are returned
    /// </summary>
    /// <value>An enum which can be used to filter down the request to a particular type. If this is not specified then all are returned</value>
    public enum APIMetadataType
    {
        /// <summary>
        /// Enum METHOD for value: 1
        /// </summary>
        METHOD = 1,

        /// <summary>
        /// Enum CLASS for value: 2
        /// </summary>
        CLASS = 2
    }

}
