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
// <summary>获取周期 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取周期 响应体
/// <para>获取周期的基本信息</para>
/// <para>接口ID：7275544940596789251</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v1/semester/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v1%2fsemester%2flist</para>
/// </summary>
public record GetPerformanceV1SemestersResponseDto
{
    /// <summary>
    /// <para>周期 meta 信息列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Semester[]? Items { get; set; }

    /// <summary>
    /// <para>周期 meta 信息列表</para>
    /// </summary>
    public record Semester
    {
        /// <summary>
        /// <para>绩效评估周期的 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6992035450862224940</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>绩效评估周期 年份</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024</para>
        /// </summary>
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// <para>绩效评估周期 类型分组</para>
        /// <para>必填：否</para>
        /// <para>示例值：Month</para>
        /// </summary>
        [JsonPropertyName("type_group")]
        public string? TypeGroup { get; set; }

        /// <summary>
        /// <para>绩效评估周期 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：June</para>
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <para>绩效评估周期的名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("name")]
        public I18n? Name { get; set; }

        /// <summary>
        /// <para>绩效评估周期的名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：体验</para>
            /// </summary>
            [JsonPropertyName("zh-CN")]
            public string? ZhCN { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：Interactive experience</para>
            /// </summary>
            [JsonPropertyName("en-US")]
            public string? EnUS { get; set; }
        }

        /// <summary>
        /// <para>绩效评估周期的开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// <para>绩效评估周期的结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1640966399999</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// <para>绩效评估周期的创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625068800000</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }
}
