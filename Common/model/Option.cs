using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Annotations;

namespace JMWebAPI.Common.Model
{
    /// <summary>
    /// Dropdown option object
    /// </summary>
    [SwaggerSchema(Description = "Dropdown option object")]
    public class Option<T>
    {
        public Option() { }

        public Option(T value, string label)
        {
            Value = value;
            Label = label;
        }

        public Option(T value, string label, List<Option<T>> children)
        {
            Value = value;
            Label = label;
            Children = children;
        }

        /// <summary>
        /// The value of the option
        /// </summary>
        [SwaggerSchema(Description = "The value of the option")]
        [JsonInclude]
        public T Value { get; set; }

        /// <summary>
        /// The label of the option
        /// </summary>
        [SwaggerSchema(Description = "The label of the option")]
        [JsonInclude]
        public string Label { get; set; }

        /// <summary>
        /// List of child options
        /// </summary>
        [SwaggerSchema(Description = "List of child options")]
        [JsonInclude]
        public List<Option<T>> Children { get; set; }
    }
}
