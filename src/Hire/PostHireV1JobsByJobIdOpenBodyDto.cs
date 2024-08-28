// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-08-02
// ************************************************************************
// <copyright file="PostHireV1JobsByJobIdOpenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>重启职位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 重启职位 请求体
/// <para>对于已关闭的职位，可通过本接口重启职位。</para>
/// <para>接口ID：7012986483075530753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fopen</para>
/// </summary>
public record PostHireV1JobsByJobIdOpenBodyDto
{
    /// <summary>
    /// <para>到期日期，毫秒时间戳（int64类型）</para>
    /// <para>**注意**：当`is_never_expired`为`false`时该字段必填且大于当前时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1830259120000</para>
    /// </summary>
    [JsonPropertyName("expiry_time")]
    public long? ExpiryTime { get; set; }

    /// <summary>
    /// <para>是否长期有效</para>
    /// <para>**可选值有**：</para>
    /// <para>* `true`：长期有效</para>
    /// <para>* `false`：指定到期日期</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_never_expired")]
    public bool IsNeverExpired { get; set; }
}
