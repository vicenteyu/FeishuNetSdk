// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标字段信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标字段信息 响应体
/// <para>获取指标的字段基础信息</para>
/// <para>接口ID：7380276358332727297</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_field%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricFieldsQueryResponseDto
{
    /// <summary>
    /// <para>指标字段信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public MetricField[]? Items { get; set; }

    /// <summary>
    /// <para>指标字段信息</para>
    /// </summary>
    public record MetricField
    {
        /// <summary>
        /// <para>指标字段信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：7272581996315099155</para>
        /// </summary>
        [JsonPropertyName("field_id")]
        public string? FieldId { get; set; }

        /// <summary>
        /// <para>字段名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>字段名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>字段类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：text</para>
        /// <para>可选值：<list type="bullet">
        /// <item>text：文本</item>
        /// <item>number：数字</item>
        /// <item>pencentage：百分比</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
