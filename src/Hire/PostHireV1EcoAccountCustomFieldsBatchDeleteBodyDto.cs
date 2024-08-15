// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-15
// ************************************************************************
// <copyright file="PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除账号自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 删除账号自定义字段 请求体
/// <para>飞书招聘的背调或笔试服务商，可通过此接口删除账号自定义字段（如客户在服务商处的租户 ID、账号 ID等）。</para>
/// <para>接口ID：7195815976042545154</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fbatch_delete</para>
/// </summary>
public record PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto
{
    /// <summary>
    /// <para>适用范围</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：背调</item>
    /// <item>2：笔试</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("scope")]
    public int Scope { get; set; }

    /// <summary>
    /// <para>要删除的自定义字段的 key 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：123</para>
    /// </summary>
    [JsonPropertyName("custom_field_key_list")]
    public string[]? CustomFieldKeyList { get; set; }
}
