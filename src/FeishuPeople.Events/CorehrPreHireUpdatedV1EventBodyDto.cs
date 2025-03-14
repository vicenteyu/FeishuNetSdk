// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrPreHireUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>入职信息变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 入职信息变更 事件体
/// <para>待入职人员任职信息更新后，触发此事件，包括两种场景：</para>
/// <para>- 通过开放平台接口创建待入职、更新待入职</para>
/// <para>- 在飞书人事-入职系统，HR 补充任职信息</para>
/// <para>如果有创建待入职后，更新数据的场景，请收到创建事件后延迟10s时间再执行更新操作{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=pre_hire&amp;event=updated)</para>
/// <para>接口ID：7254931997880598529</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/pre_hire/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fpre_hire%2fevents%2fupdated</para>
/// </summary>
public record CorehrPreHireUpdatedV1EventBodyDto() : EventBodyDto("corehr.pre_hire.updated_v1")
{
    /// <summary>
    /// <para>待入职 ID，可通过[【搜索待入职人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)获取更详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pre_hire_id")]
    public string? PreHireId { get; set; }

    /// <summary>
    /// <para>变更的字段。</para>
    /// <para>由于历史原因，部分字段（例如个人信息）变更会发送为‘wk_updated_at’字段，不会显示真实变更字段，需要通过[【搜索待入职人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/pre_hire/search)获取更详细信息。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
