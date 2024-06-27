// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="DateIntervalFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>日期区间</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 日期区间
    /// </summary>
    /// <param name="Value">控件值</param>
    public record DateIntervalFormControl([property: JsonPropertyName("value")] DateIntervalFormControl.ValueDto Value) : FormControlBase("dateInterval")
    {
        /// <summary>
        /// 控件值类型
        /// </summary>
        /// <param name="Start">起始时间</param>
        /// <param name="End">结束时间</param>
        /// <param name="Interval">间隔</param>
        public record ValueDto([property: JsonPropertyName("start")] DateTime Start,
            [property: JsonPropertyName("end")] DateTime End,
            [property: JsonPropertyName("interval")] decimal Interval);
    };

}
