using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建知识空间节点副本 请求体
/// <para>此接口用于在知识空间创建节点副本到指定位置。</para>
/// <para>接口ID：7109718703113797635</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fcopy</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesByNodeTokenCopyBodyDto
{
    /// <summary>
    /// <para>目标父节点 Token。</para>
    /// <para>- 目标知识空间 ID 与目标父节点 Token 不可同时为空。</para>
    /// <para>必填：否</para>
    /// <para>示例值：wikcnKQ1k3p******8Vabce</para>
    /// </summary>
    [JsonProperty("target_parent_token")]
    public string? TargetParentToken { get; set; }

    /// <summary>
    /// <para>目标知识空间 ID。</para>
    /// <para>- 目标知识空间 ID 与目标父节点 Token 不可同时为空。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6946843325487912356</para>
    /// </summary>
    [JsonProperty("target_space_id")]
    public string? TargetSpaceId { get; set; }

    /// <summary>
    /// <para>复制后的新标题。如果填空，则新标题为空。如果不填，则使用原节点标题。</para>
    /// <para>必填：否</para>
    /// <para>示例值：新标题。</para>
    /// </summary>
    [JsonProperty("title")]
    public string? Title { get; set; }
}
