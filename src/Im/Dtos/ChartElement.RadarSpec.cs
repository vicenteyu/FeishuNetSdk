// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="ChartElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图表组件</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Dtos
{
    public partial record ChartElement
    {
        /// <summary>
        /// 雷达图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="Area"></param>
        /// <param name="OuterRadius"></param>
        /// <param name="Axes"></param>
        public record RadarSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("area")] RadarSpec.AreaSuffix? Area = null,
            [property: JsonPropertyName("outerRadius")] decimal OuterRadius = default,
            [property: JsonPropertyName("axes")] Axes[]? Axes = null) : Spec("radar")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record AreaSuffix([property: JsonPropertyName("visible")] bool Visible = true);
        }
    }
}
