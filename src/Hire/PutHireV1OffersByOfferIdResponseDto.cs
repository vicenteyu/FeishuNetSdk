// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutHireV1OffersByOfferIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新 Offer 信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新 Offer 信息 响应体
/// <para>更新 Offer 信息，包含基本信息、薪资信息、自定义信息。</para>
/// <para>## 注意事项</para>
/// <para>- 更新 Offer 时，除了本文中标注为必填的参数外，其余参数是否必填请参考[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)的参数定义</para>
/// <para>- 对系统中 Offer 进行更新时，若本次更新 Offer 字段中含有「修改需审批」的字段，更新后原 Offer 的审批会自动撤回，需要重新发起审批；修改需审批字段详情可查看：[获取 Offer 申请表信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer_application_form/get)接口中`need_approve`字段</para>
/// <para>- 当 Offer 状态为以下 2 种时， 不可更新 Offer：`Offer 已发送`、`Offer 被候选人接受`，Offer 状态详情可查看：[获取 Offer 详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/get)</para>
/// <para>- 该接口会对原 Offer 内容进行全量覆盖更新，若非必填参数未填写则会清空原有内容，必填参数未填写会拦截报错。</para>
/// <para>接口ID：7085174522588348418</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fupdate</para>
/// </summary>
public record PutHireV1OffersByOfferIdResponseDto
{
    /// <summary>
    /// <para>Offer ID，详情请查看：[获取 Offer 详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/get)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7016605170635213100</para>
    /// </summary>
    [JsonPropertyName("offer_id")]
    public string? OfferId { get; set; }

    /// <summary>
    /// <para>Offer 申请表模板 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7013318077945596204</para>
    /// </summary>
    [JsonPropertyName("schema_id")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("basic_info")]
    public OfferBasicInfo? BasicInfo { get; set; }

    /// <summary>
    /// <para>Offer 基本信息</para>
    /// </summary>
    public record OfferBasicInfo
    {
        /// <summary>
        /// <para>部门 ID，与入参中的`department_id_type`类型一致，详情请查看[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)</para>
        /// <para>必填：否</para>
        /// <para>示例值：od-6b394871807047c7023ebfc1ff37cd3a</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>直属上级 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("leader_user_id")]
        public string? LeaderUserId { get; set; }

        /// <summary>
        /// <para>职务 ID，详情请查看[获取单个职务信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_title/get)</para>
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
        /// <para>职位序列 ID，与入参`job_family_id_type` 类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6807407987381831949</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>职位级别 ID，与入参`job_level_id_type` 类型一致</para>
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
        /// <para>合同期(年)，推荐使用`contract_period`</para>
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
        /// <para>预计入职日期，格式为：{"date":"YYYY-MM-DD"}，使用时请注意转义</para>
        /// <para>必填：否</para>
        /// <para>示例值：{\"date\":\"2022-04-07\"}</para>
        /// </summary>
        [JsonPropertyName("expected_onboard_date")]
        public string? ExpectedOnboardDate { get; set; }

        /// <summary>
        /// <para>入职地点 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonPropertyName("onboard_address_id")]
        public string? OnboardAddressId { get; set; }

        /// <summary>
        /// <para>办公地点 ID，详情请查看：[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6897079709306259719</para>
        /// </summary>
        [JsonPropertyName("work_address_id")]
        public string? WorkAddressId { get; set; }

        /// <summary>
        /// <para>Offer 负责人 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// <para>Offer 推荐语</para>
        /// <para>必填：否</para>
        /// <para>示例值：十分优秀，推荐入职</para>
        /// </summary>
        [JsonPropertyName("recommended_words")]
        public string? RecommendedWords { get; set; }

        /// <summary>
        /// <para>招聘需求 ID，详情请查看：[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6791698585114724616</para>
        /// </summary>
        [JsonPropertyName("job_requirement_id")]
        public string? JobRequirementId { get; set; }

        /// <summary>
        /// <para>招聘流程类型 ID</para>
        /// <para>**可选值**：</para>
        /// <para>- 1：社招</para>
        /// <para>- 2：校招</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// </summary>
        [JsonPropertyName("job_process_type_id")]
        public int? JobProcessTypeId { get; set; }

        /// <summary>
        /// <para>附件 ID 列表，详情请查看：[获取附件信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/attachment/get)</para>
        /// <para>必填：否</para>
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
        /// <para>Offer 操作人 ID，与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_ce613028fe74745421f5dc320bb9c709</para>
        /// </summary>
        [JsonPropertyName("operator_user_id")]
        public string OperatorUserId { get; set; } = string.Empty;
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
        /// <para>基本薪资，支持小数点后两位</para>
        /// <para>必填：否</para>
        /// <para>示例值：1000000</para>
        /// </summary>
        [JsonPropertyName("basic_salary")]
        public string? BasicSalary { get; set; }

        /// <summary>
        /// <para>试用期百分比，支持小数点后两位</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.8</para>
        /// </summary>
        [JsonPropertyName("probation_salary_percentage")]
        public string? ProbationSalaryPercentage { get; set; }

        /// <summary>
        /// <para>年终奖月数，仅支持整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：3</para>
        /// </summary>
        [JsonPropertyName("award_salary_multiple")]
        public string? AwardSalaryMultiple { get; set; }

        /// <summary>
        /// <para>期权股数，仅支持整数</para>
        /// <para>必填：否</para>
        /// <para>示例值：11</para>
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
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_info_list")]
    public OfferCustomizedInfo[]? CustomizedInfoLists { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
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
        /// <para>自定义字段信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }
}
