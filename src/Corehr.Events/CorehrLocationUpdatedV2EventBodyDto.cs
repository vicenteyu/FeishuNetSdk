// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="CorehrLocationUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新地点 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 更新地点 事件体
/// <para>飞书人事中「地点被更新」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=location&amp;event=updated)</para>
/// <para>接口ID：7423693709785923587</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/location/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2flocation%2fevents%2fupdated</para>
/// </summary>
public record CorehrLocationUpdatedV2EventBodyDto() : EventBodyDto("corehr.location.updated_v2")
{
    /// <summary>
    /// <para>地点ID。</para>
    /// <para>- 调用[【查询单个地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)、[【通过地点 ID 批量获取地点信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/location/batch_get)接口返回地点详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("location_id")]
    public string? LocationId { get; set; }

    /// <summary>
    /// <para>发生变更的字段</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `200`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }

    /// <summary>
    /// <para>子变更事件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sub_events")]
    public OrganizationDomainEventData[]? SubEvents { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record OrganizationDomainEventData
    {
        /// <summary>
        /// <para>变更实体的ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>变更实体标识，ObjAPIName</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// <para>聚合实体标识，父对象 ObjAPIName</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agg_entity")]
        public string? AggEntity { get; set; }

        /// <summary>
        /// <para>聚合实体ID, 父对象ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agg_entity_id")]
        public string? AggEntityId { get; set; }

        /// <summary>
        /// <para>所属聚合实体字段， FieldAPIName</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("agg_entity_field")]
        public string? AggEntityField { get; set; }

        /// <summary>
        /// <para>操作类型</para>
        /// <para>**可选值有**：</para>
        /// <para>1:新增,2:修改,3:删除</para>
        /// <para>必填：否</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：新增</item>
        /// <item>2：修改</item>
        /// <item>3：删除</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("opt_type")]
        public int? OptType { get; set; }

        /// <summary>
        /// <para>变更字段列表</para>
        /// <para>**数据校验规则**：</para>
        /// <para>- 长度范围：`0` ～ `1000`</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("field_changes")]
        public string[]? FieldChanges { get; set; }
    }
}
