// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="RadioFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>单选</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 单选
    /// </summary>
    /// <param name="Value">控件值</param>
    public record RadioFormControl([property: JsonPropertyName("value")] string Value) : FormControlBase("radioV2");

}
