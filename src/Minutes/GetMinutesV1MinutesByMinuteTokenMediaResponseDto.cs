// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-03-14
//
// Last Modified By : yxr
// Last Modified On : 2025-03-14
// ************************************************************************
// <copyright file="GetMinutesV1MinutesByMinuteTokenMediaResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>下载妙记音视频文件 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 下载妙记音视频文件 响应体
/// <para>获取妙记的音视频文件</para>
/// <para>接口ID：7289369210564345884</para>
/// <para>文档地址：https://open.feishu.cn/document/minutes-v1/minute-media/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute-media%2fget</para>
/// </summary>
public record GetMinutesV1MinutesByMinuteTokenMediaResponseDto
{
    /// <summary>
    /// <para>妙记音视频文件下载链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://internal-api-drive-stream.feishu-boe.cn/space/api/box/stream/download/authcode/?code=xxx</para>
    /// </summary>
    [JsonPropertyName("download_url")]
    public string? DownloadUrl { get; set; }
}
