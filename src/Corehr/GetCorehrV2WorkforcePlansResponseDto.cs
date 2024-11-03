// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-03
//
// Last Modified By : yxr
// Last Modified On : 2024-11-03
// ************************************************************************
// <copyright file="GetCorehrV2WorkforcePlansResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询编制规划方案 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询编制规划方案 响应体
/// <para>根据传入的筛选项获取编制规划的方案列表</para>
/// <para>接口ID：7314710843818508289</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/workforce_plan/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan%2flist</para>
/// </summary>
public record GetCorehrV2WorkforcePlansResponseDto
{
    /// <summary>
    /// <para>编制规划方案列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkforcePlan[]? Items { get; set; }

    /// <summary>
    /// <para>编制规划方案列表</para>
    /// </summary>
    public record WorkforcePlan
    {
        /// <summary>
        /// <para>编制规划方案 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("workforce_plan_id")]
        public string WorkforcePlanId { get; set; } = string.Empty;

        /// <summary>
        /// <para>编制规划方案名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("workforce_plan_name")]
        public I18n[]? WorkforcePlanNames { get; set; }

        /// <summary>
        /// <para>编制规划方案名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言信息，中文为 zh-CN，英文为 en-US</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>开始日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 ～ 9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-10-01</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// <para>结束日期</para>
        /// <para>- 返回格式：YYYY-MM-DD（最小单位到日）</para>
        /// <para>- 日期范围:1900-01-01 ～ 9999-12-31</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-10-31</para>
        /// </summary>
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>- true 表示启用</para>
        /// <para>- false 表示停用</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
    }

    /// <summary>
    /// <para>满足条件的方案总数</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
}
