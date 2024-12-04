using System;
using System.Text.Json.Serialization;

namespace JMWebAPI.Common.Base
{
    /// <summary>
    /// Base Entity
    /// <p>Base class for entities, containing common properties like creation time, update time, and logical deletion flag.</p>
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("createTime")]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Update Time
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("updateTime")]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Logical Delete Flag (0 - Not Deleted, 1 - Deleted)
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
