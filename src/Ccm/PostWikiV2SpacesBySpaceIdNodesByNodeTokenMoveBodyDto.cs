// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移动知识空间节点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动知识空间节点 请求体
/// <para>此方法用于在Wiki内移动节点，支持跨知识空间移动。如果有子节点，会携带子节点一起移动。</para>
/// <para>接口ID：7041549010980667394</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-node/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesByNodeTokenMoveBodyDto
{
    /// <summary>
    /// <para>移动到的父节点token</para>
    /// <para>必填：否</para>
    /// <para>示例值：wikbcd6ydSUyOEzbdlt1BfpA5Yc</para>
    /// </summary>
    [JsonPropertyName("target_parent_token")]
    public string? TargetParentToken { get; set; }

    /// <summary>
    /// <para>移动到的知识空间ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7008061636015512345</para>
    /// </summary>
    [JsonPropertyName("target_space_id")]
    public string? TargetSpaceId { get; set; }
}
