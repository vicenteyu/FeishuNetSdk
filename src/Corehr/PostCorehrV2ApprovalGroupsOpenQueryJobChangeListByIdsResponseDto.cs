// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-11-22
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询人员调整内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询人员调整内容 响应体
/// <para>根据人员异动记录 ID 批量查询人员调整内容</para>
/// <para>接口ID：7317581509003788292</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_job_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_job_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsResponseDto
{
    /// <summary>
    /// <para>人员异动记录信息列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_changes")]
    public JobChange[]? JobChanges { get; set; }

    /// <summary>
    /// <para>人员异动记录信息列表</para>
    /// </summary>
    public record JobChange
    {
        /// <summary>
        /// <para>异动记录 id, 在组织架构调整发起后，会为调整涉及的员工生成一个 员工异动记录， 对应的记录 ID 即为 job_change_id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("job_change_id")]
        public string? JobChangeId { get; set; }

        /// <summary>
        /// <para>雇员 id, 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>异动详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("transfer_info")]
        public JobChangeTransferInfo? TransferInfo { get; set; }

        /// <summary>
        /// <para>异动详细信息</para>
        /// </summary>
        public record JobChangeTransferInfo
        {
            /// <summary>
            /// <para>原部门，可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)获取详情，ID 类型需要为 ==people_corehr_department_id==。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonPropertyName("original_department")]
            public string? OriginalDepartment { get; set; }

            /// <summary>
            /// <para>新部门, 如果是一个已存在的部门， 则会使用其飞书人事部门 ID 作为调整记录 ID，可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)获取详情，ID 类型需要为==people_corehr_id==</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonPropertyName("target_department")]
            public string? TargetDepartment { get; set; }

            /// <summary>
            /// <para>新部门，为避免一个没有经过审批的组织架构调整影响正在运行的系统，如果是在组织架构调整中新生成的『部门』生成临时的 ID， 格式 "td_</para>
            /// <para>xxx"</para>
            /// <para>可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/open_query_department_change_list_by_ids)获取详情，ID 类型需要为 ==people_corehr_department_id==。</para>
            /// <para>必填：否</para>
            /// <para>示例值：td_704442734715974602312</para>
            /// </summary>
            [JsonPropertyName("target_draft_department")]
            public string? TargetDraftDepartment { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表, 主要用于 API 场景， 没有审批完成前获取部门路径用于计算。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_department_id_path")]
            public OrgdraftDepartmentId[]? OriginalDepartmentIdPaths { get; set; }

            /// <summary>
            /// <para>原部门全路径，从根部门开始自上而下返回部门 ID 列表, 主要用于 API 场景， 没有审批完成前获取部门路径用于计算。</para>
            /// </summary>
            public record OrgdraftDepartmentId
            {
                /// <summary>
                /// <para>部门 ID ，对于在本次调整中新建的部门，在调整未生效时将返回为空。支持根据部门 ID 类型转换。</para>
                /// <para>必填：否</para>
                /// <para>示例值：6974659700705068581</para>
                /// </summary>
                [JsonPropertyName("department_id")]
                public string? DepartmentId { get; set; }

                /// <summary>
                /// <para>调整过程部门 ID ，固定返回people_corehr_department_id，不会根据部门 ID 类型进行转换。对于在本次调整中新建的部门，在调整未生效前会返回格式为 td_xxx 的过程部门 ID，生效后将返回正式的people_corehr_department_id</para>
                /// <para>必填：否</para>
                /// <para>示例值：6974659700705068581</para>
                /// </summary>
                [JsonPropertyName("draft_department_id")]
                public string? DraftDepartmentId { get; set; }
            }

            /// <summary>
            /// <para>新部门全路径，从根部门开始自上而下返回部门 ID 列表</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_department_id_path")]
            public OrgdraftDepartmentId[]? TargetDepartmentIdPaths { get; set; }

            /// <summary>
            /// <para>原直属上级， 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974641477444060708</para>
            /// </summary>
            [JsonPropertyName("original_direct_manager")]
            public string? OriginalDirectManager { get; set; }

            /// <summary>
            /// <para>新直属上级， 详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013619729281713671</para>
            /// </summary>
            [JsonPropertyName("target_direct_manager")]
            public string? TargetDirectManager { get; set; }

            /// <summary>
            /// <para>原职务， 可通过[查询单个职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469398088287751</para>
            /// </summary>
            [JsonPropertyName("original_job")]
            public string? OriginalJob { get; set; }

            /// <summary>
            /// <para>新职务，可通过[查询单个职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469557836760606</para>
            /// </summary>
            [JsonPropertyName("target_job")]
            public string? TargetJob { get; set; }

            /// <summary>
            /// <para>原序列， 可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonPropertyName("original_job_family")]
            public string? OriginalJobFamily { get; set; }

            /// <summary>
            /// <para>新序列， 可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonPropertyName("target_job_family")]
            public string? TargetJobFamily { get; set; }

            /// <summary>
            /// <para>原职级，可通过[查询单个职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonPropertyName("original_job_level")]
            public string? OriginalJobLevel { get; set; }

            /// <summary>
            /// <para>新职级，可通过[查询单个职级](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonPropertyName("target_job_level")]
            public string? TargetJobLevel { get; set; }

            /// <summary>
            /// <para>原成本中心分摊方式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_cost_center_rate")]
            public JobDataCostCenter[]? OriginalCostCenterRates { get; set; }

            /// <summary>
            /// <para>原成本中心分摊方式</para>
            /// </summary>
            public record JobDataCostCenter
            {
                /// <summary>
                /// <para>成本中心 ID，可以通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950635856373745165</para>
                /// </summary>
                [JsonPropertyName("cost_center_id")]
                public string? CostCenterId { get; set; }

                /// <summary>
                /// <para>分摊比例</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonPropertyName("rate")]
                public int? Rate { get; set; }
            }

            /// <summary>
            /// <para>新成本中心分摊方式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_cost_center_rate")]
            public JobDataCostCenter[]? TargetCostCenterRates { get; set; }

            /// <summary>
            /// <para>原职等， 可通过[查询单个职等](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693366</para>
            /// </summary>
            [JsonPropertyName("original_job_grade")]
            public string? OriginalJobGrade { get; set; }

            /// <summary>
            /// <para>新职等， 可通过[查询单个职等](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693366</para>
            /// </summary>
            [JsonPropertyName("target_job_grade")]
            public string? TargetJobGrade { get; set; }

            /// <summary>
            /// <para>原岗位</para>
            /// <para>- 功能灰度中，开通岗位功能后可通过接口【查询岗位信息】获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("original_position")]
            public string? OriginalPosition { get; set; }

            /// <summary>
            /// <para>新岗位</para>
            /// <para>- 功能灰度中，如果是一个已存在的岗位，开通岗位功能后可通过接口【查询岗位信息】获取详情。</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_position")]
            public string? TargetPosition { get; set; }

            /// <summary>
            /// <para>新岗位(调整过程岗位 ID )</para>
            /// <para>- 对于在本次调整中新建的岗位，在调整未生效前会返回格式为 td_xxx 的过程岗位 ID，生效后将返回正式的岗位ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：td_7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_draft_position")]
            public string? TargetDraftPosition { get; set; }
        }
    }
}
