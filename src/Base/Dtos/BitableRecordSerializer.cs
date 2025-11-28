// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="BitableRecordSerializer.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
namespace FeishuNetSdk.Base.Dtos;

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
        return string.Join(Separator, collection ?? []);
    }

    /// <inheritdoc/>
    public virtual string AttachmentRecordToString(AttachmentRecord[]? record)
    {
        return JoinCollection(record?.Select(k => k.FileToken));
    }

    /// <inheritdoc/>
    public virtual string AutoNumberRecordToString(string[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string BarcodeRecordToString(TextRecord[]? record)
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
    public virtual string CreatedUserRecordToString(UserRecord[]? record)
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
    public virtual string DuplexLinkRecordToString(LinkRecord? record)
    {
        return JoinCollection(record?.LinkRecordIds);
    }

    /// <inheritdoc/>
    public virtual string GroupChatRecordToString(GroupChatRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string LocationRecordToString(LocationRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual string ModifiedTimeRecordToString(ulong[]? record)
    {
        return JoinCollection(record ?? []);
    }

    /// <inheritdoc/>
    public virtual string ModifiedUserRecordToString(UserRecord[]? record)
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
    public virtual string SingleLinkRecordToString(LinkRecord? record)
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
    public virtual string TextRecordToString(TextRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Text));
    }

    /// <inheritdoc/>
    public virtual string UrlRecordToString(UrlRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Link));
    }

    /// <inheritdoc/>
    public virtual string UserRecordToString(UserRecord[]? record)
    {
        return JoinCollection(record?.Select(p => p.Name));
    }

    /// <inheritdoc/>
    public virtual Dictionary<string, Type> TypePairs => new()
    {
        { "Text", typeof(TextRecord[]) },
        { "Email", typeof(TextRecord[]) },
        { "Barcode", typeof(TextRecord[]) },
        { "Number", typeof(decimal[]) },
        { "Progress", typeof(decimal[]) },
        { "Currency", typeof(decimal[]) },
        { "Rating", typeof(decimal[]) },
        { "SingleSelect", typeof(string[]) },
        { "MultiSelect", typeof(string[]) },
        { "DateTime", typeof(ulong[]) },
        { "Checkbox", typeof(bool[]) },
        { "User", typeof(UserRecord[]) },
        { "GroupChat", typeof(GroupChatRecord[]) },
        { "Stage", typeof(object) },
        { "Phone", typeof(string[]) },
        { "Url", typeof(UrlRecord[]) },
        { "Attachment", typeof(AttachmentRecord[]) },
        { "SingleLink", typeof(LinkRecord) },
        { "Formula", typeof(FormulaRecord) },
        { "Lookup", typeof(FormulaRecord) },
        { "DuplexLink", typeof(LinkRecord) },
        { "Location", typeof(LocationRecord[]) },
        { "CreatedTime", typeof(ulong[]) },
        { "ModifiedTime", typeof(ulong[]) },
        { "CreatedUser", typeof(UserRecord[]) },
        { "ModifiedUser", typeof(UserRecord[]) },
        { "AutoNumber", typeof(string[]) },
        { "Button", typeof(object) },
        { "Type1", typeof(TextRecord[]) },
        { "Type2", typeof(decimal[]) },
        { "Type3", typeof(string[]) },
        { "Type4", typeof(string[]) },
        { "Type5", typeof(ulong[]) },
        { "Type7", typeof(bool[]) },
        { "Type11", typeof(UserRecord[]) },
        { "Type13", typeof(string[]) },
        { "Type15", typeof(UrlRecord[]) },
        { "Type17", typeof(AttachmentRecord[]) },
        { "Type19", typeof(FormulaRecord) },
        { "Type20", typeof(FormulaRecord) },
        { "Type22", typeof(LocationRecord[]) },
        { "Type23", typeof(GroupChatRecord[]) },
        { "Type1001", typeof(ulong[]) },
        { "Type1002", typeof(ulong[]) },
        { "Type1003", typeof(UserRecord[]) },
        { "Type1004", typeof(UserRecord[]) },
        { "Type1005", typeof(string[]) },
        { "JsonValueKindTrue", typeof(bool[]) },
        { "JsonValueKindFalse", typeof(bool[]) },
        { "JsonValueKindNumber", typeof(decimal[]) },
        { "JsonValueKindString", typeof(string[]) },
        { "JsonValueKindArray", typeof(TextRecord[]) },
        { "JsonValueKindObject", typeof(FormulaRecord) },
    };
}
