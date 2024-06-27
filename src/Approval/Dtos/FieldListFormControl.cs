// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="FieldListFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>明细</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 明细
    /// </summary>
    /// <param name="Value">控件值</param>
    public record FieldListFormControl([property: JsonPropertyName("value")] FieldListFormControl.ValueDto[][] Value) : FormControlBase("fieldList")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="Value">控件值</param>
        /// <param name="Type">控件类型</param>
        public record ValueDto([property: JsonPropertyName("value")] string[] Value, string Type) : FormControlBase(Type);
    }

}
