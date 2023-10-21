using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动云空间文档至知识空间 请求体
/// <para>该接口允许移动云空间文档至知识空间，并挂载在指定位置</para>
/// <para>接口ID：7023947709203808260</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/task/move_docs_to_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove_docs_to_wiki</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiBodyDto
{
    /// <summary>
    /// <para>节点的父亲token。</para>
    /// <para>传空或不传时将移动为知识空间一级节点。</para>
    /// <para>必填：否</para>
    /// <para>示例值：wikcnKQ1k3p******8Vabce</para>
    /// </summary>
    [JsonProperty("parent_wiki_token")]
    public string? ParentWikiToken { get; set; }

    /// <summary>
    /// <para>文档类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：doc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>sheet：表格</item>
    /// <item>bitable：多维表格</item>
    /// <item>mindnote：思维导图</item>
    /// <item>docx：新版文档</item>
    /// <item>file：文件</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("obj_type")]
    public string ObjType { get; set; } = string.Empty;

    /// <summary>
    /// <para>文档token</para>
    /// <para>必填：是</para>
    /// <para>示例值：doccnzAaOD******Wabcdef</para>
    /// </summary>
    [JsonProperty("obj_token")]
    public string ObjToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>没有权限时，是否申请移动文档。</para>
    /// <para>如果申请移动，文档将在处理人同意时自动移动至指定位置。</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("apply")]
    public bool? Apply { get; set; }
}
