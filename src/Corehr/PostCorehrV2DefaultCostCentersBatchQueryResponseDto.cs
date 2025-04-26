// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-27
//
// Last Modified By : yxr
// Last Modified On : 2025-04-27
// ************************************************************************
// <copyright file="PostCorehrV2DefaultCostCentersBatchQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询默认成本中心 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询默认成本中心 响应体
/// <para>查询默认成本中心</para>
/// <para>接口ID：7486406573931692035</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/default_cost_center/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdefault_cost_center%2fbatch_query</para>
/// </summary>
public record PostCorehrV2DefaultCostCentersBatchQueryResponseDto
{
    /// <summary>
    /// <para>员工默认成本中心列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public EmployeeDefaultCostCenter[]? Items { get; set; }

    /// <summary>
    /// <para>员工默认成本中心列表</para>
    /// </summary>
    public record EmployeeDefaultCostCenter
    {
        /// <summary>
        /// <para>用户ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7475686493613920050</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>默认成本中心信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("default_cost_centers")]
        public EmploymentDefaultCostCenter[]? DefaultCostCenters { get; set; }

        /// <summary>
        /// <para>默认成本中心信息</para>
        /// </summary>
        public record EmploymentDefaultCostCenter
        {
            /// <summary>
            /// <para>默认成本中心ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：703912325303191204</para>
            /// </summary>
            [JsonPropertyName("wk_id")]
            public string? WkId { get; set; }

            /// <summary>
            /// <para>默认成本中心版本ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：703912321231239801</para>
            /// </summary>
            [JsonPropertyName("wk_tid")]
            public string? WkTid { get; set; }

            /// <summary>
            /// <para>生效日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-12-01</para>
            /// </summary>
            [JsonPropertyName("effective_time")]
            public string? EffectiveTime { get; set; }

            /// <summary>
            /// <para>成本中心ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7039123253031711012</para>
            /// </summary>
            [JsonPropertyName("cost_center_id")]
            public string? CostCenterId { get; set; }

            /// <summary>
            /// <para>任职ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7039123253031711012</para>
            /// </summary>
            [JsonPropertyName("job_data_id")]
            public string? JobDataId { get; set; }

            /// <summary>
            /// <para>是否继承自岗位/部门的默认成本中心</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("is_inherit")]
            public bool? IsInherit { get; set; }

            /// <summary>
            /// <para>继承来源</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("inherit_source")]
            public Enum? InheritSource { get; set; }

            /// <summary>
            /// <para>继承来源</para>
            /// </summary>
            public record Enum
            {
                /// <summary>
                /// <para>枚举值</para>
                /// <para>必填：是</para>
                /// <para>示例值：phone_type</para>
                /// </summary>
                [JsonPropertyName("enum_name")]
                public string EnumName { get; set; } = string.Empty;

                /// <summary>
                /// <para>枚举多语展示</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("display")]
                public I18n[]? Displies { get; set; }

                /// <summary>
                /// <para>枚举多语展示</para>
                /// </summary>
                public record I18n
                {
                    /// <summary>
                    /// <para>语言编码（IETF BCP 47）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：zh-CN</para>
                    /// </summary>
                    [JsonPropertyName("lang")]
                    public string Lang { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：中文示例</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>变更原因</para>
            /// <para>必填：否</para>
            /// <para>示例值：异动</para>
            /// </summary>
            [JsonPropertyName("reason")]
            public string? Reason { get; set; }
        }
    }
}
