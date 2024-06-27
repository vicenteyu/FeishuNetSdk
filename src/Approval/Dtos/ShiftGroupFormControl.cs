// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="ShiftGroupFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>换班控件组</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 换班控件组
    /// </summary>
    /// <param name="Value">控件值</param>
    public record ShiftGroupFormControl([property: JsonPropertyName("value")] ShiftGroupFormControl.ValueDto Value) : FormControlBase("shiftGroup")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="ShiftTime"></param>
        /// <param name="ReturnTime"></param>
        /// <param name="Reason"></param>
        public record ValueDto(
            [property: JsonPropertyName("shiftTime")] DateTime ShiftTime,
            [property: JsonPropertyName("returnTime")] DateTime ReturnTime,
            [property: JsonPropertyName("reason")] string Reason);
    }

}
