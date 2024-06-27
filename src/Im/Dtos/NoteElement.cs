// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="NoteElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>备注组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 备注组件
    /// <para>扩展方法
    /// <list type="bullet">
    /// <item>AddElement：添加子元素组件</item>
    /// </list>
    /// </para>
    /// </summary>
    /// <param name="Elements">备注信息</param>
    public record NoteElement(object[]? Elements = default) : Element("note")
    {
        /// <summary>
        /// 备注信息 子元素节点
        /// </summary>
        [property: JsonPropertyName("elements")]
        public object[] Elements { get; set; } = Elements ?? Array.Empty<object>();
    }
}
