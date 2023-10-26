using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 文档搜索 请求体
/// <para>该接口用于根据搜索条件进行文档搜索。</para>
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
public record PostSuiteDocsApiSearchObjectBodyDto
{
    /// <summary>
    /// <para>搜索关键字</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("search_key")]
    public string SearchKey { get; set; } = string.Empty;

    /// <summary>
    /// <para>搜索返回数量，0 &lt;= count &lt;= 50</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("count")]
    public int? Count { get; set; }

    /// <summary>
    /// <para>搜索偏移位，offset &gt;= 0，offset + count &lt; 200</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>文档所有者的userid</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("owner_ids")]
    public string[]? OwnerIds { get; set; }

    /// <summary>
    /// <para>文档所在群的chatid</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("chat_ids")]
    public string[]? ChatIds { get; set; }

    /// <summary>
    /// <para>文档类型，支持："doc", "sheet", "slide", "bitable", "mindnote", "file"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("docs_types")]
    public string[]? DocsTypes { get; set; }
}
