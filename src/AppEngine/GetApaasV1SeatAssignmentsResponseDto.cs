// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-11
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="GetApaasV1SeatAssignmentsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询席位分配详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询席位分配详情 响应体
/// <para>获取租户下平台席位和应用访问席位分配详情，如用户 ID 、应用命名空间等，需要飞书低代码平台系统管理员作为授权人调用当前 API 。</para>
/// <para>接口ID：7452929418211344412</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/seat_assignment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fseat_assignment%2flist</para>
/// </summary>
public record GetApaasV1SeatAssignmentsResponseDto : IPageableResponse<GetApaasV1SeatAssignmentsResponseDto.SeatAssignment>
{
    /// <summary>
    /// <para>席位分配情况列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public SeatAssignment[]? Items { get; set; }

    /// <summary>
    /// <para>席位分配情况列表</para>
    /// </summary>
    public record SeatAssignment
    {
        /// <summary>
        /// <para>aPaaS 产品用户的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1803710089388154</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// <para>aPaaS 产品应用的 namespace</para>
        /// <para>必填：否</para>
        /// <para>示例值：package_35f605__c</para>
        /// </summary>
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// <para>席位状态，枚举值：in_use 、released</para>
        /// <para>必填：否</para>
        /// <para>示例值：in_use</para>
        /// <para>可选值：<list type="bullet">
        /// <item>in_use：席位生效中</item>
        /// <item>released：席位已释放</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
