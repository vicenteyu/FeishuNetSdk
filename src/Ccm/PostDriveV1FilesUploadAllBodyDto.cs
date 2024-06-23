// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesUploadAllBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传文件 请求体
/// <para>将指定文件上传至云空间指定目录中。</para>
/// <para>接口ID：6979562676003864604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_all</para>
/// </summary>
public record PostDriveV1FilesUploadAllBodyDto
{
    /// <summary>
    /// <para>要上传的文件的名称。</para>
    /// <para>必填：是</para>
    /// <para>示例值：demo.pdf</para>
    /// <para>最大长度：250</para>
    /// </summary>
    [JsonPropertyName("file_name")]
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// <para>上传点的类型。取固定值 `explorer`，表示将文件上传至云空间中。</para>
    /// <para>必填：是</para>
    /// <para>示例值：explorer</para>
    /// <para>可选值：<list type="bullet">
    /// <item>explorer：云空间</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("parent_type")]
    public string ParentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>云空间中文件夹的 token。获取方式见[文件夹概述](https://open.feishu.cn/document/ukTMukTMukTM/ugTNzUjL4UzM14CO1MTN/folder-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：fldbcO1UuPz8VwnpPx5a92abcef</para>
    /// </summary>
    [JsonPropertyName("parent_node")]
    public string ParentNode { get; set; } = string.Empty;

    /// <summary>
    /// <para>文件的大小，单位为字节。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1024</para>
    /// <para>最大值：20971520</para>
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; set; }

    /// <summary>
    /// <para>文件的 Adler-32 校验和</para>
    /// <para>必填：否</para>
    /// <para>示例值：3248270248</para>
    /// </summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }
}
