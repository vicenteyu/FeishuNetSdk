// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-29
//
// Last Modified By : yxr
// Last Modified On : 2026-08-29
// ************************************************************************
// <copyright file="PostMinutesV1MinutesByMinuteTokenClipResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建妙记片段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 创建妙记片段 响应体
/// <para>基于一篇已完成的妙记及指定的时间范围，创建一篇新的妙记片段。接口成功响应表示妙记片段已提交创建，不代表文字记录和媒体文件已生成完成，文字记录和媒体文件将在后台异步生成。</para>
/// <para>接口ID：7676147106222902224</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/clip</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fclip</para>
/// </summary>
public record PostMinutesV1MinutesByMinuteTokenClipResponseDto
{
    /// <summary>
    /// <para>妙记链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://sample.feishu.cn/minutes/obcnq3b9jl72l83w4f14xxxx</para>
    /// </summary>
    [JsonPropertyName("minute_url")]
    public string? MinuteUrl { get; set; }
}
