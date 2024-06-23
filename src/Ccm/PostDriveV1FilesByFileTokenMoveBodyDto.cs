// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesByFileTokenMoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移动文件或文件夹 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 移动文件或文件夹 请求体
/// <para>将文件或者文件夹移动到用户云空间的其他位置。</para>
/// <para>接口ID：7080903916725993474</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/move</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fmove</para>
/// </summary>
public record PostDriveV1FilesByFileTokenMoveBodyDto
{
    /// <summary>
    /// <para>文件类型。该参数为必填，请忽略左侧必填列的“否”。如果该值为空或者与文件实际类型不匹配，接口会返回失败。</para>
    /// <para>必填：否</para>
    /// <para>示例值：file</para>
    /// <para>可选值：<list type="bullet">
    /// <item>file：普通文件类型</item>
    /// <item>docx：新版文档类型</item>
    /// <item>bitable：多维表格类型</item>
    /// <item>doc：文档类型</item>
    /// <item>sheet：电子表格类型</item>
    /// <item>mindnote：思维笔记类型</item>
    /// <item>folder：文件夹类型</item>
    /// <item>slides：幻灯片类型</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// <para>目标文件夹的 token。了解如何获取文件夹 token，参考[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("folder_token")]
    public string? FolderToken { get; set; }
}
