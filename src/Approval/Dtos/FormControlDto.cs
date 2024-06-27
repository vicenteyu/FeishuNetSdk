// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-28
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="FromControlDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>序列化的控件信息</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 序列化的控件信息
    /// </summary>
    /// <param name="Id">控件ID</param>
    /// <param name="Name">控件名称</param>
    /// <param name="Type">控件类型</param>
    /// <param name="Value"></param>
    /// <param name="DefaultValueType">控件的默认值类型</param>
    /// <param name="DisplayCondition">控件显隐条件</param>
    /// <param name="EnableDefaultValue">此控件是否启用了默认值</param>
    /// <param name="WidgetDefaultValue">控件的默认值</param>
    /// <param name="Printable">是否允许打印</param>
    /// <param name="Required">是否必填</param>
    /// <param name="Visible">是否可见</param>
    /// <param name="Option"></param>
    /// <param name="Options"></param>
    public record FormControlDto(
        [property: JsonPropertyName("id")] string Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("value")] string? Value,
        [property: JsonPropertyName("default_value_type")] string DefaultValueType,
        [property: JsonPropertyName("display_condition")] object? DisplayCondition,
        [property: JsonPropertyName("enable_default_value")] bool EnableDefaultValue,
        [property: JsonPropertyName("widget_default_value")] string WidgetDefaultValue,
        [property: JsonPropertyName("printable")] bool Printable,
        [property: JsonPropertyName("required")] bool Required,
        [property: JsonPropertyName("visible")] bool Visible,
        [property: JsonPropertyName("option")] object? Option = null,
        [property: JsonPropertyName("options")] object? Options = null);

}
