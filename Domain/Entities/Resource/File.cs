using ApplicationCore.Databases.Annotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Domain.Entities.Cms
{
    [DataContract(Name = "file")]
    [DataObject(Schema = "Resource", Prefix = "", Name = "Resource")]
    public class File : BaseEntity<Clothing>
    {

        // Mã định danh
        [JsonPropertyName("id")]
        [DataObject(Identity = true, Increment = true, Insertable = false)]
        public long? Id { get; set; }

        // Tên tệp tin
        [JsonPropertyName("name")]
        [DataObject(Nullable = false)]
        public string? Name { get; set; } // Tài liệu học thuật.docx

        // Mô tả
        [JsonPropertyName("description")]
        [DataObject(Nullable = false)]
        public string? Description { get; set; } 

        // Phần mở rộng
        [JsonPropertyName("extension")]
        [DataObject(Nullable = false, Updatable = false)]
        public string? Extension { get; set; } // .docx

        // Kiểu File
        [JsonPropertyName("type")]
        [DataObject(Nullable = false, Updatable = false)]
        public short? Type { get; set; } // .docx

        // Kích thước
        [JsonPropertyName("size")]
        [DataObject(Nullable = false, Updatable = false)]
        public long? Size { get; set; }

        // Đường dẫn tuyệt đối
        [JsonPropertyName("location")]
        [DataObject(Nullable = false, Updatable = false)]
        public string? Location { get; set; } // C:\\Users\\Administrator\\Desktop\\FileStorage\\documents\\Tài Liệu\\Học Thuật\\Tài liệu học thuật.docx

        // Đường dẫn công khai
        [JsonPropertyName("publicUrl")]
        [DataObject(Nullable = false, Updatable = false)]
        public string? PublicUrl { get; set; } // Tài Liệu/Học Thuật/Tài liệu học thuật.docx

        [JsonPropertyName("hash")]
        [DataObject(Nullable = false, Updatable = false)]
        public string? Hash { get; set; } // 780b0b6a-ee4a-4657-8f7d-ca8bad0032d6 (Hash của Location - để duy nhất)

        // Đặc trưng | Private (riêng tư); Readonly (Chỉ đọc), Featured (nổi bật); Important (quan trọng); Archived (đã lưu trữ)
        [JsonPropertyName("feature")]
        [DataObject(Nullable = false)]
        public string? Feature { get; set; }

        [JsonPropertyName("status")]
        [DataObject(Nullable = false)]
        public short? Status { get; set; }

    }
}
