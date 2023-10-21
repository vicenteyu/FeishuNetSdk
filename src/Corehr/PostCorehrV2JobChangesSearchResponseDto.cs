using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索员工异动信息 响应体
/// <para>搜索异动信息，该接口会按照应用拥有的「员工数据」的权限范围返回数据，请确定在「开发者后台 - 权限管理 - 数据权限」中有申请「员工资源」权限范围</para>
/// <para>接口ID：7211423970042150916</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fsearch</para>
/// </summary>
public record PostCorehrV2JobChangesSearchResponseDto
{
    /// <summary>
    /// <para>员工异动列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public JobChange[]? Items { get; set; }

    /// <summary>
    /// <para>员工异动列表</para>
    /// </summary>
    public record JobChange
    {
        /// <summary>
        /// <para>异动记录 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776076699549697</para>
        /// </summary>
        [JsonProperty("job_change_id")]
        public string? JobChangeId { get; set; }

        /// <summary>
        /// <para>雇员 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
        /// </summary>
        [JsonProperty("employment_id")]
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
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <para>异动类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：direct_leader_change</para>
        /// </summary>
        [JsonProperty("transfer_type_unique_identifier")]
        public string? TransferTypeUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：involuntary_transfer</para>
        /// </summary>
        [JsonProperty("transfer_reason_unique_identifier")]
        public string? TransferReasonUniqueIdentifier { get; set; }

        /// <summary>
        /// <para>异动流程 id</para>
        /// <para>必填：否</para>
        /// <para>示例值：6991776078461142564</para>
        /// </summary>
        [JsonProperty("process_id")]
        public string? ProcessId { get; set; }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2022-03-01</para>
        /// </summary>
        [JsonProperty("effective_date")]
        public string? EffectiveDate { get; set; }

        /// <summary>
        /// <para>创建时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1627899724000</para>
        /// </summary>
        [JsonProperty("created_time")]
        public string? CreatedTime { get; set; }

        /// <summary>
        /// <para>更新时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1647434443000</para>
        /// </summary>
        [JsonProperty("updated_time")]
        public string? UpdatedTime { get; set; }

