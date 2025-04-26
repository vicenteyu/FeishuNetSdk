// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostApprovalOpenapiV1IdGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询审批 ID（专用） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 查询审批 ID（专用） 响应体
/// <para>用于灰度企业内的 userID、larkID 相互转换。</para>
/// <para>接口ID：6907568031544737794</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/approval-search/search-approval-id-(dedicated)</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEDN5UjLxQTO14SM0kTN</para>
/// </summary>
public record PostApprovalOpenapiV1IdGetResponseDto
{
    /// <summary>
    /// <para>Employee ID数组</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("user_id_map")]
    public object UserIdMap { get; set; } = new();

    /// <summary>
    /// <para>Lark User ID数组</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("lark_id_map")]
    public object LarkIdMap { get; set; } = new();
}
