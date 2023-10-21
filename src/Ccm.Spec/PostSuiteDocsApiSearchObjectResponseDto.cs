using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 文档搜索 响应体
/// <para>该接口用于根据搜索条件进行文档搜索。</para>
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
public record PostSuiteDocsApiSearchObjectResponseDto
{
    /// <summary>
    /// <para>搜索匹配文档列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("docs_entities")]
    public DocsEntitie[]? DocsEntities { get; set; }

    public record DocsEntitie
    {
        /// <summary>
        /// <para>文档token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("docs_token")]
        public string? DocsToken { get; set; }

        /// <summary>
        /// <para>文档类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("docs_type")]
        public string? DocsType { get; set; }

        /// <summary>
        /// <para>标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文件所有者</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("owner_id")]
        public string? OwnerId { get; set; }
    }

    /// <summary>
    /// <para>搜索偏移位结果列表后是否还有数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public string? HasMore { get; set; }

    /// <summary>
    /// <para>搜索匹配文档总数量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("total")]
    public int? Total { get; set; }
}
