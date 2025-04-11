// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="MomentsPostStatisticsUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>帖子统计数据变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Moments.Events;
/// <summary>
/// 帖子统计数据变更 事件体
/// <para>公司圈帖子统计数据变更时触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=moments&amp;version=v1&amp;resource=post_statistics&amp;event=updated)</para>
/// <para>接口ID：7270433540692787203</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post_statistics/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost_statistics%2fevents%2fupdated</para>
/// </summary>
public record MomentsPostStatisticsUpdatedV1EventBodyDto() : EventBodyDto("moments.post_statistics.updated_v1")
{
    /// <summary>
    /// <para>帖子ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("post_id")]
    public string? PostId { get; set; }

    /// <summary>
    /// <para>变更的统计数据类型（对应 statistics 内字段）</para>
    /// <para>**可选值有**：</para>
    /// <para>1:分享次数</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：分享次数</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("statistics_type")]
    public int? StatisticsType { get; set; }

    /// <summary>
    /// <para>帖子统计数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("statistics")]
    public PostStatistics? Statistics { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record PostStatistics
    {
        /// <summary>
        /// <para>分享次数</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("share_count")]
        public int? ShareCount { get; set; }
    }
}
