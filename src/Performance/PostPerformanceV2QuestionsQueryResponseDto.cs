// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2QuestionsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取标签填写题配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取标签填写题配置 响应体
/// <para>获取标签填写题配置信息，包括标签填写题名称、标签列表等</para>
/// <para>接口ID：7351374599659814916</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/review_config/review_template/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fquestion%2fquery</para>
/// </summary>
public record PostPerformanceV2QuestionsQueryResponseDto : IPageableResponse<PostPerformanceV2QuestionsQueryResponseDto.Question>
{
    /// <inheritdoc/>
    [JsonIgnore]
    public Question[]? Items => TagBasedQuestions;

    /// <summary>
    /// <para>标签填写题</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("tag_based_questions")]
    public Question[]? TagBasedQuestions { get; set; }

    /// <summary>
    /// <para>标签填写题</para>
    /// </summary>
    public record Question
    {
        /// <summary>
        /// <para>填写题 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7343513161666707459</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("question_id")]
        public string QuestionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>填写题名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>填写题名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>标签列表</para>
        /// <para>必填：否</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("tag_items")]
        public TagItem[]? TagItems { get; set; }

        /// <summary>
        /// <para>标签列表</para>
        /// </summary>
        public record TagItem
        {
            /// <summary>
            /// <para>标签 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7343513161666707459</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>标签名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n? Name { get; set; }

            /// <summary>
            /// <para>标签名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：体验</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Interactive experience</para>
                /// <para>最大长度：999999999</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }
        }
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
