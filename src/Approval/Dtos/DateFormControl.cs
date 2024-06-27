// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="DateFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>日期</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 日期
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DateFormControl([property: JsonPropertyName("value")] DateTime Value) : FormControlBase("date");

}
