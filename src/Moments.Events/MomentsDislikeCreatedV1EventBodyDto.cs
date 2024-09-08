// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsDislikeCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>点踩 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 点踩 事件体
/// <para>公司圈用户点踩互动时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=dislike&amp;event=created)</para>
/// <para>接口ID：7270433540692705283</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/moments-v1/dislike/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fdislike%2fevents%2fcreated</para>
/// </summary>
public record MomentsDislikeCreatedV1EventBodyDto() : EventBodyDto("moments.dislike.created_v1")
{
    /// <summary>
    /// <para>点踩所属实体类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:帖子</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：帖子</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("entity_type")]
    public int? EntityType { get; set; }

    /// <summary>
    /// <para>点踩所属实体ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; set; }

    /// <summary>
    /// <para>点踩时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>Dislike的ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}