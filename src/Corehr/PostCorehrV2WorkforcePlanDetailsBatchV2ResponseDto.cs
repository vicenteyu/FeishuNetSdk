// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-28
//
// Last Modified By : yxr
// Last Modified On : 2025-06-06
// ************************************************************************
// <copyright file="PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询编制规划明细信息（支持自定义组织） 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询编制规划明细信息（支持自定义组织） 响应体
/// <para>查询编制规划明细，包括维度信息、编制数、预估在职人数、在职人数和预增/预减人数。</para>
/// <para>接口ID：7473343327586435100</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/workforce_plan/batch_v2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fworkforce_plan_detail%2fbatch_v2</para>
/// </summary>
public record PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto : IPageableResponse<PostCorehrV2WorkforcePlanDetailsBatchV2ResponseDto.WorkforcePlanDetailV2>
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
    public WorkforcePlanDetailV2[]? Items { get; set; }

    /// <summary>
    /// <para>编制规划明细信息</para>
    /// </summary>
    public record WorkforcePlanDetailV2
    {
        /// <summary>
        /// <para>编制规划明细 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值："123456"</para>
        /// </summary>
        [JsonPropertyName("workforce_plan_detail_id")]
        public string? WorkforcePlanDetailId { get; set; }

        /// <summary>
        /// <para>维度信息</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("dimension_info_datas")]
        public DimensionInfoData[]? DimensionInfoDatas { get; set; }

        /// <summary>
        /// <para>维度信息</para>
        /// </summary>
        public record DimensionInfoData
        {
            /// <summary>
            /// <para>维度 key</para>
            /// <para>- "department"：部门。</para>
            /// <para>- "employee_type" ：人员类型。</para>
            /// <para>- "location"：地点。</para>
            /// <para>- "position" ：岗位。</para>
            /// <para>- "cost_center" ：成本中心/业务线。</para>
            /// <para>- "job_family" ：序列。</para>
            /// <para>- "job_level" ：职级。</para>
            /// <para>- "job" ：职务。</para>
            /// <para>自定义组织：</para>
            /// <para>- "custom_org_01"</para>
            /// <para>- "custom_org_02"</para>
            /// <para>- "custom_org_03"</para>
            /// <para>- "custom_org_04"</para>
            /// <para>- "custom_org_05"</para>
            /// <para>必填：否</para>
            /// <para>示例值："department"</para>
            /// </summary>
            [JsonPropertyName("dimension_key")]
            public string? DimensionKey { get; set; }

            /// <summary>
            /// <para>维度信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("dimension_info")]
            public DimensionInfoDataDimensionInfo? DimensionInfo { get; set; }

            /// <summary>
            /// <para>维度信息</para>
            /// </summary>
            public record DimensionInfoDataDimensionInfo
            {
                /// <summary>
                /// <para>维度id</para>
                /// <para>- department_id：可从[查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)获得。</para>
                /// <para>- location_id：可从[查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得。</para>
                /// <para>- cost_center_id：可从[查询成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)获得。</para>
                /// <para>- job_id：可从[查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获得。</para>
                /// <para>- job_level_id：可从[查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)获得。</para>
                /// <para>- job_family_id：可从[查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获得。</para>
                /// <para>- employee_type_id：可从[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)获得。</para>
                /// <para>- position_id：岗位，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>- custom_org_01_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>- custom_org_02_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>- custom_org_03_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>- custom_org_04_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>- custom_org_05_id：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
                /// <para>必填：是</para>
                /// <para>示例值：“123456”</para>
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
        }

        /// <summary>
        /// <para>编制规划值</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.00</para>
        /// </summary>
        [JsonPropertyName("workforce_plan")]
        public string? WorkforcePlan { get; set; }

        /// <summary>
        /// <para>在职人数</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.00</para>
        /// </summary>
        [JsonPropertyName("active_individuals")]
        public string? ActiveIndividuals { get; set; }

        /// <summary>
        /// <para>预增员数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.00</para>
        /// </summary>
        [JsonPropertyName("individuals_to_be_added")]
        public string? IndividualsToBeAdded { get; set; }

        /// <summary>
        /// <para>预减员数量</para>
        /// <para>必填：否</para>
        /// <para>示例值：10.00</para>
        /// </summary>
        [JsonPropertyName("individuals_to_be_removed")]
        public string? IndividualsToBeRemoved { get; set; }

        /// <summary>
        /// <para>预估在职人数明细</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("estimated_active_individuals_details")]
        public WorkforcePlanEaiDetail[]? EstimatedActiveIndividualsDetails { get; set; }

        /// <summary>
        /// <para>预估在职人数明细</para>
        /// </summary>
        public record WorkforcePlanEaiDetail
        {
            /// <summary>
            /// <para>预估月份</para>
            /// <para>必填：否</para>
            /// <para>示例值：“2020-10-31”</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>预估在职人数</para>
            /// <para>必填：否</para>
            /// <para>示例值：“10.00”</para>
            /// </summary>
            [JsonPropertyName("estimated_active_individuals")]
            public string? EstimatedActiveIndividuals { get; set; }
        }

        /// <summary>
        /// <para>自然周期的编制规划信息。功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// <para>必填：否</para>
        /// <para>最大长度：15</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("multi_period_values")]
        public WorkforcePlanMultiPeriodValue[]? MultiPeriodValues { get; set; }

        /// <summary>
        /// <para>自然周期的编制规划信息。功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
        /// </summary>
        public record WorkforcePlanMultiPeriodValue
        {
            /// <summary>
            /// <para>自然周期的最后一天</para>
            /// <para>必填：否</para>
            /// <para>示例值：2022-10-31</para>
            /// </summary>
            [JsonPropertyName("period_date")]
            public string? PeriodDate { get; set; }

            /// <summary>
            /// <para>对应自然周期的编制规划值</para>
            /// <para>必填：否</para>
            /// <para>示例值：12.00</para>
            /// </summary>
            [JsonPropertyName("workforce_plan")]
            public string? WorkforcePlan { get; set; }

            /// <summary>
            /// <para>对应自然周期的预增员数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.00</para>
            /// </summary>
            [JsonPropertyName("individuals_to_be_added")]
            public string? IndividualsToBeAdded { get; set; }

            /// <summary>
            /// <para>对应自然周期的预减员数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：10.00</para>
            /// </summary>
            [JsonPropertyName("individuals_to_be_removed")]
            public string? IndividualsToBeRemoved { get; set; }
        }

        /// <summary>
        /// <para>是否为缺维度的明细行，true为缺维度明细行，false为非缺维度明细行</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_missing_dimension")]
        public bool? IsMissingDimension { get; set; }

        /// <summary>
        /// <para>是否在职、预增/预减人员、编制数、预估在职人数都为0的明细行，true代表在职、预增/预减人员、编制数、预估在职人数都为0的明细行，false代表在职、预增/预减人员、编制数、预估在职人数不全为0的明细行</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_all_zero_value")]
        public bool? IsAllZeroValue { get; set; }
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
