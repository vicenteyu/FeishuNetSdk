// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2JobGradesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询职等 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询职等 响应体
/// <para>查询职等的详细信息。</para>
/// <para>接口ID：7366602835655720964</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/job_grade/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_grade%2fquery</para>
/// </summary>
public record PostCorehrV2JobGradesQueryResponseDto
{
    /// <summary>
    /// <para>职等信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobGrade[]? Items { get; set; }

    /// <summary>
    /// <para>职等信息列表</para>
    /// </summary>
    public record JobGrade
    {
        /// <summary>
        /// <para>职等 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4692446793125560154</para>
        /// </summary>
        [JsonPropertyName("job_grade_id")]
        public string? JobGradeId { get; set; }

        /// <summary>
        /// <para>职等数值，数字越大代表职等越高</para>
        /// <para>必填：否</para>
        /// <para>示例值：9999</para>
        /// <para>最大值：99999</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("grade_order")]
        public int? GradeOrder { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：A01234</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("names")]
        public I18n[]? Names { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言，支持中文和英文。中文用 zh-CN；英文用 en-US。</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// <para>最大长度：2</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("descriptions")]
        public I18n[]? Descriptions { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：4692446793125560154</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
