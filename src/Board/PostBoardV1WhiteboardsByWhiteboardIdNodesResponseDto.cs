// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="PostBoardV1WhiteboardsByWhiteboardIdNodesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建节点 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 创建节点 响应体
/// <para>创建画板节点，支持批量创建、创建含父子关系的节点等。</para>
/// <para>接口ID：7545367804831629314</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate</para>
/// </summary>
public record PostBoardV1WhiteboardsByWhiteboardIdNodesResponseDto
{
    /// <summary>
    /// <para>所创建的节点 id 列表</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public string[] Ids { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：否</para>
    /// <para>示例值：fe599b60-450f-46ff-b2ef-9f6675625b97</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string? ClientToken { get; set; }
}
