// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="GetBoardV1WhiteboardsByWhiteboardIdThemeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取画板主题 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Board;
/// <summary>
/// 获取画板主题 响应体
/// <para>获取画板主题，不同主题下有不同的默认配色，具体主题介绍可以参考[主题简介](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/theme-introduction) 。</para>
/// <para>接口ID：7545367804831612930</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard/theme</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard%2ftheme</para>
/// </summary>
public record GetBoardV1WhiteboardsByWhiteboardIdThemeResponseDto
{
    /// <summary>
    /// <para>主题</para>
    /// <para>必填：是</para>
    /// <para>示例值：classic</para>
    /// <para>最大长度：10000000</para>
    /// <para>最小长度：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>classic：经典主题</item>
    /// <item>minimalist_gray：简约灰主题</item>
    /// <item>retro：复古主题</item>
    /// <item>vibrant_color：炫彩主题</item>
    /// <item>minimalist_blue：简约蓝主题</item>
    /// <item>default：默认主题</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("theme")]
    public string Theme { get; set; } = string.Empty;
}
