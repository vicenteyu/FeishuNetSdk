// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="PostApprovalV4ApprovalsSearchLaunchableBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索可发起的审批定义 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 搜索可发起的审批定义 请求体
/// <para>搜索当前用户身份可发起的审批定义。该接口适合在用户只提供审批关键词、还没有 approval_code 时调用，用于定位可发起的原生审批定义或三方审批发起链接。</para>
/// <para>接口ID：7678280659161042125</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/approval/search_launchable</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2fapproval%2fsearch_launchable</para>
/// </summary>
public record PostApprovalV4ApprovalsSearchLaunchableBodyDto
{
    /// <summary>
    /// <para>关键词，用于搜索审批定义</para>
    /// <para>必填：否</para>
    /// <para>示例值：请假</para>
    /// </summary>
    [JsonPropertyName("keyword")]
    public string? Keyword { get; set; }

    /// <summary>
    /// <para>语言类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh-CN: 中文 en-US: 英文 ja-JP: 日文</para>
    /// </summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// <para>最大值：100</para>
    /// <para>最小值：1</para>
    /// <para>默认值：20</para>
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：ASDJHA1323_sda1JSASDFD</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
