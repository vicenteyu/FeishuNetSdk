// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取文件夹下的文档清单 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 获取文件夹下的文档清单 响应体
/// <para>为了更好地提升该接口的安全性，我们对其进行了升级，请尽快迁移至 [新版本&gt;&gt;](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/list)获取用户云空间中指定文件夹下的文件清单。清单类型包括文件、各种在线文档（文档、电子表格、多维表格、思维笔记）、文件夹和快捷方式。该接口不支持分页，并且不会递归的获取子文件夹的清单。</para>
/// <para>接口ID：6907569524100890625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/folder/get-folder-children</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuEjNzUjLxYzM14SM2MTN</para>
/// </summary>
public record GetDriveExplorerV2FolderByFolderTokenChildrenResponseDto
{
    /// <summary>
    /// <para>文件夹的 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("parentToken")]
    public string? ParentToken { get; set; }

    /// <summary>
    /// <para>文件夹的下的文件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("children")]
    public Dictionary<string, ChildrenSuffix>? Children { get; set; }

    /// <summary></summary>
    public record ChildrenSuffix
    {
        /// <summary>
        /// <para>文件的 token</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>文件的标题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>文件的类型</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>该文件是否是快捷方式，如果值为true，代表该文件是一个快捷方式</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("is_shortcut")]
        public bool? IsShortcut { get; set; }
    }
}
