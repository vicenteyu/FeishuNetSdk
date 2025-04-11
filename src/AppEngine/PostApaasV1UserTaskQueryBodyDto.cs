// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostApaasV1UserTaskQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询人工任务 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine;
/// <summary>
/// 查询人工任务 请求体
/// <para>查询人工任务列表</para>
/// <para>接口ID：7446337145820315652</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/flow/user-task/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fuser_task%2fquery</para>
/// </summary>
public record PostApaasV1UserTaskQueryBodyDto
{
    /// <summary>
    /// <para>类型</para>
    /// <para>- archived：已完成的</para>
    /// <para>- pending：待处理的</para>
    /// <para>必填：否</para>
    /// <para>示例值：pending</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>来源</para>
    /// <para>- fromMe:我发起的</para>
    /// <para>- assignMe:分配给我的</para>
    /// <para>- CCMe：抄送我的</para>
    /// <para>必填：否</para>
    /// <para>示例值：assignMe</para>
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// <para>获取条数</para>
    /// <para>- 最小值：1</para>
    /// <para>- 最大值：50</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("limit")]
    public string? Limit { get; set; }

    /// <summary>
    /// <para>起始位置</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public string? Offset { get; set; }

    /// <summary>
    /// <para>开始时间（毫秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1730208758000</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>结束时间（毫秒）</para>
    /// <para>必填：否</para>
    /// <para>示例值：1730208758000</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; set; }

    /// <summary>
    /// <para>流程apiid列表，可以通过apaas流程列表页获取</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("api_ids")]
    public string[]? ApiIds { get; set; }

    /// <summary>
    /// <para>kunlunUserID,可通过Apaas用户管理页面获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：1234</para>
    /// </summary>
    [JsonPropertyName("kunlun_user_id")]
    public string KunlunUserId { get; set; } = string.Empty;
}
