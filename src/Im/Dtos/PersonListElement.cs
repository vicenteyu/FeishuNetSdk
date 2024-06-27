// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="PersonListElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>人员列表组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 人员列表组件
    /// </summary>
    /// <param name="Lines">最大显示行数，默认不限制最大显示行数。</param>
    /// <param name="ShowName">是否展示人员的用户名。</param>
    /// <param name="ShowAvatar">是否展示人员的头像。</param>
    /// <param name="Size">
    /// 人员的头像尺寸。可取值：
    /// <list type="bullet">
    /// <item>extra_small：超小尺寸</item>
    /// <item>small：小尺寸</item>
    /// <item>medium：中尺寸</item>
    /// <item>large：大尺寸</item>
    /// </list>
    /// </param>
    /// <param name="Persons">人员列表。</param>
    /// <param name="Icon">添加图标作为文本前缀图标。支持自定义或使用图标库中的图标。</param>
    public record PersonListElement([property: JsonPropertyName("lines")] int? Lines = null,
        [property: JsonPropertyName("show_name")] bool? ShowName = null,
        [property: JsonPropertyName("show_avatar")] bool? ShowAvatar = null,
        [property: JsonPropertyName("size")] string? Size = null,
        [property: JsonPropertyName("persons")] PersonListElement.Person[] Persons = default!,
        object? Icon = null) : Element("person_list")
    {
        /// <summary>
        /// 文本前缀图标
        /// </summary>
        [JsonPropertyName("icon")]
        public object? Icon { get; set; } = Icon;

        /// <summary>
        /// 人员
        /// </summary>
        /// <param name="Id">
        /// 人员的 ID。可选值有：
        /// <list type="bullet">
        /// <item>人员的 Open ID：标识一个用户在某个应用中的身份。同一个用户在不同应用中的 Open ID 不同。详情参考如何获取 Open ID</item>
        /// <item>人员的 Union ID：标识一个用户在某个应用开发商下的身份。同一用户在同一开发商下的应用中的 Union ID 是相同的，在不同开发商下的应用中的 Union ID 是不同的。通过 Union ID，应用开发商可以把同个用户在多个应用中的身份关联起来。详情参考如何获取 Union ID</item>
        /// <item>人员的 User ID ：标识一个用户在某个租户内的身份。同一个用户在租户 A 和租户 B 内的 User ID 是不同的。在同一个租户内，一个用户的 User ID 在所有应用（包括商店应用）中都保持一致。User ID 主要用于在不同的应用间打通用户数据。详情参考如何获取User ID</item>
        /// </list>
        /// </param>
        public record Person([property: JsonPropertyName("id")] string Id = "");
    }
}
