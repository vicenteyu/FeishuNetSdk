// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostDriveV1MediasUploadAllResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传素材 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 上传素材 响应体
/// <para>将文件、图片、视频等素材上传到指定云文档中。素材将显示在对应云文档中，在云空间中不会显示。</para>
/// <para>## 使用限制</para>
/// <para>- 素材大小不得超过 20 MB。要上传大于 20 MB 的文件，你需使用分片上传素材相关接口。详情参考[素材概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/introduction)。</para>
/// <para>- 该接口不支持并发调用，且调用频率上限为 5 QPS，10000 次/天。</para>
/// <para>接口ID：6979562676003831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/upload_all</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_all</para>
/// </summary>
public record PostDriveV1MediasUploadAllResponseDto
{
    /// <summary>
    /// <para>素材文件的 token。</para>
    /// <para>必填：否</para>
    /// <para>示例值：boxcnrHpsg1QDqXAAAyachabcef</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }
}
