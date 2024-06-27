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
        /// 饼图
        /// </summary>
        /// <param name="OuterRadius"></param>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="Legends"></param>
        /// <param name="Label"></param>
        /// <param name="Padding"></param>
        public record PieFSpec([property: JsonPropertyName("outerRadius")] decimal OuterRadius = default,
            [property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("legends")] Legends? Legends = null,
            [property: JsonPropertyName("label")] Label? Label = null,
            [property: JsonPropertyName("padding")] Padding? Padding = null) : Spec("pie");
    }
}
