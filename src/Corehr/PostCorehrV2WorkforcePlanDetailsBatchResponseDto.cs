// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-18
//
// Last Modified By : yxr
// Last Modified On : 2025-06-06
// ************************************************************************
// <copyright file="PostCorehrV2WorkforcePlanDetailsBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询编制规划明细信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询编制规划明细信息（不支持自定义组织） 响应体
/// <para>查询编制规划明细，包括维度信息、编制数和预估在职人数</para>
/// <para>接口ID：7314710843818524673</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch</para>
/// </summary>
public record PostCorehrV2WorkforcePlanDetailsBatchResponseDto : IPageableResponse<PostCorehrV2WorkforcePlanDetailsBatchResponseDto.WorkforcePlanDetail>
{
    /// <summary>
    /// <para>编制规划方案 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7128319234123</para>
    /// </summary>
    [JsonPropertyName("workforce_plan_id")]
    public string? WorkforcePlanId { get; set; }

    /// <summary>
    /// <para>集中填报项目 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7128319234123</para>
    /// </summary>
    [JsonPropertyName("centralized_reporting_project_id")]
    public string? CentralizedReportingProjectId { get; set; }

    /// <summary>
    /// <para>编制规划明细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkforcePlanDetail[]? Items { get; set; }

    /// <summary>
    /// <para>编制规划明细信息</para>
    /// </summary>
    public record WorkforcePlanDetail
    {
        /// <summary>
        /// <para>编制规划明细 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonPropertyName("workforce_plan_detail_id")]
        public string? WorkforcePlanDetailId { get; set; }

        /// <summary>
        /// <para>部门信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department")]
        public DimensionInfo? Department { get; set; }

        /// <summary>
        /// <para>部门信息</para>
        /// </summary>
        public record DimensionInfo
        {
            /// <summary>
            /// <para>部门ID。可通过[批量查询部门V2](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get) 或者[搜索部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/search) 获取详情</para>
            /// <para>必填：是</para>
            /// <para>示例值：123456</para>
            /// </summary>
            [JsonPropertyName("id")]
            public string Id { get; set; } = string.Empty;

            /// <summary>
            /// <para>维度名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public I18n[]? Names { get; set; }

            /// <summary>
            /// <para>维度名称</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言信息，中文是 zh-CN，英文是 en-US</para>
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
        /// <para>人员类型信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("employee_type")]
        public DimensionInfo? EmployeeType { get; set; }

        /// <summary>
        /// <para>工作地点信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_location")]
        public DimensionInfo? WorkLocation { get; set; }

        /// <summary>
        /// <para>序列信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_family")]
        public DimensionInfo? JobFamily { get; set; }

        /// <summary>
        /// <para>职级信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job_level")]
        public DimensionInfo? JobLevel { get; set; }

        /// <summary>
        /// <para>职务信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("job")]
        public DimensionInfo? Job { get; set; }

        /// <summary>
        /// <para>成本中心信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("cost_center")]
        public DimensionInfo? CostCenter { get; set; }

        /// <summary>
        /// <para>编制规划值</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.00</para>
        /// </summary>
        [JsonPropertyName("workforce_plan")]
        public string? WorkforcePlan { get; set; }

        /// <summary>
        /// <para>预估在职人数明细</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("estimated_active_individuals_detail")]
        public WorkforcePlanEaiDetail[]? EstimatedActiveIndividualsDetails { get; set; }

        /// <summary>
        /// <para>预估在职人数明细</para>
        /// </summary>
        public record WorkforcePlanEaiDetail
        {
            /// <summary>
            /// <para>预估月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-10-31</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>预估在职人数</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.00</para>
            /// </summary>
            [JsonPropertyName("estimated_active_individuals")]
            public string? EstimatedActiveIndividuals { get; set; }
        }

        /// <summary>
        /// <para>是否为缺维度的明细行，true为缺维度明细行，false为非缺维度明细行</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_missing_dimension")]
        public bool? IsMissingDimension { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：34523459</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
