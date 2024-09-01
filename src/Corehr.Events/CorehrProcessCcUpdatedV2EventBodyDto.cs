// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrProcessCcUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>抄送单据状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 抄送单据状态变更 事件体
/// <para>流程中生成抄送单据后会触发该事件。抄送节点会生成抄送单据任务。如果一个节点有多个人抄送人，则会生成多个抄送单据。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=process.cc&amp;event=updated)</para>
/// <para>接口ID：7296819819722539036</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-cc/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fprocess-cc%2fevents%2fupdated</para>
/// </summary>
public record CorehrProcessCcUpdatedV2EventBodyDto() : EventBodyDto("corehr.process.cc.updated_v2")
{
    /// <summary>
    /// <para>流程运行实例 id，详细信息可通过[获取单个流程详情](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process/get)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>抄送单据ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("approver_id")]
    public string? ApproverId { get; set; }

    /// <summary>
    /// <para>单据状态</para>
    /// <para>**可选值有**：</para>
    /// <para>5:抄送到达</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>5：抄送到达</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>业务类型，详情请查看[业务类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/process-approver/events/biz-type)</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`1` ～ `200` 字符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("biz_type")]
    public string? BizType { get; set; }
}
