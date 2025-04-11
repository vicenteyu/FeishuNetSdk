// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsReactionCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表情互动 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 表情互动 事件体
/// <para>公司圈用户表情互动时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=reaction&amp;event=created)</para>
/// <para>接口ID：7270433540692672515</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/reaction/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2freaction%2fevents%2fcreated</para>
/// </summary>
public record MomentsReactionCreatedV1EventBodyDto() : EventBodyDto("moments.reaction.created_v1")
{
    /// <summary>
    /// <para>表情互动类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>用户 ID（仅实名下有值）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>表情互动所属实体ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; set; }

    /// <summary>
    /// <para>表情互动的ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>表情回复所属实体类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:帖子,2:评论</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：帖子</item>
    /// <item>2：评论</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("entity_type")]
    public int? EntityType { get; set; }

    /// <summary>
    /// <para>表情回复人类型</para>
    /// <para>**可选值有**：</para>
    /// <para>1:实名,2:花名,3:匿名,4:官方号</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：实名</item>
    /// <item>2：花名</item>
    /// <item>3：匿名</item>
    /// <item>4：官方号</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("user_type")]
    public int? UserType { get; set; }

    /// <summary>
    /// <para>表情互动创建时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }
}
