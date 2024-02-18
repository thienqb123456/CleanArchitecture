using ApplicationCore.Databases.Annotations;
using System.Text.Json.Serialization;

namespace Domain;

public abstract class BaseEntity
{
    public static DbFactory DbFactory { get; set; } = null!;

    public static void Initialize(DbFactory dbFactory)
    {
        DbFactory = dbFactory;
    }
}

public abstract class BaseEntity<T> : BaseEntity where T : class, new()
{
    [DataObject(Updatable = false)]
    [JsonPropertyName("createdBy")]
    public long? CreatedBy { get; set; }

    [DataObject(Updatable = false)]
    [JsonPropertyName("createdOn")]
    public DateTime? CreatedOn { get; set; }

    [DataObject(Insertable = false)]
    [JsonPropertyName("updatedBy")]
    public long? UpdatedBy { get; set; }

    [DataObject(Insertable = false)]
    [JsonPropertyName("updatedOn")]
    public DateTime? UpdatedOn { get; set; }

}