        /// <summary>
        /// <para>异动详细信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("transfer_info")]
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
            [JsonProperty("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>offer信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：优质人才，加急处理</para>
            /// </summary>
            [JsonProperty("offer_info")]
            public string? OfferInfo { get; set; }

            /// <summary>
            /// <para>是否撤销虚线上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// </summary>
            [JsonProperty("target_dotted_manager_clean")]
            public bool? TargetDottedManagerClean { get; set; }

            /// <summary>
            /// <para>是否有试用期</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonProperty("probation_exist")]
            public bool? ProbationExist { get; set; }

            /// <summary>
            /// <para>原部门</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonProperty("original_department")]
            public string? OriginalDepartment { get; set; }

            /// <summary>
            /// <para>新部门</para>
            /// <para>必填：否</para>
            /// <para>示例值：6966236933198579208</para>
            /// </summary>
            [JsonProperty("target_department")]
            public string? TargetDepartment { get; set; }

            /// <summary>
            /// <para>原工作地点</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967271100992587295</para>
            /// </summary>
            [JsonProperty("original_work_location")]
            public string? OriginalWorkLocation { get; set; }

            /// <summary>
            /// <para>新工作地点</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967271100992587295</para>
            /// </summary>
            [JsonProperty("target_work_location")]
            public string? TargetWorkLocation { get; set; }

            /// <summary>
            /// <para>原直属上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974641477444060708</para>
            /// </summary>
            [JsonProperty("original_direct_manager")]
            public string? OriginalDirectManager { get; set; }

            /// <summary>
            /// <para>新直属上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013619729281713671</para>
            /// </summary>
            [JsonProperty("target_direct_manager")]
            public string? TargetDirectManager { get; set; }

            /// <summary>
            /// <para>原虚线上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974648866876573198</para>
            /// </summary>
            [JsonProperty("original_dotted_manager")]
            public string? OriginalDottedManager { get; set; }

            /// <summary>
            /// <para>新虚线上级</para>
            /// <para>必填：否</para>
            /// <para>示例值：7013328578351842852</para>
            /// </summary>
            [JsonProperty("target_dotted_manager")]
            public string? TargetDottedManager { get; set; }

            /// <summary>
            /// <para>原职务</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469398088287751</para>
            /// </summary>
            [JsonProperty("original_job")]
            public string? OriginalJob { get; set; }

            /// <summary>
            /// <para>新职务</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969469557836760606</para>
            /// </summary>
            [JsonProperty("target_job")]
            public string? TargetJob { get; set; }

            /// <summary>
            /// <para>原序列</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonProperty("original_job_family")]
            public string? OriginalJobFamily { get; set; }

            /// <summary>
            /// <para>新序列</para>
            /// <para>必填：否</para>
            /// <para>示例值：6967287547462419975</para>
            /// </summary>
            [JsonProperty("target_job_family")]
            public string? TargetJobFamily { get; set; }

            /// <summary>
            /// <para>原级别</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonProperty("original_job_level")]
            public string? OriginalJobLevel { get; set; }

            /// <summary>
            /// <para>新级别</para>
            /// <para>必填：否</para>
            /// <para>示例值：6972085707674355214</para>
            /// </summary>
            [JsonProperty("target_job_level")]
            public string? TargetJobLevel { get; set; }

            /// <summary>
            /// <para>原人员类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：6968386026792289828</para>
            /// </summary>
            [JsonProperty("original_workforce_type")]
            public string? OriginalWorkforceType { get; set; }

            /// <summary>
            /// <para>新人员类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：7036268995372303885</para>
            /// </summary>
            [JsonProperty("target_workforce_type")]
            public string? TargetWorkforceType { get; set; }

            /// <summary>
            /// <para>原公司</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonProperty("original_company")]
            public string? OriginalCompany { get; set; }

            /// <summary>
            /// <para>新公司</para>
            /// <para>必填：否</para>
            /// <para>示例值：6974659700705068581</para>
            /// </summary>
            [JsonProperty("target_company")]
            public string? TargetCompany { get; set; }

            /// <summary>
            /// <para>原合同编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：55332</para>
            /// </summary>
            [JsonProperty("original_contract_number")]
            public string? OriginalContractNumber { get; set; }

            /// <summary>
            /// <para>新合同编号</para>
            /// <para>必填：否</para>
            /// <para>示例值：55333</para>
            /// </summary>
            [JsonProperty("target_contract_number")]
            public string? TargetContractNumber { get; set; }

            /// <summary>
            /// <para>原合同类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonProperty("original_contract_type")]
            public string? OriginalContractType { get; set; }

            /// <summary>
            /// <para>新合同类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：labor_contract</para>
            /// </summary>
            [JsonProperty("target_contract_type")]
            public string? TargetContractType { get; set; }

            /// <summary>
            /// <para>原期限类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonProperty("original_duration_type")]
            public string? OriginalDurationType { get; set; }

            /// <summary>
            /// <para>新期限类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：fixed_term</para>
            /// </summary>
            [JsonProperty("target_duration_type")]
            public string? TargetDurationType { get; set; }

            /// <summary>
            /// <para>原签订类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：new</para>
            /// </summary>
            [JsonProperty("original_signing_type")]
            public string? OriginalSigningType { get; set; }

            /// <summary>
            /// <para>新签订类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：new</para>
            /// </summary>
            [JsonProperty("target_signing_type")]
            public string? TargetSigningType { get; set; }

            /// <summary>
            /// <para>原合同开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-07-01</para>
            /// </summary>
            [JsonProperty("original_contract_start_date")]
            public string? OriginalContractStartDate { get; set; }

            /// <summary>
            /// <para>新合同开始日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-07-01</para>
            /// </summary>
            [JsonProperty("target_contract_start_date")]
            public string? TargetContractStartDate { get; set; }

            /// <summary>
            /// <para>原合同结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-07-01</para>
            /// </summary>
            [JsonProperty("original_contract_end_date")]
            public string? OriginalContractEndDate { get; set; }

            /// <summary>
            /// <para>新合同结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2024-07-01</para>
            /// </summary>
            [JsonProperty("target_contract_end_date")]
            public string? TargetContractEndDate { get; set; }

            /// <summary>
            /// <para>原工时制度</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740206087</para>
            /// </summary>
            [JsonProperty("original_working_hours_type")]
            public string? OriginalWorkingHoursType { get; set; }

            /// <summary>
            /// <para>新工时制度</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740206087</para>
            /// </summary>
            [JsonProperty("target_working_hours_type")]
            public string? TargetWorkingHoursType { get; set; }

            /// <summary>
            /// <para>原工作日历</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740236087</para>
            /// </summary>
            [JsonProperty("original_working_calendar")]
            public string? OriginalWorkingCalendar { get; set; }

            /// <summary>
            /// <para>新工作日历</para>
            /// <para>必填：否</para>
            /// <para>示例值：6969087376740236087</para>
            /// </summary>
            [JsonProperty("target_working_calendar")]
            public string? TargetWorkingCalendar { get; set; }

            /// <summary>
            /// <para>原试用期预计结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-11-17</para>
            /// </summary>
            [JsonProperty("original_probation_end_date")]
            public string? OriginalProbationEndDate { get; set; }

            /// <summary>
            /// <para>新试用期预计结束日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-11-17</para>
            /// </summary>
            [JsonProperty("target_probation_end_date")]
            public string? TargetProbationEndDate { get; set; }

            /// <summary>
            /// <para>原周工作时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：162</para>
            /// </summary>
            [JsonProperty("original_weekly_working_hours")]
            public string? OriginalWeeklyWorkingHours { get; set; }

            /// <summary>
            /// <para>新周工作时长</para>
            /// <para>必填：否</para>
            /// <para>示例值：160</para>
            /// </summary>
            [JsonProperty("target_weekly_working_hours")]
            public string? TargetWeeklyWorkingHours { get; set; }

            /// <summary>
            /// <para>原排班</para>
            /// <para>必填：否</para>
            /// <para>示例值：work_shift</para>
            /// </summary>
            [JsonProperty("original_work_shift")]
            public string? OriginalWorkShift { get; set; }

            /// <summary>
            /// <para>新排班</para>
            /// <para>必填：否</para>
            /// <para>示例值：non_work_shift</para>
            /// </summary>
            [JsonProperty("target_work_shift")]
            public string? TargetWorkShift { get; set; }

            /// <summary>
            /// <para>原成本中心分摊方式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("original_cost_center_rate")]
            public JobDataCostCenter[]? OriginalCostCenterRates { get; set; }

            /// <summary>
            /// <para>原成本中心分摊方式</para>
            /// </summary>
            public record JobDataCostCenter
            {
                /// <summary>
                /// <para>成本中心 ID，可以通过【查询单个成本中心信息】接口获取对应的成本中心信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：6950635856373745165</para>
                /// </summary>
                [JsonProperty("cost_center_id")]
                public string? CostCenterId { get; set; }

                /// <summary>
                /// <para>分摊比例</para>
                /// <para>必填：否</para>
                /// <para>示例值：100</para>
                /// </summary>
                [JsonProperty("rate")]
                public int? Rate { get; set; }
            }

            /// <summary>
            /// <para>新成本中心分摊方式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("target_cost_center_rate")]
            public JobDataCostCenter[]? TargetCostCenterRates { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：6891251722631890445</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
