// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveExplorerV2FileCopyFilesByFileTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制文档 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 复制文档 响应体
/// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/copy)将文件复制到用户云空间的其他文件夹中。不支持复制文件夹。</para>
/// <para>如果目标文件夹是我的空间，则复制的文件会在「我的空间」的「归我所有」列表里。</para>
/// <para>该接口不支持并发创建，且调用频率上限为 5QPS 且 10000次/天</para>
/// <para>接口ID：6907569523177127937</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/copy-a-doc-or-sheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTNzUjL2UzM14iN1MTN</para>
/// </summary>
public record PostDriveExplorerV2FileCopyFilesByFileTokenResponseDto
{
    /// <summary>
    /// <para>目标文件夹的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("folderToken")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>新创建文件的版本号</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }

    /// <summary>
    /// <para>新创建文件的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>
    /// <para>新创建文件的类型，"file"、"doc"、"sheet"、"bitable"、"docx"、"mindnote"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>新创建文件的 url</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
