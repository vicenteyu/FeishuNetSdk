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
        /// 环形进度图
        /// </summary>
        /// <param name="CategoryField"></param>
        /// <param name="ValueField"></param>
        /// <param name="SeriesField"></param>
        /// <param name="Radius"></param>
        /// <param name="InnerRadius"></param>
        /// <param name="CornerRadius"></param>
        /// <param name="Progress"></param>
        /// <param name="Indicator"></param>
        /// <param name="Legends"></param>
        public record CircularProgressSpec([property: JsonPropertyName("categoryField")] string CategoryField = "",
            [property: JsonPropertyName("valueField")] string ValueField = "",
            [property: JsonPropertyName("seriesField")] string SeriesField = "",
            [property: JsonPropertyName("radius")] decimal Radius = default,
            [property: JsonPropertyName("innerRadius")] decimal InnerRadius = default,
            [property: JsonPropertyName("cornerRadius")] decimal CornerRadius = default,
            [property: JsonPropertyName("progress")] CircularProgressSpec.ProgressSuffix Progress = default!,
            [property: JsonPropertyName("indicator")] CircularProgressSpec.IndicatorSuffix Indicator = default!,
            [property: JsonPropertyName("legends")] Legends? Legends = null) : Spec("circularProgress")
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Style"></param>
            public record ProgressSuffix([property: JsonPropertyName("style")] Style Style = default!);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Title"></param>
            /// <param name="Content"></param>
            /// <param name="Trigger"></param>
            /// <param name="Visible"></param>
            public record IndicatorSuffix([property: JsonPropertyName("title")] IndicatorSuffix.TitleSuffix Title = default!,
                [property: JsonPropertyName("content")] IndicatorSuffix.ContentSuffix[] Content = default!,
                [property: JsonPropertyName("trigger")] string Trigger = "",
                [property: JsonPropertyName("visible")] bool Visible = true)
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="Field"></param>
                /// <param name="Visible"></param>
                /// <param name="AutoLimit"></param>
                public record TitleSuffix([property: JsonPropertyName("field")] string Field = "",
                    [property: JsonPropertyName("visible")] bool Visible = true,
                    [property: JsonPropertyName("autoLimit")] bool AutoLimit = true);

                /// <summary>
                /// 
                /// </summary>
                /// <param name="Field"></param>
                /// <param name="Visible"></param>
                public record ContentSuffix([property: JsonPropertyName("field")] string Field = "",
                    [property: JsonPropertyName("visible")] bool Visible = true);
            }
        }
    }
}
