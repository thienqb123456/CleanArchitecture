using ApplicationCore.Databases.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    [DataContract(Name = "category")]
    [DataObject(Schema = "Cms", Prefix = "", Name = "Categories")]
    public class Category
    {
        // Mã định danh
        [JsonPropertyName("id")]
        [DataObject(Identity = true, Increment = true, Insertable = false)]
        public long? Id { get; set; }

        // Mã danh mục cha
        [JsonPropertyName("parentId")]
        [DataObject(Nullable = false)]
        public long? ParentId { get; set; }

        #region Thành phần chính

        // Tiêu đề
        [JsonPropertyName("title")]
        [DataObject(Nullable = false)]
        public string? Name { get; set; }

        // Nhận diện
        [JsonPropertyName("code")]
        [DataObject(Nullable = false)]
        public string? Code { get; set; }

        // Mô tả
        [JsonPropertyName("description")]
        [DataObject(Nullable = false)]
        public string? Description { get; set; }

        // Ảnh nhỏ
        [JsonPropertyName("thumbnail")]
        [DataObject(Nullable = false)]
        public string? Thumbnail { get; set; }

        #endregion

        // Trạng thái | Definitions.Cms.Status
        [JsonPropertyName("status")]
        [DataObject(Nullable = false)]
        public short? Status { get; set; }

    }
}
