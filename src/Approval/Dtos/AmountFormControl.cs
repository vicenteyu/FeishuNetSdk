// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="AmountFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>金额</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 金额
    /// </summary>
    /// <param name="Value">控件值</param>
    /// <param name="Currency">货币</param>
    public record AmountFormControl([property: JsonPropertyName("value")] decimal Value,
        [property: JsonPropertyName("currency")] string Currency) : FormControlBase("amount");

}
