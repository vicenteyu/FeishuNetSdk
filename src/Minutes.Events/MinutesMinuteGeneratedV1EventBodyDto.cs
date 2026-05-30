// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="MinutesMinuteGeneratedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>妙记生成 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes.Events;
/// <summary>
/// 妙记生成 事件体
/// <para>当与用户有关联的妙记生成后，将会触发该事件。</para>
/// <para>用户关联的妙记包括：</para>
/// <para>- 参与的会议所生成的妙记</para>
/// <para>- 录音或者上传音视频文件所生成的妙记{使用示例}(url=/api/tools/api_explore/api_explore_config?project=minutes&amp;version=v1&amp;resource=minute&amp;event=generated)</para>
/// <para>接口ID：7644841241633950667</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/events/generated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fevents%2fgenerated</para>
/// </summary>
public record MinutesMinuteGeneratedV1EventBodyDto() : EventBodyDto("minutes.minute.generated_v1")
{
    /// <summary>
    /// <para>妙记唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minute_token")]
    public string? MinuteToken { get; set; }

    /// <summary>
    /// <para>妙记来源。目前只有**会议来源**的会返回数据。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minute_source")]
    public GeneratedSource? MinuteSource { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record GeneratedSource
    {
        /// <summary>
        /// <para>来源类型。</para>
        /// <para>**可选值有：**</para>
        /// <para>-`meeting`: 会议来源</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// <para>来源实体id。</para>
        /// <para>-`meeting`: 对应的是会议ID（meeting id）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("source_entity_id")]
        public string? SourceEntityId { get; set; }
    }

    /// <summary>
    /// <para>需要推送事件的用户列表</para>
    /// <para>**数据校验规则**：</para>
    /// <para>- 长度范围：`0` ～ `500`</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("subscriber_ids")]
    public UserIdSuffix[]? SubscriberIds { get; set; }
}
