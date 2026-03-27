// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="PostVcV1MeetingsSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索会议记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 搜索会议记录 响应体
/// <para>根据关键词、时间范围等条件搜索会议记录，返回符合条件的会议列表，包含会议 ID、主题、开始时间及参与者等信息。</para>
/// <para>接口ID：7621540721572694970</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fmeeting%2fsearch</para>
/// </summary>
public record PostVcV1MeetingsSearchResponseDto : IPageableResponse<PostVcV1MeetingsSearchResponseDto.MeetingSearchItem>
{
    /// <summary>
    /// <para>匹配结果总数（辅助分页参考）</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>返回结果列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MeetingSearchItem[]? Items { get; set; }

    /// <summary>
    /// <para>返回结果列表</para>
    /// </summary>
    public record MeetingSearchItem
    {
        /// <summary>
        /// <para>会议ID（视频会议的唯一标识，视频会议开始后才会产生）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6911188411932033028</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>包含基本信息的卡片，用户搜索关键词命中的文本片段，使用&lt;h&gt;&lt;/h&gt;标签包裹标注</para>
        /// <para>必填：否</para>
        /// <para>示例值：会议名 \n 片段1＜h&gt;搜索词/h&gt;片段2\n 会议时间 | 组织者：组织者姓名 | ID: 会议ID</para>
        /// </summary>
        [JsonPropertyName("display_info")]
        public string? DisplayInfo { get; set; }

        /// <summary>
        /// <para>会议元信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("meta_data")]
        public MeetingMeta? MetaData { get; set; }

        /// <summary>
        /// <para>会议元信息</para>
        /// </summary>
        public record MeetingMeta
        {
            /// <summary>
            /// <para>跳转链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://applink.larkoffice.com/*</para>
            /// </summary>
            [JsonPropertyName("app_link")]
            public string? AppLink { get; set; }

            /// <summary>
            /// <para>图标url</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://lf-packag*</para>
            /// </summary>
            [JsonPropertyName("avatar")]
            public string? Avatar { get; set; }

            /// <summary>
            /// <para>描述，包含会议时间、组织者和会议ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：会议时间 | 组织者：组织者姓名 | ID：123456789</para>
            /// </summary>
            [JsonPropertyName("description")]
            public string? Description { get; set; }
        }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
