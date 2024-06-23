// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新知识空间节点标题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新知识空间节点标题 请求体
/// <para>此接口用于更新节点标题</para>
/// <para>接口ID：7109718703113781251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/update_title</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fupdate_title</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesByNodeTokenUpdateTitleBodyDto
{
    /// <summary>
    /// <para>节点新标题</para>
    /// <para>必填：是</para>
    /// <para>示例值：新标题</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
}
