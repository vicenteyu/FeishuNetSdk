// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrProcessNodeUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流程节点状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 流程节点状态变更 事件体
/// <para>流程中节点状态发生变化会触发该事件。配置的节点为节点定义（node_definition_id 是唯一标识）。在流程实例中，每个流程实例生成的节点实例会不同（此功能不受数据权限范围控制）。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process.node&amp;event=updated)</para>
/// <para>接口ID：7340625370520780803</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/updated-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-node%2fevents%2fupdated</para>
/// </summary>
public record CorehrProcessNodeUpdatedV2EventBodyDto() : EventBodyDto("corehr.process.node.updated_v2")
{
    /// <summary>
    /// <para>流程定义 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string? FlowDefinitionId { get; set; }

    /// <summary>
    /// <para>节点定义 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_definition_id")]
    public string? NodeDefinitionId { get; set; }

    /// <summary>
    /// <para>流程运行实例 id，详细信息可通过[获取单个流程详情](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>节点运行实例 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_node_id")]
    public string? ProcessNodeId { get; set; }

    /// <summary>
    /// <para>节点类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:审批节点,2:抄送节点,5:表单节点,6:电子签</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：审批节点</item>
    /// <item>2：抄送节点</item>
    /// <item>5：表单节点</item>
    /// <item>6：电子签</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("node_type")]
    public int? NodeType { get; set; }

    /// <summary>
    /// <para>节点状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:进行中,2:已拒绝,3:已通过,4:已撤回,5:已回退,6:已跳过,7:已干预</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：进行中</item>
    /// <item>2：已拒绝</item>
    /// <item>3：已通过</item>
    /// <item>4：已撤回</item>
    /// <item>5：已回退</item>
    /// <item>6：已跳过</item>
    /// <item>7：已干预</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("node_status")]
    public int? NodeStatus { get; set; }

    /// <summary>
    /// <para>业务类型，详情请查看[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/process-form_variable_data/access-guide)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `200` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("biz_type")]
    public string? BizType { get; set; }
}
