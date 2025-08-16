// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2025-08-16
// ************************************************************************
// <copyright file="CorehrProcessApproverUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>审批任务状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 审批任务状态变更 事件体
/// <para>单个审批任务的状态变化会触发该事件。例如，审批任务从待办变为已完成。审批任务（approver_id 是唯一标识），比如一个多人会签节点，会分别生成多人的审批任务。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process.approver&amp;event=updated)</para>
/// <para>接口ID：7296819819722555420</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/process-form_variable_data/events/updated-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-approver%2fevents%2fupdated</para>
/// </summary>
public record CorehrProcessApproverUpdatedV2EventBodyDto() : EventBodyDto("corehr.process.approver.updated_v2")
{
    /// <summary>
    /// <para>流程运行实例 id，详细信息可通过[获取单个流程详情](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>单据ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approver_id")]
    public string? ApproverId { get; set; }

    /// <summary>
    /// <para>单据类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:审批单,5:表单</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：审批单</item>
    /// <item>5：表单</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    /// <summary>
    /// <para>单据状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:待办,3:已完成,2:拒绝,4:取消,18:已干预</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：待办</item>
    /// <item>3：已完成</item>
    /// <item>2：拒绝</item>
    /// <item>4：取消</item>
    /// <item>18：已干预</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>业务类型，详情请查看[接入指南](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/process-form_variable_data/access-guide)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `200` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("biz_type")]
    public string? BizType { get; set; }

    /// <summary>
    /// <para>流程定义id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string? FlowDefinitionId { get; set; }

    /// <summary>
    /// <para>节点定义id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_definition_id")]
    public string? NodeDefinitionId { get; set; }

    /// <summary>
    /// <para>节点id（已废弃，请使用node_id_str字段)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }

    /// <summary>
    /// <para>节点id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("node_id_str")]
    public string? NodeIdStr { get; set; }
}
