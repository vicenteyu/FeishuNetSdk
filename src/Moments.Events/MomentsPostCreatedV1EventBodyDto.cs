// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsPostCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发布帖子 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 发布帖子 事件体
/// <para>公司圈用户发布帖子时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=post&amp;event=created)</para>
/// <para>接口ID：7270433540692721667</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost%2fevents%2fcreated</para>
/// </summary>
public record MomentsPostCreatedV1EventBodyDto() : EventBodyDto("moments.post.created_v1")
{
    /// <summary>
    /// <para>帖子ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>用户 ID（仅实名下有值）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public UserIdSuffix? UserId { get; set; }

    /// <summary>
    /// <para>帖子创建时间</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("create_time")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// <para>帖子所属板块</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("category_ids")]
    public string[]? CategoryIds { get; set; }

    /// <summary>
    /// <para>帖子链接</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    /// <summary>
    /// <para>发帖人类型</para>
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
}
