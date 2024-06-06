namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 搜索云文档 响应体
/// <para>该接口用于根据搜索关键词（search_key）对当前用户可见的云文档进行搜索。</para>
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
public record PostSuiteDocsApiSearchObjectResponseDto
{
    /// <summary>
    /// <para>包含搜索关键词的文件列表。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("docs_entities")]
    public DocsEntitie[]? DocsEntities { get; set; }

    /// <summary></summary>
    public record DocsEntitie
    {
        /// <summary>
        /// <para>文件的 token。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("docs_token")]
        public string? DocsToken { get; set; }

        /// <summary>
        /// <para>文件的类型。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("docs_type")]
        public string? DocsType { get; set; }

        /// <summary>
        /// <para>文件的标题。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>文件的所有者。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string[]? OwnerId { get; set; }
    }

    /// <summary>
    /// <para>结果列表后是否还有数据。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>包含搜索关键词的文件总数量。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
