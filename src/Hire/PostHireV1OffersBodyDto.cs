using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建 Offer 请求体
/// <para>创建 Offer 时，需传入本文档中标注为必传的参数，其余参数是否必传参考「获取 Offer 申请表模板信息」的参数定义。</para>
/// <para>接口ID：7085174536488697857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fcreate</para>
/// </summary>
public record PostHireV1OffersBodyDto
{
    /// <summary>
    /// <para>投递 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7013552389293279532</para>
    /// </summary>
    [JsonProperty("application_id")]
    public string ApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>Offer 申请表模板 ID，用于描述申请表单结构的元数据定义，即对申请表内容的描述。用户每一次更改 Offer 申请表模板信息，都会生成新的 schema_id，创建 Offer 时应传入最新的 schema_id，可先从职位设置中拿到offer申请表ID，再从「获取Offer申请表模板信息」接口中获取最新的模板ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7013318077945596204</para>
    /// </summary>
    [JsonProperty("schema_id")]
    public string SchemaId { get; set; } = string.Empty;

    /// <summary>
    /// <para>Offer 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：正式Offer</item>
    /// <item>2：实习Offer</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("offer_type")]
    public int? OfferType { get; set; }

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("basic_info")]
    public OfferBasicInfo BasicInfo { get; set; } = new();

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// </summary>
    public record OfferBasicInfo
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-6b394871807047c7023ebfc1ff37cd3a</para>
        /// </summary>
        [JsonProperty("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>直属上级 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonProperty("leader_user_id")]
        public string LeaderUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>职务 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：123</para>
        /// </summary>
        [JsonProperty("employment_job_id")]
        public string? EmploymentJobId { get; set; }

        /// <summary>
        /// <para>人员类型 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>职位序列 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonProperty("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职位级别 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381881101</para>
        /// </summary>
        [JsonProperty("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>试用期</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonProperty("probation_month")]
        public int? ProbationMonth { get; set; }

        /// <summary>
        /// <para>合同期(年)，推荐使用「contract_period」，如果Offer申请表中「合同期(年)」字段已停用，则不可使用该字段</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonProperty("contract_year")]
        public int? ContractYear { get; set; }

        /// <summary>
        /// <para>合同期（年/月）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("contract_period")]
        public ContractPeriodInfo? ContractPeriod { get; set; }

        /// <summary>
        /// <para>合同期（年/月）</para>
        /// </summary>
        public record ContractPeriodInfo
        {
            /// <summary>
            /// <para>合同周期类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：月</item>
            /// <item>2：年</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("period_type")]
            public int PeriodType { get; set; }

            /// <summary>
            /// <para>合同时长</para>
            /// <para>必填：是</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("period")]
            public int Period { get; set; }
        }

        /// <summary>
        /// <para>预计入职日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"date\":\"2022-04-07\"}</para>
        /// </summary>
        [JsonProperty("expected_onboard_date")]
        public string? ExpectedOnboardDate { get; set; }

        /// <summary>
        /// <para>入职地点 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonProperty("onboard_address_id")]
        public string? OnboardAddressId { get; set; }

        /// <summary>
        /// <para>办公地点 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonProperty("work_address_id")]
        public string? WorkAddressId { get; set; }

        /// <summary>
        /// <para>Offer负责人 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonProperty("owner_user_id")]
        public string OwnerUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Offer 推荐语</para>
        /// <para>必填：否</para>
        /// <para>示例值：十分优秀，推荐入职</para>
        /// </summary>
        [JsonProperty("recommended_words")]
        public string? RecommendedWords { get; set; }

        /// <summary>
        /// <para>招聘需求 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：2342352224</para>
        /// </summary>
        [JsonProperty("job_requirement_id")]
        public string? JobRequirementId { get; set; }

        /// <summary>
        /// <para>招聘流程类型 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonProperty("job_process_type_id")]
        public int? JobProcessTypeId { get; set; }

        /// <summary>
        /// <para>附件ID列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：["7081582717280831752"]</para>
        /// </summary>
        [JsonProperty("attachment_id_list")]
        public string[]? AttachmentIdList { get; set; }

        /// <summary>
        /// <para>附件描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三的简历</para>
        /// </summary>
        [JsonProperty("attachment_description")]
        public string? AttachmentDescription { get; set; }

        /// <summary>
        /// <para>Offer操作人 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonProperty("operator_user_id")]
        public string OperatorUserId { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>Offer 薪资信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("salary_info")]
    public OfferSalaryInfo? SalaryInfo { get; set; }

    /// <summary>
    /// <para>Offer 薪资信息</para>
    /// </summary>
    public record OfferSalaryInfo
    {
        /// <summary>
        /// <para>币种</para>
        /// <para>必填：是</para>
        /// <para>示例值：CNY</para>
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// <para>基本工资，当启用 Offer 申请表中的「薪资信息」模块时，「基本工资」字段为必传项</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonProperty("basic_salary")]
        public string? BasicSalary { get; set; }

        /// <summary>
        /// <para>试用期百分比</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.8</para>
        /// </summary>
        [JsonProperty("probation_salary_percentage")]
        public string? ProbationSalaryPercentage { get; set; }

        /// <summary>
        /// <para>年终奖月数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonProperty("award_salary_multiple")]
        public string? AwardSalaryMultiple { get; set; }

        /// <summary>
        /// <para>期权股数</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonProperty("option_shares")]
        public string? OptionShares { get; set; }

        /// <summary>
        /// <para>季度奖金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：3000</para>
        /// </summary>
        [JsonProperty("quarterly_bonus")]
        public string? QuarterlyBonus { get; set; }

        /// <summary>
        /// <para>半年奖金额</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonProperty("half_year_bonus")]
        public string? HalfYearBonus { get; set; }
    }

    /// <summary>
    /// <para>自定义信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("customized_info_list")]
    public OfferCustomizedInfo[]? CustomizedInfoLists { get; set; }

    /// <summary>
    /// <para>自定义信息</para>
    /// </summary>
    public record OfferCustomizedInfo
    {
        /// <summary>
        /// <para>自定义字段 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6972464088568269100</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>自定义字段信息，以字符串形式传入，如：</para>
        /// <para>1. 单选： "1"</para>
        /// <para>2. 多选："[\"1\", \"2\"]"</para>
        /// <para>3. 日期："{"date":"2022-01-01"}"</para>
        /// <para>4. 年份选择："{"date":"2022"}"</para>
        /// <para>5. 月份选择："{"date":"2022-01"}"</para>
        /// <para>6. 单行文本："xxx "</para>
        /// <para>7. 多行文本："xxx "</para>
        /// <para>8. 数字："123"</para>
        /// <para>9. 金额："123.1"</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }
}
