// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="InputFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>单行文本</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 单行文本
    /// </summary>
    /// <param name="Value">控件值</param>
    public record InputFormControl([property: JsonPropertyName("value")] string Value) : FormControlBase("input");

}
