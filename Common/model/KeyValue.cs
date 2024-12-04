using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace JMWebAPI.Common.Model
{
    /// <summary>
    /// Dropdown option object
    /// </summary>
    [SwaggerSchema(Description = "Key-Value pair")]
    public class KeyValue
    {
        public KeyValue() { }

        public KeyValue(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// The value of the option
        /// </summary>
        [SwaggerSchema(Description = "The value of the option")]
        [JsonInclude]
        public string Key { get; set; }

        /// <summary>
        /// The label of the option
        /// </summary>
        [SwaggerSchema(Description = "The label of the option")]
        [JsonInclude]
        public string Value { get; set; }
    }
}
