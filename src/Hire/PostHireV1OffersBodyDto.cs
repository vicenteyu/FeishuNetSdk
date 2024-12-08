// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1OffersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建 Offer 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建 Offer 请求体
/// <para>传入 Offer 基本信息，创建 Offer。</para>
/// <para>## 注意事项</para>
/// <para>创建 Offer 时，需传入本文档中标注为必传的参数，其余参数是否必传参考[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)的参数定义或在「飞书招聘-设置-offer设置-offer申请表设置」中进行查看。</para>
/// <para>接口ID：7085174536488697857</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fcreate</para>
/// </summary>
public record PostHireV1OffersBodyDto
{
    /// <summary>
    /// <para>投递 ID，详情请参考：[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)</para>
    /// <para>必填：是</para>
    /// <para>示例值：7013552389293279532</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string ApplicationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>Offer 申请表模板 ID，用于描述申请表单结构的元数据定义，即对申请表内容的描述。用户每一次更改 Offer 申请表模板信息，都会生成新的 schema_id，创建 Offer 时应传入最新的 schema_id，可先从[获取职位设置](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/config)中拿到offer申请表ID，再从[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)接口中获取最新的模板ID。不填则会自动填充最新模版ID。</para>
    /// <para>必填：否</para>
    /// <para>示例值：7013318077945596204</para>
    /// </summary>
    [JsonPropertyName("schema_id")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// <para>Offer 类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：正式 Offer</item>
    /// <item>2：实习 Offer</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("offer_type")]
    public int? OfferType { get; set; }

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public OfferBasicInfo BasicInfo { get; set; } = new();

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// </summary>
    public record OfferBasicInfo
    {
        /// <summary>
        /// <para>部门 ID，与入参中的`department_id_type`类型一致，详情请查看：[获取部门信息列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/list)</para>
        /// <para>必填：是</para>
        /// <para>示例值：od-6b394871807047c7023ebfc1ff37cd3a</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>直属上级 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string LeaderUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>职务 ID，可通过[批量查询职务](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口获取。**请注意**：仅支持开通飞书人事企业版的客户使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonPropertyName("employment_job_id")]
        public string? EmploymentJobId { get; set; }

        /// <summary>
        /// <para>人员类型 ID，与入参`employee_type_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string? EmployeeTypeId { get; set; }

        /// <summary>
        /// <para>职位序列 ID，通过[获取租户序列列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_family/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职位级别 ID，通过[获取租户职级列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_level/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381881101</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>试用期（月）</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("probation_month")]
        public int? ProbationMonth { get; set; }

        /// <summary>
        /// <para>合同期(年)，推荐使用「contract_period」</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("contract_year")]
        public int? ContractYear { get; set; }

        /// <summary>
        /// <para>合同期（年/月）</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("contract_period")]
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
            [JsonPropertyName("period_type")]
            public int PeriodType { get; set; }

            /// <summary>
            /// <para>合同时长</para>
            /// <para>必填：是</para>
            /// <para>示例值：3</para>
            /// <para>最大值：100</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("period")]
            public int Period { get; set; }
        }

        /// <summary>
        /// <para>预计入职日期。以下示例值未转义，使用时请注意转义</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"date\":\"2022-04-07\"}</para>
        /// </summary>
        [JsonPropertyName("expected_onboard_date")]
        public string? ExpectedOnboardDate { get; set; }

        /// <summary>
        /// <para>入职地点 ID，详情请参考：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonPropertyName("onboard_address_id")]
        public string? OnboardAddressId { get; set; }

        /// <summary>
        /// <para>办公地点 ID，详情请参考：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonPropertyName("work_address_id")]
        public string? WorkAddressId { get; set; }

        /// <summary>
        /// <para>Offer负责人 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("owner_user_id")]
        public string OwnerUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Offer 推荐语</para>
        /// <para>必填：否</para>
        /// <para>示例值：十分优秀，推荐入职</para>
        /// </summary>
        [JsonPropertyName("recommended_words")]
        public string? RecommendedWords { get; set; }

        /// <summary>
        /// <para>招聘需求 ID，详情请查看：[获取招聘需求列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：2342352224</para>
        /// </summary>
        [JsonPropertyName("job_requirement_id")]
        public string? JobRequirementId { get; set; }

        /// <summary>
        /// <para>招聘流程类型 ID，可选值：「1:社招，2:校招」</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("job_process_type_id")]
        public int? JobProcessTypeId { get; set; }

        /// <summary>
        /// <para>附件ID列表，暂无获取附件ID的方式，请勿使用</para>
        /// <para>必填：否</para>
        /// <para>示例值：["7081582717280831752"]</para>
        /// </summary>
        [JsonPropertyName("attachment_id_list")]
        public string[]? AttachmentIdList { get; set; }

        /// <summary>
        /// <para>附件描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：张三的简历</para>
        /// </summary>
        [JsonPropertyName("attachment_description")]
        public string? AttachmentDescription { get; set; }

        /// <summary>
        /// <para>Offer操作人 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("operator_user_id")]
        public string OperatorUserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>岗位 ID，可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query) 获取（仅限飞书人事租户使用，若链接无法打开，则说明飞书人事未启用岗位，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)开通）</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>入职职位</para>
        /// <para>必填：否</para>
        /// <para>示例值：入职职位</para>
        /// </summary>
        [JsonPropertyName("job_offered")]
        public string? JobOffered { get; set; }
    }

    /// <summary>
    /// <para>Offer 薪资信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("salary_info")]
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
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// <para>基本工资，当启用 Offer 申请表中的「薪资信息」模块时，「基本工资」字段为必传项</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonPropertyName("basic_salary")]
        public string? BasicSalary { get; set; }

        /// <summary>
        /// <para>试用期薪资百分比</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.8</para>
        /// </summary>
        [JsonPropertyName("probation_salary_percentage")]
        public string? ProbationSalaryPercentage { get; set; }

        /// <summary>
        /// <para>年终奖月数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("award_salary_multiple")]
        public string? AwardSalaryMultiple { get; set; }

        /// <summary>
        /// <para>期权股数</para>
        /// <para>必填：否</para>
        /// <para>示例值：30</para>
        /// </summary>
        [JsonPropertyName("option_shares")]
        public string? OptionShares { get; set; }

        /// <summary>
        /// <para>季度奖金额，单位元、支持小数点后两位</para>
        /// <para>必填：否</para>
        /// <para>示例值：3000</para>
        /// </summary>
        [JsonPropertyName("quarterly_bonus")]
        public string? QuarterlyBonus { get; set; }

        /// <summary>
        /// <para>半年奖金额，单位元、支持小数点后两位</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonPropertyName("half_year_bonus")]
        public string? HalfYearBonus { get; set; }
    }

    /// <summary>
    /// <para>自定义信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_info_list")]
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
        [JsonPropertyName("id")]
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
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
