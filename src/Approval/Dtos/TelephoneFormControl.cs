// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="TelephoneFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>电话</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 电话
    /// </summary>
    /// <param name="Value">控件值</param>
    public record TelephoneFormControl([property: JsonPropertyName("value")] TelephoneFormControl.ValueDto Value) : FormControlBase("telephone")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="CountryCode">国家代码</param>
        /// <param name="NationalNumber">电话号码</param>
        public record ValueDto(
            [property: JsonPropertyName("countryCode")] string CountryCode,
            [property: JsonPropertyName("nationalNumber")] string NationalNumber);
    }

}
