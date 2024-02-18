using ApplicationCore.Databases.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Domain.Entities.Cms
{
    [DataContract(Name = "clothing")]
    [DataObject(Schema = "Cms", Prefix = "", Name = "Clothes")]
    public class Clothing : BaseEntity<Clothing>
    {
        // Mã định danh
        [JsonPropertyName("id")]
        [DataObject(Identity = true, Increment = true, Insertable = false)]
        public long? Id { get; set; }

        [JsonPropertyName("title")]
        [DataObject(Nullable = false)]
        public string? Name { get; set; }

        [JsonPropertyName("code")]
        [DataObject(Nullable = false)]
        public string? Code { get; set; }

        [JsonPropertyName("description")]
        [DataObject(Nullable = false)]
        public string? Description { get; set; }

        [JsonPropertyName("thumbnail")]
        [DataObject(Nullable = false)]
        public string? Thumbnail { get; set; }

        [JsonPropertyName("status")]
        [DataObject(Nullable = false)]
        public short? Status { get; set; }

    }
}
