// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移动云空间文档至知识空间 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动云空间文档至知识空间 响应体
/// <para>该接口允许移动云空间文档至知识空间，并挂载在指定位置</para>
/// <para>接口ID：7023947709203808260</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/task/move_docs_to_wiki</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-node%2fmove_docs_to_wiki</para>
/// </summary>
public record PostWikiV2SpacesBySpaceIdNodesMoveDocsToWikiResponseDto
{
    /// <summary>
    /// <para>移动后的知识库节点token</para>
    /// <para>必填：否</para>
    /// <para>示例值：wikbcLZuhp4r9QuJumHzVabcdef</para>
    /// </summary>
    [JsonPropertyName("wiki_token")]
    public string? WikiToken { get; set; }

    /// <summary>
    /// <para>任务id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7037044037068177428-075c9481e6a0007c1df689dfbe5b55a08b6b06f7</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>是否提交了文档迁入申请</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("applied")]
    public bool? Applied { get; set; }
}
