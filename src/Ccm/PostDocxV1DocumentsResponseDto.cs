using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文档 响应体
/// <para>创建新版文档，文档标题和目录可选。</para>
/// <para>接口ID：7068199542315204636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsResponseDto
{
    /// <summary>
    /// <para>新建文档的文档信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("document")]
    public PostDocxV1DocumentsResponseDtoDocument? Document { get; set; }

    /// <summary>
    /// <para>新建文档的文档信息</para>
    /// </summary>
    public record PostDocxV1DocumentsResponseDtoDocument
    {
        /// <summary>
        /// <para>文档唯一标识。对应新版文档 Token，[点击了解如何获取云文档 Token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)。</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcni6mOy7jLRWbEylaKKC7K88</para>
        /// <para>最大长度：27</para>
        /// <para>最小长度：27</para>
        /// </summary>
        [JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// <para>文档版本 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("revision_id")]
        public int? RevisionId { get; set; }

        /// <summary>
        /// <para>文档标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：undefined</para>
        /// <para>最大长度：800</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}
