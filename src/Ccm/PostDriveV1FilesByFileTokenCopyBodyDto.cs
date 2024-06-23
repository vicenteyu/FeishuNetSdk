// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenCopyBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>复制文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 复制文件 请求体
/// <para>该接口用于将用户云空间中的文件复制至其它文件夹下。不支持复制文件夹。</para>
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
public record PostDriveV1FilesByFileTokenCopyBodyDto
{
    /// <summary>
    /// <para>复制的新文件的名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：Demo copy</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>被复制的源文件的类型。该参数为必填，请忽略左侧必填列的“否”。若该参数值为空或与实际文件类型不匹配，接口将返回失败。</para>
    /// <para>必填：否</para>
    /// <para>示例值：doc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：文件类型</item>
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>bitable：多维表格类型</item>
    /// <item>docx：新版文档类型</item>
    /// <item>mindnote：思维笔记类型</item>
    /// <item>slides：幻灯片类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>目标文件夹的 token。若传入根文件夹 token，表示复制的新文件将被创建在云空间根目录。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string FolderToken { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义请求附加参数，用于实现特殊的复制语义</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("extra")]
    public Property[]? Extras { get; set; }

    /// <summary>
    /// <para>自定义请求附加参数，用于实现特殊的复制语义</para>
    /// </summary>
    public record Property
    {
        /// <summary>
        /// <para>自定义属性键对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：target_type</para>
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <para>自定义属性值对象</para>
        /// <para>必填：是</para>
        /// <para>示例值：docx</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
