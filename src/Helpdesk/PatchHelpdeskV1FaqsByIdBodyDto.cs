using Newtonsoft.Json;
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
    [JsonProperty("faq")]
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
        [JsonProperty("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// <para>问题</para>
        /// <para>必填：是</para>
        /// <para>示例值：问题</para>
        /// </summary>
        [JsonProperty("question")]
        public string Question { get; set; } = string.Empty;

        /// <summary>
        /// <para>答案</para>
        /// <para>必填：否</para>
        /// <para>示例值：答案</para>
        /// </summary>
        [JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// <para>富文本答案和答案必须有一个必填。Json Array格式，富文本结构请见[了解更多: 富文本](https://open.feishu.cn/document/ukTMukTMukTM/uITM0YjLyEDN24iMxQjN)</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"content\":\"这只是一个测试，医保问题\",\"type\":\"text\"}</para>
        /// </summary>
        [JsonProperty("answer_richtext")]
        public string? AnswerRichtext { get; set; }

        /// <summary>
        /// <para>相似问题</para>
        /// <para>必填：否</para>
        /// <para>示例值：["tag1","tag2","tag3"]</para>
        /// </summary>
        [JsonProperty("tags")]
        public string[]? Tags { get; set; }
    }
}
