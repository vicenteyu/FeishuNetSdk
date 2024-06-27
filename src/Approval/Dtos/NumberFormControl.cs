// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="NumberFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>数字</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 数字
    /// </summary>
    /// <param name="Value">控件值</param>
    public record NumberFormControl([property: JsonPropertyName("value")] decimal Value) : FormControlBase("number");

}
