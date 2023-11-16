namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新任职信息 请求体
/// <para>更新任职信息</para>
/// <para>接口ID：7072642400195723292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/job_data/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fpatch</para>
/// </summary>
public record PatchCorehrV1JobDatasByJobDataIdBodyDto
{
    /// <summary>
    /// <para>职务级别 ID，枚举值及详细信息可通过【查询单个职务级别】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }

    /// <summary>
    /// <para>人员类型 ID，枚举值及详细信息可通过【查询单个人员类型】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>工时制度 ID，枚举值及详细信息可通过【查询单个工时制度】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>工作地点 ID，枚举值及详细信息可通过【查询单个地点】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("work_location_id")]
    public string? WorkLocationId { get; set; }

    /// <summary>
    /// <para>部门 ID，枚举值及详细信息可通过【查询单个部门】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>职务 ID，枚举值及详细信息可通过【查询单个职务】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }

    /// <summary>
    /// <para>试用期开始日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2018-03-16</para>
    /// </summary>
    [JsonPropertyName("probation_start_date")]
    public string? ProbationStartDate { get; set; }

    /// <summary>
    /// <para>试用期结束日期（实际结束日期）</para>
    /// <para>必填：否</para>
    /// <para>示例值：2019-05-24</para>
    /// </summary>
    [JsonPropertyName("probation_end_date")]
    public string? ProbationEndDate { get; set; }

    /// <summary>
    /// <para>是否为主任职</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("primary_job_data")]
    public bool? PrimaryJobData { get; set; }

    /// <summary>
    /// <para>雇佣 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893014062142064135</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-0100:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string? EffectiveTime { get; set; }

    /// <summary>
    /// <para>失效时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-0200:00:00</para>
    /// </summary>
    [JsonPropertyName("expiration_time")]
    public string? ExpirationTime { get; set; }

    /// <summary>
    /// <para>职务序列 ID，枚举值及详细信息可通过【查询单个职务序列】接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：1245678</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }

    /// <summary>
    /// <para>任职原因，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant) 任职原因（assignment_start_reason）枚举定义部分获得。请注意，「任职原因」不允许填写为「onboarding」，当上一个任职版本的「任职原因」为「onboarding」时，「任职原因」必填。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("assignment_start_reason")]
    public Enum? AssignmentStartReason { get; set; }

    /// <summary>
    /// <para>任职原因，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant) 任职原因（assignment_start_reason）枚举定义部分获得。请注意，「任职原因」不允许填写为「onboarding」，当上一个任职版本的「任职原因」为「onboarding」时，「任职原因」必填。</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：job_status_change</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>预计试用期结束日期</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("probation_expected_end_date")]
    public string? ProbationExpectedEndDate { get; set; }

    /// <summary>
    /// <para>实线主管的任职记录ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("direct_manager_id")]
    public string? DirectManagerId { get; set; }

    /// <summary>
    /// <para>虚线主管的任职记录ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：["6971723901730686501"]</para>
    /// </summary>
    [JsonPropertyName("dotted_line_manager_id_list")]
    public string[]? DottedLineManagerIdList { get; set; }

    /// <summary>
    /// <para>第二实线主管的任职记录ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("second_direct_manager_id")]
    public string? SecondDirectManagerId { get; set; }

    /// <summary>
    /// <para>成本中心分摊信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_rate")]
    public SupportCostCenterItem[]? CostCenterRates { get; set; }

    /// <summary>
    /// <para>成本中心分摊信息</para>
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
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
