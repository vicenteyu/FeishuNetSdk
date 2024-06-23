// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetOkrV1ReviewsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询复盘信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 查询复盘信息 响应体
/// <para>根据周期和用户查询复盘信息。</para>
/// <para>接口ID：7078206296554274820</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/review/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2freview%2fquery</para>
/// </summary>
public record GetOkrV1ReviewsQueryResponseDto
{
    /// <summary>
    /// <para>OKR复盘 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("review_list")]
    public OkrReview[]? ReviewLists { get; set; }

    /// <summary>
    /// <para>OKR复盘 列表</para>
    /// </summary>
    public record OkrReview
    {
        /// <summary>
        /// <para>复盘的用户</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public OkrObjectiveAlignedObjectiveOwner? UserId { get; set; }

        /// <summary>
        /// <para>复盘的用户</para>
        /// </summary>
        public record OkrObjectiveAlignedObjectiveOwner
        {
            /// <summary>
            /// <para>用户的 open_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-asd2dasdasd</para>
            /// </summary>
            [JsonPropertyName("open_id")]
            public string? OpenId { get; set; }

            /// <summary>
            /// <para>用户的 user_id</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou-ux987dsf6x</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>用户对应的OKR复盘列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("review_period_list")]
        public OkrReviewPeriod[]? ReviewPeriodLists { get; set; }

        /// <summary>
        /// <para>用户对应的OKR复盘列表</para>
        /// </summary>
        public record OkrReviewPeriod
        {
            /// <summary>
            /// <para>周期ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：6951461264858777132</para>
            /// </summary>
            [JsonPropertyName("period_id")]
            public string? PeriodId { get; set; }

            /// <summary>
            /// <para>复盘文档</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("cycle_review_list")]
            public OkrReviewPeriodUrl[]? CycleReviewLists { get; set; }

            /// <summary>
            /// <para>复盘文档</para>
            /// </summary>
            public record OkrReviewPeriodUrl
            {
                /// <summary>
                /// <para>文档链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://bytedance.feishu.cn/drive/home/</para>
                /// </summary>
                [JsonPropertyName("url")]
                public string? Url { get; set; }

                /// <summary>
                /// <para>创建时间 毫秒</para>
                /// <para>必填：否</para>
                /// <para>示例值：1618500278663</para>
                /// </summary>
                [JsonPropertyName("create_time")]
                public string? CreateTime { get; set; }
            }

            /// <summary>
            /// <para>进展报告</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("progress_report_list")]
            public OkrReviewPeriodUrl[]? ProgressReportLists { get; set; }
        }
    }
}
