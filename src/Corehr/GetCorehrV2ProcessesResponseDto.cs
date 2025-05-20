// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV2ProcessesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询流程实例列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询流程实例列表 响应体
/// <para>本接口用于查询流程实例列表，支持通过流程定义 ID 等进行查询，其中：</para>
/// <para>- 流程实例：是指用户在业务功能或者飞书人事的审批中心发起的具体流程，process_id 是其唯一标识。</para>
/// <para>- 流程定义：是指管理员在设置侧配置的流程，类似流程模板，flow_definition_id 是其唯一标识。用户发起的流程是按照对应的流程定义的配置生成。</para>
/// <para>接口ID：7296819819722571804</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/process-instance/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2flist</para>
/// </summary>
public record GetCorehrV2ProcessesResponseDto : IPageableResponse<string>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public string[]? Items => ProcessIds;

    /// <summary>
    /// <para>流程实例ID列表</para>
    /// <para>可通过[获取单个流程详情](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get) 查询流程详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_ids")]
    public string[]? ProcessIds { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：7278949005675988535</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
