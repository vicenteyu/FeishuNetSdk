// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新订阅状态 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新订阅状态 响应体
/// <para>根据订阅ID更新订阅状态</para>
/// <para>接口ID：7065964758428499996</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fpatch</para>
/// </summary>
public record PatchDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdResponseDto
{
    /// <summary>
    /// <para>订阅关系ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234567890987654321</para>
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; set; }

    /// <summary>
    /// <para>订阅类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：comment_update</para>
    /// <para>可选值：<list type="bullet">
    /// <item>comment_update：评论更新</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("subscription_type")]
    public string? SubscriptionType { get; set; }

    /// <summary>
    /// <para>是否订阅</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_subcribe")]
    public bool? IsSubcribe { get; set; }

    /// <summary>
    /// <para>文档类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：docx</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>docx：新版文档</item>
    /// <item>wiki：知识库</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }
}
