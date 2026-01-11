// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-01-11
//
// Last Modified By : yxr
// Last Modified On : 2026-01-11
// ************************************************************************
// <copyright file="ApaasWorkspaceRecordChangeV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>数据记录变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.AppEngine.Events;
/// <summary>
/// 数据记录变更 事件体
/// <para>当数据表记录发生变更时将触发此事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=apaas&amp;version=v1&amp;resource=workspace&amp;event=record_change)</para>
/// <para>接口ID：7592139877891705816</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/apaas-v1/workspace/events/record_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fworkspace%2fevents%2frecord_change</para>
/// </summary>
public record ApaasWorkspaceRecordChangeV1EventBodyDto() : EventBodyDto("apaas.workspace.record_change_v1")
{
    /// <summary>
    /// <para>记录所属的数据平台 workspace 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("workspace")]
    public string? Workspace { get; set; }

    /// <summary>
    /// <para>workspace关联的应用app id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public string? App { get; set; }

    /// <summary>
    /// <para>发生数据记录变更的数据表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>
    /// <para>变更类型，枚举值：INSERT / UPDATE / DELETE</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>变更人</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// <para>变更前的记录数据（INSERT 为 NULL，DELETE 包含全部字段）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("before")]
    public string? Before { get; set; }

    /// <summary>
    /// <para>变更后数据，仅含变更字段（INSERT 包含全部字段，DELETE 为 NULL）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("after")]
    public string? After { get; set; }
}
