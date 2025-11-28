// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="IBitableRecordSerializer.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
namespace FeishuNetSdk.Base.Dtos;

/// <summary>
/// 多维表格记录序列化规则
/// </summary>
public interface IBitableRecordSerializer
{
    /// <summary>
    /// 将文本记录数组转换为字符串。包含：邮箱、提及、文本和条码
    /// <para>type 分为三种：text、url、mention </para>
    /// </summary>
    string TextRecordToString(TextRecord[]? record);

    /// <summary>
    /// 将条码记录数组转换为字符串。
    /// </summary>
    string BarcodeRecordToString(TextRecord[]? record);

    /// <summary>
    /// 将数字记录数组转换为字符串。
    /// </summary>
    string NumberRecordToString(decimal[]? record);

    /// <summary>
    /// 将进度记录数组转换为字符串。
    /// </summary>
    string ProgressRecordToString(decimal[]? record);

    /// <summary>
    /// 将货币记录数组转换为字符串。
    /// </summary>
    string CurrencyRecordToString(decimal[]? record);

    /// <summary>
    /// 将评分记录数组转换为字符串。
    /// </summary>
    string RatingRecordToString(decimal[]? record);

    /// <summary>
    /// 将单选记录数组转换为字符串。
    /// </summary>
    string SingleSelectRecordToString(string[]? record);

    /// <summary>
    /// 将多选记录数组转换为字符串。
    /// </summary>
    string MultiSelectRecordToString(string[]? record);

    /// <summary>
    /// 将日期记录数组转换为字符串。
    /// </summary>
    string DateTimeRecordToString(ulong[]? record);

    /// <summary>
    /// 将复选框记录数组转换为字符串。
    /// </summary>
    string CheckboxRecordToString(bool[]? record);

    /// <summary>
    /// 将人员记录数组转换为字符串。
    /// </summary>
    string UserRecordToString(UserRecord[]? record);

    /// <summary>
    /// 将群组记录数组转换为字符串。
    /// </summary>
    string GroupChatRecordToString(GroupChatRecord[]? record);

    /// <summary>
    /// 将流程记录数组转换为字符串。
    /// </summary>
    string StageRecordToString(object? record);

    /// <summary>
    /// 将电话号码记录数组转换为字符串。
    /// </summary>
    string PhoneRecordToString(string[]? record);

    /// <summary>
    /// 将超链接记录数组转换为字符串。
    /// </summary>
    string UrlRecordToString(UrlRecord[]? record);

    /// <summary>
    /// 将附件记录数组转换为字符串。
    /// </summary>
    string AttachmentRecordToString(AttachmentRecord[]? record);

    /// <summary>
    /// 将单向关联记录数组转换为字符串。
    /// </summary>
    string SingleLinkRecordToString(LinkRecord? record);

    /// <summary>
    /// 将双向关联记录数组转换为字符串。
    /// </summary>
    string DuplexLinkRecordToString(LinkRecord? record);

    /// <summary>
    /// 将地理位置记录数组转换为字符串。
    /// </summary>
    string LocationRecordToString(LocationRecord[]? record);

    /// <summary>
    /// 将创建时间记录数组转换为字符串。
    /// </summary>
    string CreatedTimeRecordToString(ulong[]? record);

    /// <summary>
    /// 将最后更新时间记录数组转换为字符串。
    /// </summary>
    string ModifiedTimeRecordToString(ulong[]? record);

    /// <summary>
    /// 将创建人记录数组转换为字符串。
    /// </summary>
    string CreatedUserRecordToString(UserRecord[]? record);

    /// <summary>
    /// 将修改人记录数组转换为字符串。
    /// </summary>
    string ModifiedUserRecordToString(UserRecord[]? record);

    /// <summary>
    /// 将自动编号记录数组转换为字符串。
    /// </summary>
    string AutoNumberRecordToString(string[]? record);

    /// <summary>
    /// 将按钮记录数组转换为字符串。
    /// </summary>
    string ButtonRecordToString(object? record);

    /// <summary>
    /// ui_type 和对应的类型映射关系
    /// </summary>
    Dictionary<string, Type> TypePairs { get; }
}
