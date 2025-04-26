// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV1IdGetBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询审批 ID（专用） 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询审批 ID（专用） 请求体
/// <para>用于灰度企业内的 userID、larkID 相互转换。</para>
/// <para>接口ID：6907568031544737794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search-approval-id-(dedicated)</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDN5UjLxQTO14SM0kTN</para>
/// </summary>
public record PostApprovalOpenapiV1IdGetBodyDto
{
    /// <summary>
    /// <para>企业标识（user_id_list 不为空时必须）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>Employee ID 数组（最大100个）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[]? UserIdList { get; set; }

    /// <summary>
    /// <para>Lark User ID 数组（最大100个）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("lark_id_list")]
    public long[]? LarkIdList { get; set; }
}
