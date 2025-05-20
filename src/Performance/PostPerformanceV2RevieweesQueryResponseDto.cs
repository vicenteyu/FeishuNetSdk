// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2RevieweesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取被评估人信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取被评估人信息 响应体
/// <para>获取绩效周期中被圈定到项目中的被评估人信息，包括未启动的项目。</para>
/// <para>接口ID：7380276358332678145</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/semester_activity/reviewee/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2freviewee%2fquery</para>
/// </summary>
public record PostPerformanceV2RevieweesQueryResponseDto : IPageableResponse<PostPerformanceV2RevieweesQueryResponseDto.Reviewee>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Reviewee[]? Items => Reviewees;

    /// <summary>
    /// <para>周期ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7291278856547794964</para>
    /// </summary>
    [JsonPropertyName("semester_id")]
    public string? SemesterId { get; set; }

    /// <summary>
    /// <para>被评估人列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("reviewees")]
    public Reviewee[]? Reviewees { get; set; }

    /// <summary>
    /// <para>被评估人列表</para>
    /// </summary>
    public record Reviewee
    {
        /// <summary>
        /// <para>被评估人 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("reviewee_user_id")]
        public User? RevieweeUserId { get; set; }

        /// <summary>
        /// <para>被评估人 ID</para>
        /// </summary>
        public record User
        {
            /// <summary>
            /// <para>用户的 open_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-asd2dasdasd</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户的 user_id，ID 类型与user_id_type 的取值一致</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>被评估人参与的项目，详细信息请参考[获取项目配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("activity_ids")]
        public string[]? ActivityIds { get; set; }

        /// <summary>
        /// <para>被评估人在该周期的个人绩效详情页链接。如果参与的项目未启动则为空</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://perf.feishu.cn/perf/profile?rootReviewId=7380183500051202067</para>
        /// </summary>
        [JsonPropertyName("reviewprofile_url")]
        public string? ReviewprofileUrl { get; set; }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
