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
    /// Defines Applications
    /// </summary>
    public enum Applications
    {
        /// <summary>
        /// Enum All for value: 0
        /// </summary>
        All = 0,

        /// <summary>
        /// Enum Alchemy for value: 1
        /// </summary>
        Alchemy = 1,

        /// <summary>
        /// Enum DynamicMessenger for value: 2
        /// </summary>
        DynamicMessenger = 2,

        /// <summary>
        /// Enum Management for value: 3
        /// </summary>
        Management = 3,

        /// <summary>
        /// Enum AlchemyManagement for value: 4
        /// </summary>
        AlchemyManagement = 4,

        /// <summary>
        /// Enum Tridion for value: 5
        /// </summary>
        Tridion = 5,

        /// <summary>
        /// Enum RERE for value: 6
        /// </summary>
        RERE = 6,

        /// <summary>
        /// Enum PowerBI for value: 7
        /// </summary>
        PowerBI = 7
    }

}
