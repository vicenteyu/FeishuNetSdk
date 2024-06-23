// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesCreateShortcutBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建文件快捷方式 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建文件快捷方式 请求体
/// <para>创建指定文件的快捷方式到云空间的其它文件夹中。</para>
/// <para>接口ID：7216001760515112961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create_shortcut</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_shortcut</para>
/// </summary>
public record PostDriveV1FilesCreateShortcutBodyDto
{
    /// <summary>
    /// <para>目标父文件夹的 token，获取方式见[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbc5qgwyQnO0uedNllWuabcef</para>
    /// </summary>
    [JsonPropertyName("parent_token")]
    public string ParentToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>源文件的信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("refer_entity")]
    public PostDriveV1FilesCreateShortcutBodyDtoReferEntity ReferEntity { get; set; } = new();

    /// <summary>
    /// <para>源文件的信息</para>
    /// </summary>
    public record PostDriveV1FilesCreateShortcutBodyDtoReferEntity
    {
        /// <summary>
        /// <para>源文件的 token。获取方式见[文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/file-overview)</para>
        /// <para>必填：是</para>
        /// <para>示例值：doxbcGvhSVN0R6octqPwAEabcef</para>
        /// </summary>
        [JsonPropertyName("refer_token")]
        public string ReferToken { get; set; } = string.Empty;

        /// <summary>
        /// <para>源文件的类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// <para>可选值：<list type="bullet">
        /// <item>file：文件</item>
        /// <item>docx：新版文档</item>
        /// <item>bitable：多维表格</item>
        /// <item>doc：旧版文档</item>
        /// <item>sheet：电子表格</item>
        /// <item>mindnote：思维笔记</item>
        /// <item>slides：幻灯片类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("refer_type")]
        public string ReferType { get; set; } = string.Empty;
    }
}
