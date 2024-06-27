// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="FormContainerElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>表单容器组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 表单容器组件
    /// </summary>
    /// <param name="Name">表单容器的唯一标识。用于识别用户提交的数据属于哪个表单容器。在同一张卡片内，该字段的值全局唯一。</param>
    /// <param name="Elements">表单容器的子节点。可内嵌其它容器类组件和展示、交互组件，不支持内嵌表格、图表、和表单容器组件。</param>
    public record FormContainerElement(string Name = "", object[]? Elements = default) : FormBaseElement("form", Name)
    {
        /// <summary>
        /// 表单容器的子节点。可内嵌其它容器类组件和展示、交互组件，不支持内嵌表格、图表、和表单容器组件。
        /// </summary>
        [property: JsonPropertyName("elements")]
        public object[] Elements { get; set; } = Elements ?? Array.Empty<object>();
    }
}
