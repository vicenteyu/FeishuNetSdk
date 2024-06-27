// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="ContactFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>联系人</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 联系人
    /// </summary>
    /// <param name="Value">控件值</param>
    /// <param name="OpenIds">OpenId</param>
    public record ContactFormControl([property: JsonPropertyName("value")] string[] Value,
        [property: JsonPropertyName("open_ids")] string[] OpenIds) : FormControlBase("contact");

}
