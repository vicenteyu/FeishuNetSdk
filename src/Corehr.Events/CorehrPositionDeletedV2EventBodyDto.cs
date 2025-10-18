// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="CorehrPositionDeletedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除岗位事件 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 删除岗位事件 事件体
/// <para>飞书人事中「岗位被删除」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=position&amp;event=deleted)</para>
/// <para>接口ID：7389929945764020252</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fevents%2fdeleted</para>
/// </summary>
public record CorehrPositionDeletedV2EventBodyDto() : EventBodyDto("corehr.position.deleted_v2")
{
    /// <summary>
    /// <para>岗位ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }
}
