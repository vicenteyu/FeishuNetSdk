// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="Element.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>元素</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 元素
    /// </summary>
    /// <param name="Tag">标签</param>
    public abstract record Element(string Tag)
    {
        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; } = Tag;
    }

    /// <summary>
    /// 普通文本内容
    /// </summary>
    public interface IAmDivTextElement { }

    /// <summary>
    /// 普通文本图标
    /// </summary>
    public interface IAmDivIconElement { }

    /// <summary>
    /// 备注组件 子元素节点
    /// </summary>
    public interface IAmNoteElement { }

    /// <summary>
    /// 
    /// </summary>
    public interface IAmMessageContent { }

    /// <summary>
    /// 卡片交互
    /// </summary>
    public interface IAmBehaviors { }
}
