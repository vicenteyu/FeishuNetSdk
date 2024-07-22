// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-22
//
// Last Modified By : yxr
// Last Modified On : 2024-07-22
// ************************************************************************
// <copyright file="PostHireV1TalentsCombinedUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新人才信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新人才信息 响应体
/// <para>用于在企业内更新一个人才。姓名为系统预设的必填字段，邮箱/电话字段请在飞书招聘标准简历模板设置中确认是否必填。可配合「获取人才字段接口」获取自定义字段信息。</para>
/// <para>接口ID：7034053347989487644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/talent/combined_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fcombined_update</para>
/// </summary>
public record PostHireV1TalentsCombinedUpdateResponseDto
{
    /// <summary>
    /// <para>人才 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7021471300428613932</para>
    /// </summary>
    [JsonPropertyName("talent_id")]
    public string? TalentId { get; set; }

    /// <summary>
    /// <para>更新人 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_xxx</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>更新人类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：员工体系</item>
    /// <item>3：系统</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("operator_account_type")]
    public int? OperatorAccountType { get; set; }
}
