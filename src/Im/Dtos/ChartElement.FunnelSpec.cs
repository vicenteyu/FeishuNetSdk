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
        /// 漏斗图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="IsTransform"></param>
        /// <param name="TransformLabel"></param>
        /// <param name="OuterLabel"></param>
        /// <param name="Label"></param>
        public record FunnelSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("isTransform")] bool IsTransform = true,
            [property: JsonPropertyName("transformLabel")] FunnelSpec.TransformLabelSuffix TransformLabel = default!,
            [property: JsonPropertyName("outerLabel")] FunnelSpec.OuterLabelSuffix OuterLabel = default!,
            [property: JsonPropertyName("label")] Label? Label = null) : Spec("funnel")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record TransformLabelSuffix([property: JsonPropertyName("visible")] bool Visible = true);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Visible"></param>
            public record OuterLabelSuffix([property: JsonPropertyName("visible")] bool Visible = true);
        }
    }
}
