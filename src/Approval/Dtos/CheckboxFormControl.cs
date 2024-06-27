// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="CheckboxFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>多选</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 多选
    /// </summary>
    /// <param name="Value">控件值</param>
    public record CheckboxFormControl([property: JsonPropertyName("value")] string[] Value) : FormControlBase("checkboxV2");

}
