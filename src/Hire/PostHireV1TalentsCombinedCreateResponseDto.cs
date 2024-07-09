// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-09
//
// Last Modified By : yxr
// Last Modified On : 2024-07-09
// ************************************************************************
// <copyright file="PostHireV1TalentsCombinedCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建人才 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建人才 响应体
/// <para>用于在企业内创建一个人才。支持自定义字段数据，可配合[获取人才字段](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent_object/query)</para>
/// <para>接口获取自定义字段信息使用。</para>
/// <para>接口ID：7034053377010991105</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_create</para>
/// </summary>
public record PostHireV1TalentsCombinedCreateResponseDto
{
    /// <summary>
    /// <para>人才 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7021471300428613932</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>创建人 ID，与入参 `user_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_84aad35d084aa403a838cf73ee18467</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }

    /// <summary>
    /// <para>创建人类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：员工体系</item>
    /// <item>3：系统</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("creator_account_type")]
    public int? CreatorAccountType { get; set; }
}
