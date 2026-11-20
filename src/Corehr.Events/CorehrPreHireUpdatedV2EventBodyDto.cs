// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-11-20
//
// Last Modified By : yxr
// Last Modified On : 2026-11-20
// ************************************************************************
// <copyright file="CorehrPreHireUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>入职信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 入职信息变更 事件体
/// <para>待入职信息更新后，触发此事件，包括：</para>
/// <para>- 在飞书人事-入职系统更新待入职</para>
/// <para>- 通过开放平台接口[更新待入职](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/patch){使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=pre_hire&amp;event=updated)</para>
/// <para>接口ID：7680824677745708219</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fpre_hire%2fevents%2fupdated</para>
/// </summary>
public record CorehrPreHireUpdatedV2EventBodyDto() : EventBodyDto("corehr.pre_hire.updated_v2")
{
    /// <summary>
    /// <para>待入职 ID，可通过[【搜索待入职人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)获取更详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("prehire_id")]
    public string? PrehireId { get; set; }

    /// <summary>
    /// <para>变更的字段，可通过[【搜索待入职人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)获取更详细信息</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
