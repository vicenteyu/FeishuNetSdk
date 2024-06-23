// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostSuiteDocsApiSearchObjectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索云文档 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 搜索云文档 请求体
/// <para>该接口用于根据搜索关键词（search_key）对当前用户可见的云文档进行搜索。</para>
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
public record PostSuiteDocsApiSearchObjectBodyDto
{
    /// <summary>
    /// <para>指定搜索的关键字。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("search_key")]
    public string SearchKey { get; set; } = string.Empty;

    /// <summary>
    /// <para>指定搜索返回的文件数量。取值范围为 [0,50]。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>
    /// <para>指定搜索的偏移量，该参数最小为 0，即不偏移。该参数的值与返回的文件数量之和不得小于或等于 200（即 offset + count &lt; 200）。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// <para>文件所有者的 Open ID。了解更多，参考[如何获取 Open ID](https://open.feishu.cn/document/home/user-identity-introduction/open-id)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("owner_ids")]
    public string[]? OwnerIds { get; set; }

    /// <summary>
    /// <para>文件所在群的 ID。了解更多，参考[群 ID 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-id-description)。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_ids")]
    public string[]? ChatIds { get; set; }

    /// <summary>
    /// <para>文件类型，支持以下枚举：</para>
    /// <para>- `doc`：旧版文档</para>
    /// <para>- `sheet`：电子表格</para>
    /// <para>- `slides`：幻灯片</para>
    /// <para>- `bitable`：多维表格</para>
    /// <para>- `mindnote`：思维笔记</para>
    /// <para>- `file`：文件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("docs_types")]
    public string[]? DocsTypes { get; set; }
}
