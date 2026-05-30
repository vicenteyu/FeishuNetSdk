// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-30
//
// Last Modified By : yxr
// Last Modified On : 2026-05-29
// ************************************************************************
// <copyright file="DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量删除节点 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 批量删除节点 响应体
/// <para>画板批量删除节点，子节点会被递归删除。</para>
/// <para>接口ID：7642261728186174667</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fbatch_delete</para>
/// </summary>
public record DeleteBoardV1WhiteboardsByWhiteboardIdNodesBatchDeleteResponseDto
{
    /// <summary>
    /// <para>操作的唯一标识，更新请求中使用此值表示幂等的进行此次更新</para>
    /// <para>必填：是</para>
    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
    /// </summary>
    [JsonPropertyName("client_token")]
    public string ClientToken { get; set; } = string.Empty;
}
