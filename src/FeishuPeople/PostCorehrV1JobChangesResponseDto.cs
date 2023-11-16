namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 发起员工异动 响应体
/// <para>创建员工异动信息。</para>
/// <para>接口ID：7088940762189545473</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job_change/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_change%2fcreate</para>
/// </summary>
public record PostCorehrV1JobChangesResponseDto
{
    /// <summary>
    /// <para>异动记录 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6991776076699549697</para>
    /// </summary>
    [JsonPropertyName("job_change_id")]
    public string? JobChangeId { get; set; }

    /// <summary>
    /// <para>雇员 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_a294793e8fa21529f2a60e3e9de45520</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>异动状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：4</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：Approving审批中</item>
    /// <item>1：Approved审批通过</item>
    /// <item>2：Transformed已异动</item>
    /// <item>3：Rejected已拒绝</item>
    /// <item>4：Cancelled已撤销</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// <para>异动类型唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：direct_leader_change</para>
    /// </summary>
    [JsonPropertyName("transfer_type_unique_identifier")]
    public string? TransferTypeUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异动原因唯一标识</para>
    /// <para>必填：否</para>
    /// <para>示例值：involuntary_transfer</para>
    /// </summary>
    [JsonPropertyName("transfer_reason_unique_identifier")]
    public string? TransferReasonUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异动发起后审批流程 id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6991776078461142564</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>异动生效日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-03-01</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }

    /// <summary>
    /// <para>创建时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：1627899724000</para>
    /// </summary>
    [JsonPropertyName("created_time")]
    public string? CreatedTime { get; set; }

    /// <summary>
    /// <para>异动详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transfer_info")]
    public PostCorehrV1JobChangesResponseDtoTransferInfo? TransferInfo { get; set; }

    /// <summary>
    /// <para>异动详细信息</para>
    /// </summary>
    public record PostCorehrV1JobChangesResponseDtoTransferInfo
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
        /// <para>原部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("original_department")]
        public string? OriginalDepartment { get; set; }

        /// <summary>
        /// <para>新部门</para>
        /// <para>必填：否</para>
        /// <para>示例值：6966236933198579208</para>
        /// </summary>
        [JsonPropertyName("target_department")]
        public string? TargetDepartment { get; set; }

        /// <summary>
        /// <para>原工作地点</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967271100992587295</para>
        /// </summary>
        [JsonPropertyName("original_work_location")]
        public string? OriginalWorkLocation { get; set; }

        /// <summary>
        /// <para>新工作地点</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967271100992587295</para>
        /// </summary>
        [JsonPropertyName("target_work_location")]
        public string? TargetWorkLocation { get; set; }

        /// <summary>
        /// <para>原直属上级</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974641477444060708</para>
        /// </summary>
        [JsonPropertyName("original_direct_manager")]
        public string? OriginalDirectManager { get; set; }

        /// <summary>
        /// <para>新直属上级</para>
        /// <para>必填：否</para>
        /// <para>示例值：7013619729281713671</para>
        /// </summary>
        [JsonPropertyName("target_direct_manager")]
        public string? TargetDirectManager { get; set; }

        /// <summary>
        /// <para>原虚线上级</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974648866876573198</para>
        /// </summary>
        [JsonPropertyName("original_dotted_manager")]
        public string? OriginalDottedManager { get; set; }

        /// <summary>
        /// <para>新虚线上级</para>
        /// <para>必填：否</para>
        /// <para>示例值：7013328578351842852</para>
        /// </summary>
        [JsonPropertyName("target_dotted_manager")]
        public string? TargetDottedManager { get; set; }

        /// <summary>
        /// <para>原职务</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969469398088287751</para>
        /// </summary>
        [JsonPropertyName("original_job")]
        public string? OriginalJob { get; set; }

        /// <summary>
        /// <para>新职务</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969469557836760606</para>
        /// </summary>
        [JsonPropertyName("target_job")]
        public string? TargetJob { get; set; }

        /// <summary>
        /// <para>原序列</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967287547462419975</para>
        /// </summary>
        [JsonPropertyName("original_job_family")]
        public string? OriginalJobFamily { get; set; }

        /// <summary>
        /// <para>新序列</para>
        /// <para>必填：否</para>
        /// <para>示例值：6967287547462419975</para>
        /// </summary>
        [JsonPropertyName("target_job_family")]
        public string? TargetJobFamily { get; set; }

        /// <summary>
        /// <para>原级别</para>
        /// <para>必填：否</para>
        /// <para>示例值：6972085707674355214</para>
        /// </summary>
        [JsonPropertyName("original_job_level")]
        public string? OriginalJobLevel { get; set; }

        /// <summary>
        /// <para>新级别</para>
        /// <para>必填：否</para>
        /// <para>示例值：6972085707674355214</para>
        /// </summary>
        [JsonPropertyName("target_job_level")]
        public string? TargetJobLevel { get; set; }

        /// <summary>
        /// <para>原人员类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：6968386026792289828</para>
        /// </summary>
        [JsonPropertyName("original_workforce_type")]
        public string? OriginalWorkforceType { get; set; }

        /// <summary>
        /// <para>新人员类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：7036268995372303885</para>
        /// </summary>
        [JsonPropertyName("target_workforce_type")]
        public string? TargetWorkforceType { get; set; }

        /// <summary>
        /// <para>原公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974659700705068581</para>
        /// </summary>
        [JsonPropertyName("original_company")]
        public string? OriginalCompany { get; set; }

        /// <summary>
        /// <para>新公司</para>
        /// <para>必填：否</para>
        /// <para>示例值：6974659700705068581</para>
        /// </summary>
        [JsonPropertyName("target_company")]
        public string? TargetCompany { get; set; }

        /// <summary>
        /// <para>原合同编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：55332</para>
        /// </summary>
        [JsonPropertyName("original_contract_number")]
        public string? OriginalContractNumber { get; set; }

        /// <summary>
        /// <para>新合同编号</para>
        /// <para>必填：否</para>
        /// <para>示例值：55333</para>
        /// </summary>
        [JsonPropertyName("target_contract_number")]
        public string? TargetContractNumber { get; set; }

        /// <summary>
        /// <para>原合同类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：labor_contract</para>
        /// </summary>
        [JsonPropertyName("original_contract_type")]
        public string? OriginalContractType { get; set; }

        /// <summary>
        /// <para>新合同类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：labor_contract</para>
        /// </summary>
        [JsonPropertyName("target_contract_type")]
        public string? TargetContractType { get; set; }

        /// <summary>
        /// <para>原期限类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonPropertyName("original_duration_type")]
        public string? OriginalDurationType { get; set; }

        /// <summary>
        /// <para>新期限类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：fixed_term</para>
        /// </summary>
        [JsonPropertyName("target_duration_type")]
        public string? TargetDurationType { get; set; }

        /// <summary>
        /// <para>原签订类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：new</para>
        /// </summary>
        [JsonPropertyName("original_signing_type")]
        public string? OriginalSigningType { get; set; }

        /// <summary>
        /// <para>新签订类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：new</para>
        /// </summary>
        [JsonPropertyName("target_signing_type")]
        public string? TargetSigningType { get; set; }

        /// <summary>
        /// <para>原合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-01</para>
        /// </summary>
        [JsonPropertyName("original_contract_start_date")]
        public string? OriginalContractStartDate { get; set; }

        /// <summary>
        /// <para>新合同开始日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-07-01</para>
        /// </summary>
        [JsonPropertyName("target_contract_start_date")]
        public string? TargetContractStartDate { get; set; }

        /// <summary>
        /// <para>原合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-07-01</para>
        /// </summary>
        [JsonPropertyName("original_contract_end_date")]
        public string? OriginalContractEndDate { get; set; }

        /// <summary>
        /// <para>新合同结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2024-07-01</para>
        /// </summary>
        [JsonPropertyName("target_contract_end_date")]
        public string? TargetContractEndDate { get; set; }

        /// <summary>
        /// <para>原工时制度</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740206087</para>
        /// </summary>
        [JsonPropertyName("original_working_hours_type")]
        public string? OriginalWorkingHoursType { get; set; }

        /// <summary>
        /// <para>新工时制度</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740206087</para>
        /// </summary>
        [JsonPropertyName("target_working_hours_type")]
        public string? TargetWorkingHoursType { get; set; }

        /// <summary>
        /// <para>原工作日历</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740236087</para>
        /// </summary>
        [JsonPropertyName("original_working_calendar")]
        public string? OriginalWorkingCalendar { get; set; }

        /// <summary>
        /// <para>新工作日历</para>
        /// <para>必填：否</para>
        /// <para>示例值：6969087376740236087</para>
        /// </summary>
        [JsonPropertyName("target_working_calendar")]
        public string? TargetWorkingCalendar { get; set; }

        /// <summary>
        /// <para>原试用期预计结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2021-11-17</para>
        /// </summary>
        [JsonPropertyName("original_probation_end_date")]
        public string? OriginalProbationEndDate { get; set; }

        /// <summary>
        /// <para>新试用期预计结束日期</para>
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
        /// <para>原成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("original_cost_center_rate")]
        public SupportCostCenterItem[]? OriginalCostCenterRates { get; set; }

        /// <summary>
        /// <para>原成本中心分摊信息</para>
        /// </summary>
        public record SupportCostCenterItem
        {
            /// <summary>
            /// <para>支持的成本中心id</para>
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
        /// <para>新成本中心分摊信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("target_cost_center_rate")]
        public SupportCostCenterItem[]? TargetCostCenterRates { get; set; }
    }
}
