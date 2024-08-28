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
/// <para>创建一个新的职位。</para>
/// <para>## 注意事项</para>
/// <para>- 调用此接口前，需先打开「飞书招聘」-「设置」-「职位管理」-「职位设置」-「通过API同步职位开关」开关。</para>
/// <para>- 字段是否必填，将以「飞书招聘」-「设置」-「职位管理」-「职位字段管理」中的设置为准。</para>
/// <para>接口ID：7012986483075481601</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_create</para>
/// </summary>
public record PostHireV1JobsCombinedCreateBodyDto
{
    /// <summary>
    /// <para>职位编码，传入需保证唯一性，不传系统会自动生成一个唯一编码，限定长度16字节</para>
    /// <para>必填：否</para>
    /// <para>示例值：R18</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>工作经验要求</para>
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
    /// <para>到期日期，此字段已废弃，请使用expiry_timestamp</para>
    /// <para>必填：否</para>
    /// <para>示例值：1622484739</para>
    /// </summary>
    [JsonPropertyName("expiry_time")]
    public long? ExpiryTime { get; set; }

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
        /// <para>自定义字段 ID，可通过[获取职位模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_schema/list)接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：7281257045172308287</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>自定义字段值</para>
        /// <para>必填：否</para>
        /// <para>示例值：职位特殊要求</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>最低职级 ID，需与入参`job_level_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7281257045172308287</para>
    /// </summary>
    [JsonPropertyName("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>最低月薪，单位：K</para>
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
    /// <para>职位管理者</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("job_managers")]
    public JobManager JobManagers { get; set; } = new();

    /// <summary>
    /// <para>职位管理者</para>
    /// </summary>
    public record JobManager
    {
        /// <summary>
        /// <para>职位 ID（此字段无需填充，请忽略）</para>
        /// <para>必填：否</para>
        /// <para>示例值：7281257045172308287</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人 ID，需与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string RecruiterId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用人经理 ID 列表，需与入参`user_id_type`类型一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[] HiringManagerIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>协助人 ID 列表，需与入参`user_id_type`类型一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }

    /// <summary>
    /// <para>招聘流程 ID，可通过[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list)接口获取</para>
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
    /// <para>项目 ID，可通过[获取项目列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/subject/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("subject_id")]
    public string? SubjectId { get; set; }

    /// <summary>
    /// <para>职能分类ID，可通过[获取职能分类列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_function/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("job_function_id")]
    public string? JobFunctionId { get; set; }

    /// <summary>
    /// <para>部门 ID，需与入参中的`department_id_type`类型一致</para>
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
    /// <para>最高月薪，单位：K</para>
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
    /// <para>职位亮点列表，可通过[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中职位亮枚举定义」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956554</para>
    /// </summary>
    [JsonPropertyName("highlight_list")]
    public string[]? HighlightList { get; set; }

    /// <summary>
    /// <para>职位类别 ID，可通过[获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)接口获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956551</para>
    /// </summary>
    [JsonPropertyName("job_type_id")]
    public string JobTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>最高职级 ID，需与入参`job_level_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956548</para>
    /// </summary>
    [JsonPropertyName("max_level_id")]
    public string? MaxLevelId { get; set; }

    /// <summary>
    /// <para>雇佣类型 ID，详情请参考：[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)中「职位性质/雇佣类型（recruitment_type）枚举定义」</para>
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
    /// <para>序列 ID，需与入参`job_family_id_type` 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956550</para>
    /// </summary>
    [JsonPropertyName("job_category_id")]
    public string? JobCategoryId { get; set; }

    /// <summary>
    /// <para>工作地址列表，可通过[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7035374761602959660</para>
    /// </summary>
    [JsonPropertyName("address_id_list")]
    public string[]? AddressIdList { get; set; }

    /// <summary>
    /// <para>职位属性</para>
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
    /// <para>到期时间，毫秒时间戳，如果`is_never_expired`字段选择true，则不会实际使用该字段的值，职位为长期有效</para>
    /// <para>必填：否</para>
    /// <para>示例值：1622484739955</para>
    /// </summary>
    [JsonPropertyName("expiry_timestamp")]
    public string? ExpiryTimestamp { get; set; }

    /// <summary>
    /// <para>面试登记表 ID，当在飞书招聘「设置 - 信息登记表使用设置 - 面试登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。可通过[获取面试登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/interview_registration_schema/list)接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("interview_registration_schema_id")]
    public string? InterviewRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>入职登记表 ID，当在飞书招聘「设置 - 信息登记表使用设置 - 入职登记表使用方式」中选择「HR 按职位选择登记表」时，该字段为必填；否则该字段不生效。可通过[获取信息登记表模板列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/registration_schema/list)接口获取。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114325</para>
    /// </summary>
    [JsonPropertyName("onboard_registration_schema_id")]
    public string? OnboardRegistrationSchemaId { get; set; }

    /// <summary>
    /// <para>目标专业 ID 列表，可通过[「根据主数据编码批量获取专业」](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/batch_major/get)获取专业详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_major_id_list")]
    public string[]? TargetMajorIdList { get; set; }
}
