// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ColumnAction.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>设置点击分栏时的交互配置。</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 设置点击分栏时的交互配置。
    /// <para>当前仅支持跳转交互。如果布局容器内有交互组件，则优先响应交互组件定义的交互。</para>
    /// </summary>
    /// <param name="MultiUrl">配置各个端的链接地址。</param>
    public record ColumnAction([property: JsonPropertyName("multi_url")] UrlLink? MultiUrl = null);
}
