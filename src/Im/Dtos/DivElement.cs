// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="DivElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>普通文本组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 普通文本组件
    /// <para>扩展方法：
    /// <list type="bullet">
    /// <item>SetText：设置文本内容，支持组件为：PlainTextElement、LarkMdElement</item>
    /// <item>SetIcon：设置文本图标，支持组件为：StandardIconElement、CustomIconElement</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Text">文本内容</param>
    /// <param name="Icon">文本图标</param>
    public record DivElement(object? Text = null, object? Icon = null) : Element("div")
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public object? Text { get; set; } = Text;

        /// <summary>
        /// 文本图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;
    }
}
