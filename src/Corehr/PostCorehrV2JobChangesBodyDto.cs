// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCorehrV2JobChangesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发起员工异动 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 发起员工异动 请求体
/// <para>该接口用于发起员工异动（变更员工雇佣信息），若发起成功，会生成一条员工的异动数据</para>
/// <para>接口ID：7449328616456601619</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fcreate</para>
/// </summary>
public record PostCorehrV2JobChangesBodyDto
{
    /// <summary>
    /// <para>异动方式</para>
    /// <para>必填：是</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：直接异动（无审批）</item>
    /// <item>2：正常异动（完整流程）</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("transfer_mode")]
    public int TransferMode { get; set; }

    /// <summary>
    /// <para>雇员ID，ID 类型与查询参数 user_id_type 的取值一致。</para>
    /// <para>- 当user_id_type=user_id时，该字段取员工的user_id，取值参考user_id_type部分。</para>
    /// <para>- 当user_id_type=people_corehr_id时，则取该员工的人事雇佣ID，可从[雇佣ID](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>异动类型唯一标识，不支持仅在特殊场景使用的异动类型，如组织架构调整、职责转交和试用期转正。</para>
    /// <para>可通过接口[获取异动类型列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_type/query)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：internal_transfer</para>
    /// </summary>
    [JsonPropertyName("transfer_type_unique_identifier")]
    public string TransferTypeUniqueIdentifier { get; set; } = string.Empty;

    /// <summary>
    /// <para>关联流程唯一标识符，可通过接口[获取异动类型列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/transfer_type/query)获取</para>
    /// <para>注意：当异动方式为2时，该字段为必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：people_6963913041981490725_6983885526583627531</para>
    /// </summary>
    [JsonPropertyName("flow_id")]
    public string? FlowId { get; set; }

    /// <summary>
    /// <para>生效日期，格式："YYYY-MM-DD"</para>
    /// <para>必填：是</para>
    /// <para>示例值：2022-03-01</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string EffectiveDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>异动详细信息，以下参数如不传，无默认值，代表对应数据无异动</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("transfer_info")]
    public CreateTransferInfo TransferInfo { get; set; } = new();

    /// <summary>
    /// <para>异动详细信息，以下参数如不传，无默认值，代表对应数据无异动</para>
    /// </summary>
    public record CreateTransferInfo
    {
        /// <summary>
        /// <para>备注</para>
        /// <para>必填：否</para>
        /// <para>示例值：异动详情</para>
        /// </summary>
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// <para>offer信息。</para>
        /// <para>格式为 json 转义：{\"resume_id\": \"xx\", \"resume_detail\": \"yy\"}。</para>
        /// <para>resume_id 为投递ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"resume_id\": \"xx\", \"resume_detail\": \"yy\"}</para>
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
        /// <para>新部门ID，可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("target_department")]
        public string? TargetDepartment { get; set; }

        /// <summary>
        /// <para>新工作地点，可通过[【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967271100992587295</para>
        /// </summary>
        [JsonPropertyName("target_work_location")]
        public string? TargetWorkLocation { get; set; }

        /// <summary>
        /// <para>新直属上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7013619729281713671</para>
        /// </summary>
        [JsonPropertyName("target_direct_manager")]
        public string? TargetDirectManager { get; set; }

        /// <summary>
        /// <para>新虚线上级，可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7013328578351842852</para>
        /// </summary>
        [JsonPropertyName("target_dotted_manager")]
        public string? TargetDottedManager { get; set; }

        /// <summary>
        /// <para>新职务</para>
        /// <para>可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969469557836760606</para>
        /// </summary>
        [JsonPropertyName("target_job")]
        public string? TargetJob { get; set; }

        /// <summary>
        /// <para>新序列ID，可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967287547462419975</para>
        /// </summary>
        [JsonPropertyName("target_job_family")]
        public string? TargetJobFamily { get; set; }

        /// <summary>
        /// <para>新职级ID</para>
        /// <para>可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6972085707674355214</para>
        /// </summary>
        [JsonPropertyName("target_job_level")]
        public string? TargetJobLevel { get; set; }

        /// <summary>
        /// <para>新人员类型，可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7036268995372303885</para>
        /// </summary>
        [JsonPropertyName("target_workforce_type")]
        public string? TargetWorkforceType { get; set; }

        /// <summary>
        /// <para>新人员子类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：7036268995372303885</para>
        /// </summary>
        [JsonPropertyName("target_employee_subtype")]
        public string? TargetEmployeeSubtype { get; set; }

        /// <summary>
        /// <para>新公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974659700705068581</para>
        /// </summary>
        [JsonPropertyName("target_company")]
        public string? TargetCompany { get; set; }

        /// <summary>
        /// <para>新合同编号，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：55333</para>
        /// </summary>
        [JsonPropertyName("target_contract_number")]
        public string? TargetContractNumber { get; set; }

        /// <summary>
        /// <para>新合同类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：labor_contract</para>
        /// </summary>
        [JsonPropertyName("target_contract_type")]
        public string? TargetContractType { get; set; }

