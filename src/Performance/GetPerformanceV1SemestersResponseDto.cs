// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetPerformanceV1SemestersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取周期列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期列表 响应体
/// <para>批量获取周期的基本信息，如周期的名称、类型等信息。支持设置时间段、周期年分、周期类型等过滤条件进行筛选。</para>
/// <para>接口ID：7275544940596789251</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fsemester%2flist</para>
/// </summary>
public record GetPerformanceV1SemestersResponseDto
{
    /// <summary>
    /// <para>周期列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Semester[]? Items { get; set; }

    /// <summary>
    /// <para>周期列表</para>
    /// </summary>
    public record Semester
    {
        /// <summary>
        /// <para>周期 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862224940</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>周期年份</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024</para>
        /// </summary>
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// <para>周期类型分组</para>
        /// <para>必填：否</para>
        /// <para>示例值：Quarter</para>
        /// </summary>
        [JsonPropertyName("type_group")]
        public string? TypeGroup { get; set; }

        /// <summary>
        /// <para>周期类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：Q1</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>周期名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>周期名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>周期中文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024 全年绩效周期</para>
            /// </summary>
            [JsonPropertyName("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>周期英文名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024 full year semester</para>
            /// </summary>
            [JsonPropertyName("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>周期开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>周期结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1640966399999</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>周期创建时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }
}
