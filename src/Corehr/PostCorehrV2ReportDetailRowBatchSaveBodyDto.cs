// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-12
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="PostCorehrV2ReportDetailRowBatchSaveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量创建/更新填报行 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量创建/更新填报行 请求体
/// <para>批量创建/更新填报行后，可在【设置-编制规划设置-编制规划XXX-集中填报】进行查看。</para>
/// <para>接口ID：7446337145820069892</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/report_detail_row/batchSave</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2freport_detail_row%2fbatchSave</para>
/// </summary>
public record PostCorehrV2ReportDetailRowBatchSaveBodyDto
{
    /// <summary>
    /// <para>编制规划id，可在「设置-编制规划设置-编制规划XXX-页面URL」中解析到。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7430330781544564268</para>
    /// </summary>
    [JsonPropertyName("workforce_plan_id")]
    public string WorkforcePlanId { get; set; } = string.Empty;

    /// <summary>
    /// <para>集中填报id，可在「设置-编制规划设置-编制规划XXX-集中填报XXX」中解析到。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7430470688844023340</para>
    /// </summary>
    [JsonPropertyName("centralized_reporting_project_id")]
    public string CentralizedReportingProjectId { get; set; } = string.Empty;

    /// <summary>
    /// <para>集中填报的填报行数量应介于 1 至 5 个之间。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：5</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("items")]
    public WorkforcePlanDetailRow[] Items { get; set; } = Array.Empty<WorkforcePlanDetailRow>();

    /// <summary>
    /// <para>集中填报的填报行数量应介于 1 至 5 个之间。</para>
    /// </summary>
    public record WorkforcePlanDetailRow
    {
        /// <summary>
        /// <para>集中填报的维度信息要和用户创建的维度匹配，即传入除自动匹配维度外的所有维度，不多不少。</para>
        /// <para>通过「设置-编制规划设置-编制规划XXX」查看该编制规划有哪些维度。</para>
        /// <para>自定义组织维度是否为自动匹配的维度则通过「设置-组织配置-自定义组织XXX-查看为组织设置自动匹配规则」，“是”代表该维度为自动匹配维度。</para>
        /// <para>必填：是</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("dimensions")]
        public DimensionEntity[] Dimensions { get; set; } = Array.Empty<DimensionEntity>();

        /// <summary>
        /// <para>集中填报的维度信息要和用户创建的维度匹配，即传入除自动匹配维度外的所有维度，不多不少。</para>
        /// <para>通过「设置-编制规划设置-编制规划XXX」查看该编制规划有哪些维度。</para>
        /// <para>自定义组织维度是否为自动匹配的维度则通过「设置-组织配置-自定义组织XXX-查看为组织设置自动匹配规则」，“是”代表该维度为自动匹配维度。</para>
        /// </summary>
        public record DimensionEntity
        {
            /// <summary>
            /// <para>维度key，可从下面列表中进行选择：</para>
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
            /// <para>必填：是</para>
            /// <para>示例值：department</para>
            /// </summary>
            [JsonPropertyName("dimension_key")]
            public string DimensionKey { get; set; } = string.Empty;

            /// <summary>
            /// <para>维度value。</para>
            /// <para>- department：可从[查询部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)获得。</para>
            /// <para>- location：可从[查询地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得。</para>
            /// <para>- cost_center：可从[查询成本中心](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得。</para>
            /// <para>- job：可从[查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获得。</para>
            /// <para>- job_level：可从[查询职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)获得。</para>
            /// <para>- job_family：可从[查询序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获得。</para>
            /// <para>- employee_type：可从[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/list)获得。</para>
            /// <para>- position：岗位，功能灰度中，如有需求请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>- custom_org_01：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>- custom_org_02：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>- custom_org_03：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>- custom_org_04：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>- custom_org_05：自定义组织，功能灰度中，有需要请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
            /// <para>必填：是</para>
            /// <para>示例值：7322790168290739756</para>
            /// </summary>
            [JsonPropertyName("dimension_value")]
            public string DimensionValue { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>预估在职人数相关信息。可从「设置-编制规划设置-编制规划XXX-集中填报」查看预估在职人数的时间，如果不存在该字段说明用户创建时即没有允许填写该字段，批量创建/更新填报行时则无需给该字段，如果存在，用户需要查看预估在职人数的日期，使用示例值格式进行传参。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：15</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("eai_details")]
        public WorkforcePlanEaiDetail[]? EaiDetails { get; set; }

        /// <summary>
        /// <para>预估在职人数相关信息。可从「设置-编制规划设置-编制规划XXX-集中填报」查看预估在职人数的时间，如果不存在该字段说明用户创建时即没有允许填写该字段，批量创建/更新填报行时则无需给该字段，如果存在，用户需要查看预估在职人数的日期，使用示例值格式进行传参。</para>
        /// </summary>
        public record WorkforcePlanEaiDetail
        {
            /// <summary>
            /// <para>预估在职人数的日期，和集中填报页面上显示的预估在职人数的日期一致，且格式要依照示例给定，若二者不匹配，则无法完成识别更新。</para>
            /// <para>必填：否</para>
            /// <para>示例值：2020-10-31</para>
            /// </summary>
            [JsonPropertyName("date")]
            public string? Date { get; set; }

            /// <summary>
            /// <para>预估在职人数应与创建编制规划时指定的小数位数相匹配，若不匹配，则无法更新。小数位查看方式：「设置-编制规划-编制规划XXX」查看预估在职人数的小数位数。</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonPropertyName("estimated_active_individuals")]
            public string? EstimatedActiveIndividuals { get; set; }
        }

        /// <summary>
        /// <para>编制规划值需与创建编制规划时指定的小数位数相匹配，若不匹配，则无法更新。小数位查看方式：「设置-编制规划-编制规划XXX」查看编制规划的小数位数。</para>
        /// <para>必填：否</para>
        /// <para>示例值：12</para>
        /// </summary>
        [JsonPropertyName("plan_value")]
        public string? PlanValue { get; set; }
    }
}
