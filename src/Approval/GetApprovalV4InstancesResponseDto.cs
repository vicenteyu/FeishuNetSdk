// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetApprovalV4InstancesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取审批实例 ID 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval;
/// <summary>
/// 批量获取审批实例 ID 响应体
/// <para>根据审批定义的 approval_code 批量获取审批实例的 instance_code，用于拉取企业下某个审批定义的全部审批实例。默认以审批创建时间先后顺序排列。</para>
/// <para>接口ID：7114621541589876739</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/instance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fapproval-v4%2finstance%2flist</para>
/// </summary>
public record GetApprovalV4InstancesResponseDto : IPageableResponse<string>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public string[]? Items => InstanceCodeList;

    /// <summary>
    /// <para>审批实例 Code 列表，默认以审批实例创建时间的先后顺序排列。</para>
    /// <para>必填：是</para>
    /// <para>示例值："357C21A0-2069-4F6B-955F-1DFBE6710C51"</para>
    /// </summary>
    [JsonPropertyName("instance_code_list")]
    public string[] InstanceCodeList { get; set; } = [];

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：是</para>
    /// <para>示例值：nF1ZXJ5VGhlbkZldGNoCgAAAAAA6PZwFmUzSldvTC1yU</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
