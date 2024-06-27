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
        /// 词云
        /// </summary>
        /// <param name="NameField"></param>
        /// <param name="ValueField"></param>
        /// <param name="SeriesField"></param>
        public record WordCloudSpec([property: JsonPropertyName("nameField")] string NameField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "") : Spec("wordCloud");
    }
}
