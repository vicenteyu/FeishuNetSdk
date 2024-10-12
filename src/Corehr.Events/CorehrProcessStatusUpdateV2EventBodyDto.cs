// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrProcessStatusUpdateV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流程实例状态变化 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 流程实例状态变化 事件体
/// <para>流程实例是指用户发起的具体流程(process_id是其唯一标识)，流程实例状态变化时会触发该事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process.status&amp;event=update)</para>
/// <para>接口ID：7397629009809866780</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-status/events/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-status%2fevents%2fupdate</para>
/// </summary>
public record CorehrProcessStatusUpdateV2EventBodyDto() : EventBodyDto("corehr.process.status.update_v2")
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

    /// <summary>
    /// <para>流程属性</para>
    /// <para>**可选值有**：</para>
    /// <para>1:普通流程,2:撤销流程,3:更正流程</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：普通流程</item>
    /// <item>2：撤销流程</item>
    /// <item>3：更正流程</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("properties")]
    public int? Properties { get; set; }
}