        /// <summary>
        /// <para>新期限类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonPropertyName("target_duration_type")]
        public string? TargetDurationType { get; set; }

        /// <summary>
        /// <para>新签订类型，可通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：new</para>
        /// </summary>
        [JsonPropertyName("target_signing_type")]
        public string? TargetSigningType { get; set; }

        /// <summary>
        /// <para>新合同开始日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-01</para>
        /// </summary>
        [JsonPropertyName("target_contract_start_date")]
        public string? TargetContractStartDate { get; set; }

        /// <summary>
        /// <para>新合同结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-07-01</para>
        /// </summary>
        [JsonPropertyName("target_contract_end_date")]
        public string? TargetContractEndDate { get; set; }

        /// <summary>
        /// <para>新工时制度，可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740206087</para>
        /// </summary>
        [JsonPropertyName("target_working_hours_type")]
        public string? TargetWorkingHoursType { get; set; }

        /// <summary>
        /// <para>新工作日历，请开通休假服务后联系管理员获取工作日历数据</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740236087</para>
        /// </summary>
        [JsonPropertyName("target_working_calendar")]
        public string? TargetWorkingCalendar { get; set; }

        /// <summary>
        /// <para>新试用期预计结束日期，格式："YYYY-MM-DD"</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-11-17</para>
        /// </summary>
        [JsonPropertyName("target_probation_end_date")]
        public string? TargetProbationEndDate { get; set; }

        /// <summary>
        /// <para>新周工作时长。取值范围1-168。</para>
        /// <para>必填：否</para>
        /// <para>示例值：160</para>
        /// </summary>
        [JsonPropertyName("target_weekly_working_hours")]
        public string? TargetWeeklyWorkingHours { get; set; }

        /// <summary>
        /// <para>新排班</para>
        /// <para>必填：否</para>
        /// <para>示例值：non_work_shift</para>
        /// </summary>
        [JsonPropertyName("target_work_shift")]
        public string? TargetWorkShift { get; set; }

        /// <summary>
        /// <para>新成本中心分摊方式</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("target_cost_center_rates")]
        public JobDataCostCenter[]? TargetCostCenterRates { get; set; }

        /// <summary>
        /// <para>新成本中心分摊方式</para>
        /// </summary>
        public record JobDataCostCenter
        {
            /// <summary>
            /// <para>支持的成本中心id，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
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
        /// <para>新工作信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("target_employment_change")]
        public TranferEmploymentInfo? TargetEmploymentChange { get; set; }

        /// <summary>
        /// <para>新工作信息</para>
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
                /// <para>自定义字段 apiname，即自定义字段的唯一标识。可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)获取</para>
                /// <para>必填：是</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonPropertyName("custom_api_name")]
                public string CustomApiName { get; set; } = string.Empty;

                /// <summary>
                /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
                /// <para>注意：</para>
                /// <para>1.枚举字段值可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，参考接口返回的 字段详情 &gt; 字段类型配置信息 &gt; 选项配置信息 &gt; 选项信息 &gt; 枚举常量集 API name</para>
                /// <para>必填：是</para>
                /// <para>示例值：\"231\"</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>新职等，可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7289005963599693366</para>
        /// </summary>
        [JsonPropertyName("target_job_grade")]
        public string? TargetJobGrade { get; set; }

        /// <summary>
        /// <para>新薪资类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：salary</para>
        /// </summary>
        [JsonPropertyName("target_compensation_type")]
        public string? TargetCompensationType { get; set; }

        /// <summary>
        /// <para>新任职公司，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：7289005963599693368</para>
        /// </summary>
        [JsonPropertyName("target_service_company")]
        public string? TargetServiceCompany { get; set; }

        /// <summary>
        /// <para>新岗位</para>
        /// <para>必填：否</para>
        /// <para>示例值：7289005963599693367</para>
        /// </summary>
        [JsonPropertyName("target_position")]
        public string? TargetPosition { get; set; }

        /// <summary>
        /// <para>新社保城市</para>
        /// <para>必填：否</para>
        /// <para>示例值：7289005963599693367</para>
        /// </summary>
        [JsonPropertyName("target_social_security_city")]
        public string? TargetSocialSecurityCity { get; set; }

        /// <summary>
        /// <para>编制随人员一起调整</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_transfer_with_workforce")]
        public bool? IsTransferWithWorkforce { get; set; }
    }

    /// <summary>
    /// <para>异动记录标识符，发起失败可以重新用此标志继续请求</para>
    /// <para>必填：否</para>
    /// <para>示例值：transfer_3627531</para>
    /// </summary>
    [JsonPropertyName("transfer_key")]
    public string? TransferKey { get; set; }

    /// <summary>
    /// <para>异动发起人 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>异动原因唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：involuntary_transfer</para>
    /// </summary>
    [JsonPropertyName("transfer_reason_unique_identifier")]
    public string? TransferReasonUniqueIdentifier { get; set; }
}
