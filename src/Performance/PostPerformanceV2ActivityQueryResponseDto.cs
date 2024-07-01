// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2ActivityQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取项目配置 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取项目配置 响应体
/// <para>获取项目的信息，如项目名称、项目模式等</para>
/// <para>接口ID：7351374599659765764</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/activity/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2factivity%2fquery</para>
/// </summary>
public record PostPerformanceV2ActivityQueryResponseDto
{
    /// <summary>
    /// <para>绩效评估项目列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("activities")]
    public Activity[]? Activities { get; set; }

    /// <summary>
    /// <para>绩效评估项目列表</para>
    /// </summary>
    public record Activity
    {
        /// <summary>
        /// <para>绩效评估项目 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7343513161666707459</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>绩效评估项目名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>绩效评估项目名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// <para>最大长度：999999999</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>该项目所属的绩效评估周期 ID，详情见[获取周期](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：7343513161666707459</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("semester_id")]
        public string? SemesterId { get; set; }

        /// <summary>
        /// <para>项目模式</para>
        /// <para>必填：否</para>
        /// <para>示例值：performance_review</para>
        /// <para>最大长度：999999999</para>
        /// <para>最小长度：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>metric_development：指标制定</item>
        /// <item>performance_review：绩效评估</item>
        /// <item>metric_development_and_performance_review：指标制定及绩效评估</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("mode")]
        public string? Mode { get; set; }
    }
}
