// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-10
// ************************************************************************
// <copyright file="PostCorehrV2JobChangesSearchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索员工异动信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工异动信息 响应体
/// <para>搜索异动信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042150916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fsearch</para>
/// </summary>
public record PostCorehrV2JobChangesSearchResponseDto : IPageableResponse<PostCorehrV2JobChangesSearchResponseDto.JobChange>
{
    /// <summary>
    /// <para>员工异动列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public JobChange[]? Items { get; set; }

    /// <summary>
    /// <para>员工异动列表</para>
    /// </summary>
    public record JobChange
    {
        /// <summary>
        /// <para>异动记录 id，可通过接口</para>
        /// <para>[搜索异动信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_change/search)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonPropertyName("job_change_id")]
        public string? JobChangeId { get; set; }

        /// <summary>
        /// <para>雇员 id，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string? EmploymentId { get; set; }

        /// <summary>
        /// <para>异动状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：Approved</para>
        /// <para>可选值：<list type="bullet">
        /// <item>Approving：审批中</item>
        /// <item>Approved：审批通过</item>
        /// <item>Transformed：已异动</item>
        /// <item>Rejected：已拒绝</item>
        /// <item>Cancelled：已撤销</item>
        /// <item>NoNeedApproval：无需审批</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>异动类型，可通过接口</para>
        /// <para>[获取异动类型列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_type/query)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：direct_leader_change</para>
        /// </summary>
        [JsonPropertyName("transfer_type_unique_identifier")]
        public string? TransferTypeUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动原因，可通过接口</para>
        /// <para>[获取异动原因列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_reason/query)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：involuntary_transfer</para>
        /// </summary>
        [JsonPropertyName("transfer_reason_unique_identifier")]
        public string? TransferReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动流程 id，可通过【流程-获取单个流程详情】接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776078461142564</para>
        /// </summary>
        [JsonPropertyName("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>生效时间，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-03-01</para>
        /// </summary>
        [JsonPropertyName("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>创建时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1627899724000</para>
        /// </summary>
        [JsonPropertyName("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间，毫秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1647434443000</para>
        /// </summary>
        [JsonPropertyName("updated_time")]
        public string? UpdatedTime { get; set; }

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
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：异动详情</para>
            /// </summary>
            [JsonPropertyName("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>offer信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：优质人才，加急处理</para>
            /// </summary>
            [JsonPropertyName("offer_info")]
            public string? OfferInfo { get; set; }

            /// <summary>
            /// <para>是否撤销虚线上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonPropertyName("target_dotted_manager_clean")]
            public bool? TargetDottedManagerClean { get; set; }

            /// <summary>
            /// <para>是否有试用期</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("probation_exist")]
            public bool? ProbationExist { get; set; }

            /// <summary>
            /// <para>原部门，可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonPropertyName("original_department")]
            public string? OriginalDepartment { get; set; }

            /// <summary>
            /// <para>新部门，可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonPropertyName("target_department")]
            public string? TargetDepartment { get; set; }

            /// <summary>
            /// <para>原工作地点，可通过[【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967271100992587295</para>
            /// </summary>
            [JsonPropertyName("original_work_location")]
            public string? OriginalWorkLocation { get; set; }

            /// <summary>
            /// <para>新工作地点，可通过[【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967271100992587295</para>
            /// </summary>
            [JsonPropertyName("target_work_location")]
            public string? TargetWorkLocation { get; set; }

            /// <summary>
            /// <para>原直属上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974641477444060708</para>
            /// </summary>
            [JsonPropertyName("original_direct_manager")]
            public string? OriginalDirectManager { get; set; }

            /// <summary>
            /// <para>新直属上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013619729281713671</para>
            /// </summary>
            [JsonPropertyName("target_direct_manager")]
            public string? TargetDirectManager { get; set; }

            /// <summary>
            /// <para>原虚线上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974648866876573198</para>
            /// </summary>
            [JsonPropertyName("original_dotted_manager")]
            public string? OriginalDottedManager { get; set; }

            /// <summary>
            /// <para>新虚线上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013328578351842852</para>
            /// </summary>
            [JsonPropertyName("target_dotted_manager")]
            public string? TargetDottedManager { get; set; }

            /// <summary>
            /// <para>原职务</para>
            /// <para>可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469398088287751</para>
            /// </summary>
            [JsonPropertyName("original_job")]
            public string? OriginalJob { get; set; }

            /// <summary>
            /// <para>新职务</para>
            /// <para>可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469557836760606</para>
            /// </summary>
            [JsonPropertyName("target_job")]
            public string? TargetJob { get; set; }

            /// <summary>
            /// <para>原序列，可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonPropertyName("original_job_family")]
            public string? OriginalJobFamily { get; set; }

            /// <summary>
            /// <para>新序列，可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonPropertyName("target_job_family")]
            public string? TargetJobFamily { get; set; }

            /// <summary>
            /// <para>原职级</para>
            /// <para>可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonPropertyName("original_job_level")]
            public string? OriginalJobLevel { get; set; }

            /// <summary>
            /// <para>新级别</para>
            /// <para>可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonPropertyName("target_job_level")]
            public string? TargetJobLevel { get; set; }

            /// <summary>
            /// <para>原人员类型，可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6968386026792289828</para>
            /// </summary>
            [JsonPropertyName("original_workforce_type")]
            public string? OriginalWorkforceType { get; set; }

            /// <summary>
            /// <para>新人员类型，可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7036268995372303885</para>
            /// </summary>
            [JsonPropertyName("target_workforce_type")]
            public string? TargetWorkforceType { get; set; }

            /// <summary>
            /// <para>原人员子类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：6968386026792289828</para>
            /// </summary>
            [JsonPropertyName("original_employee_subtype")]
            public string? OriginalEmployeeSubtype { get; set; }

            /// <summary>
            /// <para>新人员子类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：7036268995372303885</para>
            /// </summary>
            [JsonPropertyName("target_employee_subtype")]
            public string? TargetEmployeeSubtype { get; set; }

            /// <summary>
            /// <para>原公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("original_company")]
            public string? OriginalCompany { get; set; }

            /// <summary>
            /// <para>新公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonPropertyName("target_company")]
            public string? TargetCompany { get; set; }

            /// <summary>
            /// <para>原合同编号，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：55332</para>
            /// </summary>
            [JsonPropertyName("original_contract_number")]
            public string? OriginalContractNumber { get; set; }

            /// <summary>
            /// <para>新合同编号，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：55333</para>
            /// </summary>
            [JsonPropertyName("target_contract_number")]
            public string? TargetContractNumber { get; set; }

            /// <summary>
            /// <para>原合同类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonPropertyName("original_contract_type")]
            public string? OriginalContractType { get; set; }

            /// <summary>
            /// <para>新合同类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonPropertyName("target_contract_type")]
            public string? TargetContractType { get; set; }

            /// <summary>
            /// <para>原期限类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonPropertyName("original_duration_type")]
            public string? OriginalDurationType { get; set; }

            /// <summary>
            /// <para>新期限类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonPropertyName("target_duration_type")]
            public string? TargetDurationType { get; set; }

            /// <summary>
            /// <para>原签订类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：new</para>
            /// </summary>
            [JsonPropertyName("original_signing_type")]
            public string? OriginalSigningType { get; set; }

            /// <summary>
            /// <para>新签订类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：new</para>
            /// </summary>
            [JsonPropertyName("target_signing_type")]
            public string? TargetSigningType { get; set; }

            /// <summary>
            /// <para>原合同开始日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-07-01</para>
            /// </summary>
            [JsonPropertyName("original_contract_start_date")]
            public string? OriginalContractStartDate { get; set; }

            /// <summary>
            /// <para>新合同开始日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-07-01</para>
            /// </summary>
            [JsonPropertyName("target_contract_start_date")]
            public string? TargetContractStartDate { get; set; }

            /// <summary>
            /// <para>原合同结束日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-07-01</para>
            /// </summary>
            [JsonPropertyName("original_contract_end_date")]
            public string? OriginalContractEndDate { get; set; }

            /// <summary>
            /// <para>新合同结束日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-07-01</para>
            /// </summary>
            [JsonPropertyName("target_contract_end_date")]
            public string? TargetContractEndDate { get; set; }

            /// <summary>
            /// <para>原工时制度可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740206087</para>
            /// </summary>
            [JsonPropertyName("original_working_hours_type")]
            public string? OriginalWorkingHoursType { get; set; }

            /// <summary>
            /// <para>新工时制度，可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740206087</para>
            /// </summary>
            [JsonPropertyName("target_working_hours_type")]
            public string? TargetWorkingHoursType { get; set; }

            /// <summary>
            /// <para>原工作日历，开通休假服务后联系管理员获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740236087</para>
            /// </summary>
            [JsonPropertyName("original_working_calendar")]
            public string? OriginalWorkingCalendar { get; set; }

            /// <summary>
            /// <para>新工作日历，开通休假服务后联系管理员获取。</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740236087</para>
            /// </summary>
            [JsonPropertyName("target_working_calendar")]
            public string? TargetWorkingCalendar { get; set; }

            /// <summary>
            /// <para>原试用期预计结束日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-11-17</para>
            /// </summary>
            [JsonPropertyName("original_probation_end_date")]
            public string? OriginalProbationEndDate { get; set; }

            /// <summary>
            /// <para>新试用期预计结束日期，格式："YYYY-MM-DD"</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-11-17</para>
            /// </summary>
            [JsonPropertyName("target_probation_end_date")]
            public string? TargetProbationEndDate { get; set; }

            /// <summary>
            /// <para>原周工作时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：162</para>
            /// </summary>
            [JsonPropertyName("original_weekly_working_hours")]
            public string? OriginalWeeklyWorkingHours { get; set; }

            /// <summary>
            /// <para>新周工作时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：160</para>
            /// </summary>
            [JsonPropertyName("target_weekly_working_hours")]
            public string? TargetWeeklyWorkingHours { get; set; }

            /// <summary>
            /// <para>原排班</para>
            /// <para>必填：否</para>
            /// <para>示例值：work_shift</para>
            /// </summary>
            [JsonPropertyName("original_work_shift")]
            public string? OriginalWorkShift { get; set; }

            /// <summary>
            /// <para>新排班</para>
            /// <para>必填：否</para>
            /// <para>示例值：non_work_shift</para>
            /// </summary>
            [JsonPropertyName("target_work_shift")]
            public string? TargetWorkShift { get; set; }

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
                /// <para>成本中心 ID，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950635856373745165</para>
                /// </summary>
                [JsonPropertyName("cost_center_id")]
                public string? CostCenterId { get; set; }

                /// <summary>
                /// <para>分摊比例(整数)</para>
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
            /// <para>原工作信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("original_employment_change")]
            public TranferEmploymentInfo? OriginalEmploymentChange { get; set; }

            /// <summary>
            /// <para>原工作信息</para>
            /// </summary>
            public record TranferEmploymentInfo
            {
                /// <summary>
                /// <para>转正式员工日期，格式："YYYY-MM-DD"</para>
                /// <para>必填：否</para>
                /// <para>示例值：2023-01-01</para>
                /// </summary>
                [JsonPropertyName("regular_employee_start_date")]
                public string? RegularEmployeeStartDate { get; set; }

                /// <summary>
                /// <para>司龄起算日期，格式："YYYY-MM-DD"</para>
                /// <para>必填：否</para>
                /// <para>示例值：2023-01-01</para>
                /// </summary>
                [JsonPropertyName("seniority_date")]
                public string? SeniorityDate { get; set; }

                /// <summary>
                /// <para>员工编号，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
                /// <para>必填：否</para>
                /// <para>示例值：1111111</para>
                /// </summary>
                [JsonPropertyName("employee_number")]
                public string? EmployeeNumber { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("custom_fields")]
                public CustomFieldData[]? CustomFields { get; set; }

                /// <summary>
                /// <para>自定义字段</para>
                /// </summary>
                public record CustomFieldData
                {
                    /// <summary>
                    /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：name</para>
                    /// </summary>
                    [JsonPropertyName("custom_api_name")]
                    public string CustomApiName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CustomName? Name { get; set; }

                    /// <summary>
                    /// <para>自定义字段名称</para>
                    /// </summary>
                    public record CustomName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：自定义姓名</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：Custom Name</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>自定义字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：231</para>
                    /// </summary>
                    [JsonPropertyName("value")]
                    public string Value { get; set; } = string.Empty;
                }
            }

            /// <summary>
            /// <para>新工作信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("target_employment_change")]
            public TranferEmploymentInfo? TargetEmploymentChange { get; set; }

            /// <summary>
            /// <para>原职等，可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693366</para>
            /// </summary>
            [JsonPropertyName("original_job_grade")]
            public string? OriginalJobGrade { get; set; }

            /// <summary>
            /// <para>新职等，可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口获取</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693366</para>
            /// </summary>
            [JsonPropertyName("target_job_grade")]
            public string? TargetJobGrade { get; set; }

            /// <summary>
            /// <para>原薪资类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：hourly</para>
            /// </summary>
            [JsonPropertyName("original_compensation_type")]
            public string? OriginalCompensationType { get; set; }

            /// <summary>
            /// <para>新薪资类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：salary</para>
            /// </summary>
            [JsonPropertyName("target_compensation_type")]
            public string? TargetCompensationType { get; set; }

            /// <summary>
            /// <para>原任职公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("original_service_company")]
            public string? OriginalServiceCompany { get; set; }

            /// <summary>
            /// <para>新任职公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_service_company")]
            public string? TargetServiceCompany { get; set; }

            /// <summary>
            /// <para>原岗位，可通过【岗职务管理-岗位】相关API获取（目前仅灰度部分租户，如需要请联系管理员开灰）</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("original_position")]
            public string? OriginalPosition { get; set; }

            /// <summary>
            /// <para>新岗位，可通过【岗职务管理-岗位】相关API获取（目前仅灰度部分租户，如需要请联系管理员开灰）</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_position")]
            public string? TargetPosition { get; set; }

            /// <summary>
            /// <para>原社保城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("original_social_security_city")]
            public string? OriginalSocialSecurityCity { get; set; }

            /// <summary>
            /// <para>新社保城市</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_social_security_city")]
            public string? TargetSocialSecurityCity { get; set; }

            /// <summary>
            /// <para>原通道</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("original_pathway")]
            public string? OriginalPathway { get; set; }

            /// <summary>
            /// <para>新通道</para>
            /// <para>必填：否</para>
            /// <para>示例值：7289005963599693367</para>
            /// </summary>
            [JsonPropertyName("target_pathway")]
            public string? TargetPathway { get; set; }

            /// <summary>
            /// <para>编制随人员一起调整</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_transfer_with_workforce")]
            public bool? IsTransferWithWorkforce { get; set; }
        }

        /// <summary>
        /// <para>是否调整薪酬</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_adjust_salary")]
        public bool? IsAdjustSalary { get; set; }

        /// <summary>
        /// <para>异动自定义字段</para>
        /// <para>必填：否</para>
        /// <para>最大长度：200</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("custom_fields")]
        public CustomFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>异动自定义字段</para>
        /// </summary>
        public record CustomFieldData
        {
            /// <summary>
            /// <para>自定义字段 apiname，即自定义字段的唯一标识</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonPropertyName("custom_api_name")]
            public string CustomApiName { get; set; } = string.Empty;

            /// <summary>
            /// <para>自定义字段名称</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("name")]
            public CustomName? Name { get; set; }

            /// <summary>
            /// <para>自定义字段名称</para>
            /// </summary>
            public record CustomName
            {
                /// <summary>
                /// <para>中文</para>
                /// <para>必填：否</para>
                /// <para>示例值：自定义姓名</para>
                /// </summary>
                [JsonPropertyName("zh_cn")]
                public string? ZhCn { get; set; }

                /// <summary>
                /// <para>英文</para>
                /// <para>必填：否</para>
                /// <para>示例值：Custom Name</para>
                /// </summary>
                [JsonPropertyName("en_us")]
                public string? EnUs { get; set; }
            }

            /// <summary>
            /// <para>自定义字段类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonPropertyName("type")]
            public int? Type { get; set; }

            /// <summary>
            /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"231\"</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891251722631890445</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
