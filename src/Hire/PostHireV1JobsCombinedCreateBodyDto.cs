// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostHireV1JobsCombinedCreateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建职位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建职位 请求体
/// <para>新建职位，字段的是否必填，以系统中的「职位字段管理」中的设置为准。</para>
/// <para>接口ID：7012986483075481601</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_create</para>
/// </summary>
public record PostHireV1JobsCombinedCreateBodyDto
{
    /// <summary>
    /// <para>职位编号，可传入职位的「职位编号」、「职位 ID」或者「职位序号」，将以传入的参数作为职位编号，以便双方系统的数据映射</para>
    /// <para>必填：否</para>
    /// <para>示例值：R18</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>工作年限</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：不限</item>
    /// <item>2：应届毕业生</item>
    /// <item>3：1年以下</item>
    /// <item>4：1-3年</item>
    /// <item>5：3-5年</item>
    /// <item>6：5-7年</item>
    /// <item>7：7-10年</item>
    /// <item>8：10年以上</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("experience")]
    public int? Experience { get; set; }

    /// <summary>
    /// <para>到期日期 请使用expiry_timestamp</para>
    /// <para>必填：否</para>
    /// <para>示例值：1622484739</para>
    /// </summary>
    [JsonPropertyName("expiry_time")]
    public int? ExpiryTime { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_data_list")]
    public CombinedJobObjectValueMap[]? CustomizedDataLists { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record CombinedJobObjectValueMap
    {
        /// <summary>
        /// <para>结构 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956549</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>结构值</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>最低职级，枚举通过接口「获取职级列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956547</para>
    /// </summary>
    [JsonPropertyName("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>最低薪资，单位：k</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000</para>
    /// </summary>
    [JsonPropertyName("min_salary")]
    public int? MinSalary { get; set; }

    /// <summary>
    /// <para>职位名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：后端研发</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// <para>职位的招聘团队</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("job_managers")]
    public JobManager JobManagers { get; set; } = new();

    /// <summary>
    /// <para>职位的招聘团队</para>
    /// </summary>
    public record JobManager
    {
        /// <summary>
        /// <para>职位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人 ID，仅一位，可通过用户相关接口获取用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string RecruiterId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用人经理 ID 列表</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[] HiringManagerIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>协助人 ID 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }

    /// <summary>
    /// <para>招聘流程，枚举通过接口「获取招聘流程信息」获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956554</para>
    /// </summary>
    [JsonPropertyName("job_process_id")]
    public string JobProcessId { get; set; } = string.Empty;

    /// <summary>
    /// <para>职位流程类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：社招</item>
    /// <item>2：校招</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("process_type")]
    public int ProcessType { get; set; }

    /// <summary>
    /// <para>项目，枚举通过「获取项目列表」接口</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("subject_id")]
    public string? SubjectId { get; set; }

    /// <summary>
    /// <para>职能分类，通过「获取职能分类」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("job_function_id")]
    public string? JobFunctionId { get; set; }

    /// <summary>
    /// <para>部门 ID，须传入open_department_id，格式为"od-xxxx"。可通过「获取部门信息列表」获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：od-b2fafdce6fc5800b574ba5b0e2798b36</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>招聘数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("head_count")]
    public int? HeadCount { get; set; }

    /// <summary>
    /// <para>是否长期有效</para>
    /// <para>必填：是</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("is_never_expired")]
    public bool IsNeverExpired { get; set; }

    /// <summary>
    /// <para>最高薪资，单位：k</para>
    /// <para>必填：否</para>
    /// <para>示例值：2000</para>
    /// </summary>
    [JsonPropertyName("max_salary")]
    public int? MaxSalary { get; set; }

    /// <summary>
    /// <para>职位要求</para>
    /// <para>必填：否</para>
    /// <para>示例值：熟悉后端研发</para>
    /// </summary>
    [JsonPropertyName("requirement")]
    public string? Requirement { get; set; }

    /// <summary>
    /// <para>职位描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：后端研发岗位描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>职位亮点，可参考招聘[枚举常量介绍](</para>
    /// <para>https://open.feishu.cn/document/server-docs/hire-v1/enum)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956554</para>
    /// </summary>
    [JsonPropertyName("highlight_list")]
    public string[]? HighlightList { get; set; }

    /// <summary>
    /// <para>职位类别，枚举可通过[「获取职位类别列表」](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956551</para>
    /// </summary>
    [JsonPropertyName("job_type_id")]
    public string JobTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>最高职级，枚举通过接口「获取职级列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956548</para>
    /// </summary>
    [JsonPropertyName("max_level_id")]
    public string? MaxLevelId { get; set; }

    /// <summary>
    /// <para>雇佣类型</para>
    /// <para>社招：101-全职 102-外包 103-劳务 105-顾问 301-实习</para>
    /// <para>校招：201-正式 202-实习</para>
    /// <para>必填：是</para>
    /// <para>示例值：102</para>
    /// </summary>
    [JsonPropertyName("recruitment_type_id")]
    public string RecruitmentTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>学历要求</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：小学及以上</item>
    /// <item>2：初中及以上</item>
    /// <item>3：专职及以上</item>
    /// <item>4：高中及以上</item>
    /// <item>5：大专及以上</item>
    /// <item>6：本科及以上</item>
    /// <item>7：硕士及以上</item>
    /// <item>8：博士及以上</item>
    /// <item>20：不限</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("required_degree")]
    public int? RequiredDegree { get; set; }

    /// <summary>
    /// <para>序列ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956550</para>
    /// </summary>
    [JsonPropertyName("job_category_id")]
    public string? JobCategoryId { get; set; }

    /// <summary>
    /// <para>工作地点列表，枚举通过接口「获取地址列表」获取，选择地点用途为「职位地址」，与「address_id」必填其一，同时使用则以当前字段为准，推荐使用当前字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：7035374761602959660</para>
    /// </summary>
    [JsonPropertyName("address_id_list")]
    public string[]? AddressIdList { get; set; }

    /// <summary>
    /// <para>职位属性，1是实体职位，2是虚拟职位</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：实体职位</item>
    /// <item>2：虚拟职位</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("job_attribute")]
    public int? JobAttribute { get; set; }

    /// <summary>
    /// <para>到期日期的毫秒时间戳，如果「是否长期有效」字段选择true，则不会实际使用该字段的值，职位为长期有效</para>
    /// <para>必填：否</para>
    /// <para>示例值：1622484739955</para>
    /// </summary>
    [JsonPropertyName("expiry_timestamp")]
    public string? ExpiryTimestamp { get; set; }

    /// <summary>
    /// <para>面试登记表ID，当在飞书招聘「设置 - 信息登记表使用设置 - 面试登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("interview_registration_schema_id")]
    public string? InterviewRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>入职登记表ID，当在飞书招聘「设置 - 信息登记表使用设置 - 入职登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("onboard_registration_schema_id")]
    public string? OnboardRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>目标专业ID，枚举通过[「分页批量查询专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/major/list)接口获取，对应返回值中的 mdm_code，「0」 为不限专业</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_major_id_list")]
    public string[]? TargetMajorIdList { get; set; }
}
