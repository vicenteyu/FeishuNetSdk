// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveExplorerV2RootFolderMetaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取我的空间（root folder）元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取我的空间（根文件夹）元数据 响应体
/// <para>获取用户“我的空间”（根文件夹）的元数据，包括根文件夹的 token、ID 和文件夹所有者的 ID。</para>
/// <para>接口ID：6979502797244170243</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/folder/get-root-folder-meta</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugTNzUjL4UzM14CO1MTN%2fget-root-folder-meta</para>
/// </summary>
public record GetDriveExplorerV2RootFolderMetaResponseDto
{
    /// <summary>
    /// <para>文件夹的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>文件夹的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>文件夹所有者的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}
