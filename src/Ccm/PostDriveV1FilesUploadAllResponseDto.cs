// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1FilesUploadAllResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传文件 响应体
/// <para>将指定文件上传至云空间指定目录中。</para>
/// <para>接口ID：6979562676003864604</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/upload/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fupload_all</para>
/// </summary>
public record PostDriveV1FilesUploadAllResponseDto
{
    /// <summary>
    /// <para>已上传的文件的 token</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }
}
