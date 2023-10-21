using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取文档元数据 请求体
/// <para>根据 Token 获取各类文档的元数据。</para>
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
public record PostDriveV1MetasBatchQueryBodyDto
{
    /// <summary>
    /// <para>请求文档,  一次不超过200个</para>
    /// <para>必填：是</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonProperty("request_docs")]
    public RequestDoc[] RequestDocs { get; set; } = Array.Empty<RequestDoc>();

    /// <summary>
    /// <para>请求文档,  一次不超过200个</para>
    /// </summary>
    public record RequestDoc
    {
        /// <summary>
        /// <para>文件的 token，获取方式见[如何获取云文档资源相关 token](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#08bb5df6)</para>
        /// <para>必填：是</para>
        /// <para>示例值：doccnfYZzTlvXqZIGTdAHKabcef</para>
        /// </summary>
        [JsonProperty("doc_token")]
        public string DocToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>文件类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>doc：飞书文档</item>
        /// <item>sheet：飞书电子表格</item>
        /// <item>bitable：飞书多维表格</item>
        /// <item>mindnote：飞书思维笔记</item>
        /// <item>file：飞书文件</item>
        /// <item>wiki：飞书wiki</item>
        /// <item>docx：飞书新版文档</item>
        /// <item>folder：飞书文件夹</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("doc_type")]
        public string DocType { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>是否获取文档链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonProperty("with_url")]
    public bool? WithUrl { get; set; }
}
