// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrCostCenterUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新成本中心 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 更新成本中心 事件体
/// <para>飞书人事中「成本中心信息被更新」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=cost_center&amp;event=updated)</para>
/// <para>接口ID：7423693709785972739</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/cost_center/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fevents%2fupdated</para>
/// </summary>
public record CorehrCostCenterUpdatedV2EventBodyDto() : EventBodyDto("corehr.cost_center.updated_v2")
{
    /// <summary>
    /// <para>成本中心ID。</para>
    /// <para>- 调用[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口返回成本中心详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// <para>发生变更的字段</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
