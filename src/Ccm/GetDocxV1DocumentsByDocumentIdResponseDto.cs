namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档基本信息 响应体
/// <para>获取文档最新版本号、标题等</para>
/// <para>接口ID：7068199542315302940</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fget</para>
/// </summary>
public record GetDocxV1DocumentsByDocumentIdResponseDto
{
    /// <summary>
    /// <para>文档信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("document")]
    public GetDocxV1DocumentsByDocumentIdResponseDtoDocument? Document { get; set; }

    /// <summary>
    /// <para>文档信息</para>
    /// </summary>
    public record GetDocxV1DocumentsByDocumentIdResponseDtoDocument
    {
        /// <summary>
        /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcni6mOy7jLRWbEylaKKC7K88</para>
        /// <para>最大长度：27</para>
        /// <para>最小长度：27</para>
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// <para>文档版本 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("revision_id")]
        public int? RevisionId { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：undefined</para>
        /// <para>最大长度：800</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}
