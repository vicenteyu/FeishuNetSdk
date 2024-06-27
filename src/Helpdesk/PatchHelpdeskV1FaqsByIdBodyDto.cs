// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchHelpdeskV1FaqsByIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改知识库 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 修改知识库 请求体
/// <para>该接口用于修改知识库。</para>
/// <para>接口ID：6955768699895676930</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/faq/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2ffaq%2fpatch</para>
/// </summary>
public record PatchHelpdeskV1FaqsByIdBodyDto
{
    /// <summary>
    /// <para>修改的知识库内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("faq")]
    public FaqUpdateInfo? Faq { get; set; }

    /// <summary>
    /// <para>修改的知识库内容</para>
    /// </summary>
    public record FaqUpdateInfo
    {
        /// <summary>
        /// <para>知识库分类ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6836004780707807251</para>
        /// </summary>
        [JsonPropertyName("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// <para>问题</para>
        /// <para>必填：是</para>
        /// <para>示例值：问题</para>
        /// </summary>
        [JsonPropertyName("question")]
        public string Question { get; set; } = string.Empty;

        /// <summary>
        /// <para>答案</para>
        /// <para>必填：否</para>
        /// <para>示例值：答案</para>
        /// </summary>
        [JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// <para>富文本答案和答案必须有一个必填。Json Array格式，富文本结构请见[了解更多: 富文本](https://open.feishu.cn/document/ukTMukTMukTM/uITM0YjLyEDN24iMxQjN)</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"content":"答案","type":"text"},{"content":"\n","type":"text"}]</para>
        /// </summary>
        [JsonPropertyName("answer_richtext")]
        public Richtext[]? AnswerRichtexts { get; set; }

        /// <summary>
        /// <para>富文本答案和答案必须有一个必填。Json Array格式，富文本结构请见[了解更多: 富文本](https://open.feishu.cn/document/ukTMukTMukTM/uITM0YjLyEDN24iMxQjN)</para>
        /// </summary>
        public record Richtext
        {
            /// <summary>
            /// <para>内容</para>
            /// <para>必填：否</para>
            /// <para>示例值：这是一个答案</para>
            /// </summary>
            [JsonPropertyName("content")]
            public string? Content { get; set; }

            /// <summary>
            /// <para>内容类型。可选值：text、hyperlink、img、line break</para>
            /// <para>必填：否</para>
            /// <para>示例值：text</para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }
        }

        /// <summary>
        /// <para>相似问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：["tag1","tag2","tag3"]</para>
        /// </summary>
        [JsonPropertyName("tags")]
        public string[]? Tags { get; set; }
    }
}
