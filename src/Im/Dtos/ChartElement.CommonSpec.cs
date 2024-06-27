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
        /// 组合图
        /// </summary>
        /// <param name="Series"></param>
        /// <param name="Axes"></param>
        /// <param name="Legends"></param>
        public record CommonSpec([property: JsonPropertyName("series")] Series[]? Series = null,
            [property: JsonPropertyName("axes")] Axes[]? Axes = null,
            [property: JsonPropertyName("legends")] Legends? Legends = null) : Spec("common");
    }
}
