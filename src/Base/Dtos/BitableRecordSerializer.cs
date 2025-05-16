#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace FeishuNetSdk;
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配

/// <summary>
/// 多维表格记录序列化规则
/// </summary>
public class BitableRecordSerializer(string? separator = ";") : IBitableRecordSerializer
{
    /// <summary>
    /// 数组分隔符
    /// </summary>
    public string? Separator => separator;

    /// <summary>
    /// 该方法用于将集合元素拼接成以分号分隔的字符串
    /// </summary>
    protected virtual string JoinCollection<T>(IEnumerable<T>? collection)
    {
        // 如果集合为空，则使用空集合，然后将集合元素拼接成以分号分隔的字符串
        return string.Join(Separator, collection ?? Enumerable.Empty<T>());
    }

    /// <inheritdoc/>
    public virtual string AttachmentRecordToString(Base.Dtos.AttachmentRecord[]? record)
    {
        return JoinCollection(record?.Select(k => k.FileToken));
    }

    /// <inheritdoc/>
    public virtual string AutoNumberRecordToString(string[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string BarcodeRecordToString(Base.Dtos.TextRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Text));
    }

    /// <inheritdoc/>
    public virtual string ButtonRecordToString(object? record)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public virtual string CheckboxRecordToString(bool[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string CreatedTimeRecordToString(ulong[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string CreatedUserRecordToString(Base.Dtos.UserRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string CurrencyRecordToString(decimal[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string DateTimeRecordToString(ulong[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string DuplexLinkRecordToString(Base.Dtos.LinkRecord? record)
    {
        return JoinCollection(record?.LinkRecordIds);
    }

    /// <inheritdoc/>
    public virtual string GroupChatRecordToString(Base.Dtos.GroupChatRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string LocationRecordToString(Base.Dtos.LocationRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string ModifiedTimeRecordToString(ulong[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string ModifiedUserRecordToString(Base.Dtos.UserRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string MultiSelectRecordToString(string[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string NumberRecordToString(decimal[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string PhoneRecordToString(string[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string ProgressRecordToString(decimal[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string RatingRecordToString(decimal[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string SingleLinkRecordToString(Base.Dtos.LinkRecord? record)
    {
        return JoinCollection(record?.LinkRecordIds);
    }

    /// <inheritdoc/>
    public virtual string SingleSelectRecordToString(string[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string StageRecordToString(object? record)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public virtual string TextRecordToString(Base.Dtos.TextRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Text));
    }

    /// <inheritdoc/>
    public virtual string UrlRecordToString(Base.Dtos.UrlRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Link));
    }

    /// <inheritdoc/>
    public virtual string UserRecordToString(Base.Dtos.UserRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual Dictionary<string, Type> TypePairs => new()
    {
        { "Text", typeof(Base.Dtos.TextRecord[]) },
        { "Email", typeof(Base.Dtos.TextRecord[]) },
        { "Barcode", typeof(Base.Dtos.TextRecord[]) },
        { "Number", typeof(decimal[]) },
        { "Progress", typeof(decimal[]) },
        { "Currency", typeof(decimal[]) },
        { "Rating", typeof(decimal[]) },
        { "SingleSelect", typeof(string[]) },
        { "MultiSelect", typeof(string[]) },
        { "DateTime", typeof(ulong[]) },
        { "Checkbox", typeof(bool[]) },
        { "User", typeof(Base.Dtos.UserRecord[]) },
        { "GroupChat", typeof(Base.Dtos.GroupChatRecord[]) },
        { "Stage", typeof(object) },
        { "Phone", typeof(string[]) },
        { "Url", typeof(Base.Dtos.UrlRecord[]) },
        { "Attachment", typeof(Base.Dtos.AttachmentRecord[]) },
        { "SingleLink", typeof(Base.Dtos.LinkRecord) },
        { "Formula", typeof(Base.Dtos.FormulaRecord) },
        { "Lookup", typeof(Base.Dtos.FormulaRecord) },
        { "DuplexLink", typeof(Base.Dtos.LinkRecord) },
        { "Location", typeof(Base.Dtos.LocationRecord[]) },
        { "CreatedTime", typeof(ulong[]) },
        { "ModifiedTime", typeof(ulong[]) },
        { "CreatedUser", typeof(Base.Dtos.UserRecord[]) },
        { "ModifiedUser", typeof(Base.Dtos.UserRecord[]) },
        { "AutoNumber", typeof(string[]) },
        { "Button", typeof(object) },
        { "Type1", typeof(Base.Dtos.TextRecord[]) },
        { "Type2", typeof(decimal[]) },
        { "Type3", typeof(string[]) },
        { "Type4", typeof(string[]) },
        { "Type5", typeof(ulong[]) },
        { "Type7", typeof(bool[]) },
        { "Type11", typeof(Base.Dtos.UserRecord[]) },
        { "Type13", typeof(string[]) },
        { "Type15", typeof(Base.Dtos.UrlRecord[]) },
        { "Type17", typeof(Base.Dtos.AttachmentRecord[]) },
        { "Type19", typeof(Base.Dtos.FormulaRecord) },
        { "Type20", typeof(Base.Dtos.FormulaRecord) },
        { "Type22", typeof(Base.Dtos.LocationRecord[]) },
        { "Type23", typeof(Base.Dtos.GroupChatRecord[]) },
        { "Type1001", typeof(ulong[]) },
        { "Type1002", typeof(ulong[]) },
        { "Type1003", typeof(Base.Dtos.UserRecord[]) },
        { "Type1004", typeof(Base.Dtos.UserRecord[]) },
        { "Type1005", typeof(string[]) },
        { "JsonValueKindTrue", typeof(bool[]) },
        { "JsonValueKindFalse", typeof(bool[]) },
        { "JsonValueKindNumber", typeof(decimal[]) },
        { "JsonValueKindString", typeof(string[]) },
        { "JsonValueKindArray", typeof(Base.Dtos.TextRecord[]) },
        { "JsonValueKindObject", typeof(Base.Dtos.FormulaRecord) },
    };
}
