// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="PostApprovalV4ApprovalsSearchLaunchableResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索可发起的审批定义 响应体</summary>
// ************************************************************************
using static FeishuNetSdk.Approval.PostApprovalV4ApprovalsSearchLaunchableResponseDto;

namespace FeishuNetSdk.Approval;
/// <summary>
/// 搜索可发起的审批定义 响应体
/// <para>搜索当前用户身份可发起的审批定义。该接口适合在用户只提供审批关键词、还没有 approval_code 时调用，用于定位可发起的原生审批定义或三方审批发起链接。</para>
/// <para>接口ID：7678280659161042125</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/search_launchable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fsearch_launchable</para>
/// </summary>
public record PostApprovalV4ApprovalsSearchLaunchableResponseDto : IPageableResponse<LaunchableApproval>
{
    /// <summary>
    /// 
    /// </summary>
    public LaunchableApproval[]? Items => Approvals;

    /// <summary>
    /// <para>可发起审批定义列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approvals")]
    public LaunchableApproval[]? Approvals { get; set; }

    /// <summary>
    /// <para>可发起审批定义列表。</para>
    /// </summary>
    public record LaunchableApproval
    {
        /// <summary>
        /// <para>审批定义编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：7C468A54-8745-2245-9675-08B7C63E7A85</para>
        /// </summary>
        [JsonPropertyName("approval_code")]
        public string? ApprovalCode { get; set; }

        /// <summary>
        /// <para>审批定义名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：请假</para>
        /// </summary>
        [JsonPropertyName("approval_name")]
        public string? ApprovalName { get; set; }

        /// <summary>
        /// <para>审批定义描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：请假审批</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否三方定义。false 表示原生审批定义，true 表示三方审批定义。</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_external")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// <para>提单链接，可用于发起审批。</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://www.example.com</para>
        /// </summary>
        [JsonPropertyName("create_link")]
        public string? CreateLink { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
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
