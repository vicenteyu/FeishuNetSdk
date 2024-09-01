// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrProcessUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流程实例信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 流程实例信息变更 事件体
/// <para>流程实例是指用户发起的具体流程(process_id是其唯一标识)，流程实例在以下时机会触发信息变更事件：流程中有审批人操作、流程数据更新、流程状态变化等。</para>
/// <para>注意事项：若节点中有多个人时，可能会同时触发多个事件。例如流程运行到该节点，同时为多个人都生成了待办任务，就会导致触发多次事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process&amp;event=updated)</para>
/// <para>接口ID：7296819819722522652</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess%2fevents%2fupdated</para>
/// </summary>
public record CorehrProcessUpdatedV2EventBodyDto() : EventBodyDto("corehr.process.updated_v2")
{
    /// <summary>
    /// <para>流程运行实例 id，详细信息可通过[获取单个流程详情](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>变更后状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:发起/进行中,9:完成,2:拒绝,4:撤回,8:撤销</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：发起/进行中</item>
    /// <item>9：完成</item>
    /// <item>2：拒绝</item>
    /// <item>4：撤回</item>
    /// <item>8：撤销</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>业务类型</para>
    /// <para>详情请查看[业务类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-approver/events/biz-type)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `200` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("biz_type")]
    public string? BizType { get; set; }

    /// <summary>
    /// <para>流程定义id。流程定义是流程的模板，由流程定义可以创建流程实例。</para>
    /// <para>**示例值**：</para>
    /// <para>"people_7023711013443944467_7382148112896872236"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("flow_definition_id")]
    public string? FlowDefinitionId { get; set; }
}
