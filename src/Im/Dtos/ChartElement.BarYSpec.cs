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
        /// 柱状图
        /// </summary>
        /// <param name="SeriesField"></param>
        /// <param name="Legends"></param>
        public record BarYSpec([property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("legends")] Legends? Legends = null) : XFieldSpec("bar");
    }
}
