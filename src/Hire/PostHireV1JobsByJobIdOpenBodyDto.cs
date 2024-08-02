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
/// <para>支持开启职位。</para>
/// <para>接口ID：7012986483075530753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/open</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fopen</para>
/// </summary>
public record PostHireV1JobsByJobIdOpenBodyDto
{
    /// <summary>
    /// <para>到期日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：1598844859612</para>
    /// </summary>
    [JsonPropertyName("expiry_time")]
    public long? ExpiryTime { get; set; }

    /// <summary>
    /// <para>是否长期有效</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_never_expired")]
    public bool IsNeverExpired { get; set; }
}
