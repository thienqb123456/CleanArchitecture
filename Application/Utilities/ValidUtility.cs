using System.Text.RegularExpressions;

namespace Application.Utilities;

public static class ValidUtility
{
    public static int IsNameBase(this string @this)
    {
        @this = @this.ToLower();
        return @this.Length is < 4 or > 16 ? -1 : !Regex.IsMatch(@this, "^[a-zA-Z]") ? -2 : Regex.IsMatch(@this, @"(\.|_){2}|\._|_\.|(_|\.)$") ? -3 : Regex.IsMatch(@this, @"[^a-zA-Z0-9\._]") ? -4 : 1;
    }

    public static bool IsPasswordBase(this string @this)
    {
        return @this.Length is >= 6 and <= 32;
    }

    public static bool IsEmailBase(this string @this)
    {
        @this = @this.ToLower();
        return !string.IsNullOrEmpty(@this) && Regex.IsMatch(@this, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
    }

    public static bool IsMobileBase(this string @this)
    {
        @this = @this.ToLower();
        var isNumber = new Regex("[^0-9]");
        return !isNumber.IsMatch(@this) && @this.Length is 10 or 11;
    }

    public static bool IsDateTime(this string? @this)
    {
        return DateTime.TryParse(@this, out _);
    }

    public static bool IsDateTime(this object? @this)
    {
        return @this != null && @this.ToString().IsDateTime();
    }

    public static bool IsWebUrl(this string @this)
    {
        return !string.IsNullOrEmpty(@this) && Regex.IsMatch(@this, @"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
    }

    public static bool IsContainsRisks(string value)
    {
        var safeFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            // Các trường được phép
            "CreatedOn",
            "UpdatedOn",
            "CreatedBy",
            "UpdatedBy",
            "CategoryId",
            "WordCount",
            "Anchor",
            "Order",
            "KeyWord",
            "AuthorId",
            "Author",
            "MainCategoryId",
            "SecondaryCategoryId",
            "Information"
        };
        var unsafeKeywords = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ";", // Các từ khóa kết thúc câu lệnh
            "SELECT", "UPDATE", "INSERT", "DELETE", // Các câu lệnh SQL chính
            "DROP", "TRUNCATE", // Các câu lệnh xóa bảng
            "ALTER", // Câu lệnh thay đổi cấu trúc bảng
            "CREATE", "RENAME", "GRANT", "REVOKE", // Các câu lệnh tạo, đổi tên, cấp quyền
            "UNION", "JOIN", "INNER JOIN", "OUTER JOIN", // Các câu lệnh kết hợp bảng
            "WHERE", "OR", "AND", // Các từ khóa trong điều kiện
            "HAVING", "GROUP BY", "ORDER BY", // Các từ khóa trong mệnh đề
            "--", "/*", "*/" // Các ký tự bình luận trong SQL
        };
        var isSafeValue = safeFields.Any(keyword => value.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        var isUnsafeValue = unsafeKeywords.Any(keyword => value.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        return !isSafeValue && isUnsafeValue;
    }
}