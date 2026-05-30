// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除节点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 批量删除节点 请求体
/// <para>画板批量删除节点，子节点会被递归删除。</para>
/// <para>接口ID：7642261728186174667</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fbatch_delete</para>
/// </summary>
public record DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteBodyDto
{
    /// <summary>
    /// <para>需要删除的节点 id 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[]? Ids { get; set; }
}
