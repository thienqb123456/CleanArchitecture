using ApplicationCore.Databases.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Domain.Entities.Cms
{
    [DataContract(Name = "clothingMediaCollections")]
    [DataObject(Schema = "Cms", Prefix = "", Name = "ClothingMediaCollections")]
    public class ClothingMediaCollection : BaseEntity<ClothingMediaCollection>
    {
        // Mã định danh
        [JsonPropertyName("id")]
        [DataObject(Identity = true, Increment = true, Insertable = false)]
        public long? Id { get; set; }

        [JsonPropertyName("clothingId")]
        [DataObject(Nullable = false)]
        public long? ClothingId { get; set; }

        [JsonPropertyName("name")]
        [DataObject(Nullable = false)]
        public string? Name { get; set; }

        [JsonPropertyName("link")]
        [DataObject(Nullable = false)]
        public string? Link { get; set; }

        [JsonPropertyName("status")]
        [DataObject(Nullable = false)]
        public short? Status { get; set; }

    }
}
