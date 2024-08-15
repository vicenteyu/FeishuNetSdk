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
/// <para>## 使用限制</para>
/// <para>- 文件大小不得超过 20 MB，且不可上传空文件。要上传大于 20 MB 的文件，你需使用分片上传文件相关接口。详情参考[上传文件概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file/multipart-upload-file-/introduction)。</para>
/// <para>- 该接口调用频率上限为 5 QPS，10000 次/天。否则会返回 1061045 错误码，可通过稍后重试解决。</para>
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
