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
        /// 条形进度图
        /// </summary>
        /// <param name="Direction"></param>
        /// <param name="SeriesField"></param>
        /// <param name="Axes"></param>
        public record LinearProgressSpec([property: JsonPropertyName("direction")] string Direction = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("axes")] Axes[]? Axes = null) : XFieldSpec("linearProgress");
    }
}
