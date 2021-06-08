using System.Text.Json.Serialization;

namespace Wimm.Core.Entities
{
    public abstract class BaseEntity
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
