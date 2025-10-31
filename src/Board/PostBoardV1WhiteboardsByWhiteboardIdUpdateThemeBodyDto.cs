// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-29
//
// Last Modified By : yxr
// Last Modified On : 2025-10-29
// ************************************************************************
// <copyright file="PostBoardV1WhiteboardsByWhiteboardIdUpdateThemeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新画板主题 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 更新画板主题 请求体
/// <para>更新画板主题，具体主题介绍可以参考[主题简介](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/theme-introduction) 。</para>
/// <para>接口ID：7566200424774680595</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard/update_theme</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard%2fupdate_theme</para>
/// </summary>
public record PostBoardV1WhiteboardsByWhiteboardIdUpdateThemeBodyDto
{
    /// <summary>
    /// <para>主题名称，可选值有 classic、minimalist_gray、retro、vibrant_color、default</para>
    /// <para>必填：否</para>
    /// <para>示例值：classic</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("theme")]
    public string? Theme { get; set; }
}
