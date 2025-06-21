// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="BlockIframe.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>内嵌 Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>内嵌 Block</para>
/// </summary>
public record BlockIframe
{
    /// <summary>
    /// <para>iframe 的组成元素</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("component")]
    public IframeComponent Component { get; set; } = new();

    /// <summary>
    /// <para>iframe 的组成元素</para>
    /// </summary>
    public record IframeComponent
    {
        /// <summary>
        /// <para>iframe 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：哔哩哔哩</item>
        /// <item>2：西瓜视频</item>
        /// <item>3：优酷</item>
        /// <item>4：Airtable</item>
        /// <item>5：百度地图</item>
        /// <item>6：高德地图</item>
        /// <item>7：Undefined</item>
        /// <item>8：Figma</item>
        /// <item>9：墨刀</item>
        /// <item>10：Canva</item>
        /// <item>11：CodePen</item>
        /// <item>12：飞书问卷</item>
        /// <item>13：金数据</item>
        /// <item>14：Undefined</item>
        /// <item>15：Undefined</item>
        /// <item>99：Other</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("iframe_type")]
        public int? IframeType { get; set; }

        /// <summary>
        /// <para>iframe 目标 url（需要进行 url_encode）</para>
        /// <para>必填：是</para>
        /// <para>示例值：https%3A%2F%2Fwww.bilibili.com%2Fvideo%2FBV1Hi4y1w7V7</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}
