// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostHireV1JobsByJobIdCombinedUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新职位 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新职位 请求体
/// <para>更新职位信息。</para>
/// <para>接口ID：7012986483075497985</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job/combined_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob%2fcombined_update</para>
/// </summary>
public record PostHireV1JobsByJobIdCombinedUpdateBodyDto
{
    /// <summary>
    /// <para>职位 ID，可通过 [获取职位列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/list) 接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956576</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
    /// <para>到期日期，此字段已废弃，请使用expiry_timestamp</para>
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
        /// <para>自定义字段 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956549</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>自定义字段的值</para>
        /// <para>必填：否</para>
        /// <para>示例值：自定义内容</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>最低职级ID，枚举通过接口「获取职级列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956547</para>
    /// </summary>
    [JsonPropertyName("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>最低薪资，单位：k，即千</para>
    /// <para>必填：否</para>
    /// <para>示例值：1000</para>
    /// </summary>
    [JsonPropertyName("min_salary")]
    public int? MinSalary { get; set; }

    /// <summary>
    /// <para>职位名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：后端研发</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

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
        /// <para>职位 ID，可通过 [获取职位列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job/list) 接口获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：1618209327096</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>招聘负责人 ID，仅一位，可通过用户相关接口获取用户 ID，如[搜索用户](https://open.feishu.cn/document/ukTMukTMukTM/uMTM4UjLzEDO14yMxgTN)</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_efk39117c300506837def50545420c6a</para>
        /// </summary>
        [JsonPropertyName("recruiter_id")]
        public string RecruiterId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用人经理 ID 列表，可通过用户相关接口获取用户 ID，如[搜索用户](https://open.feishu.cn/document/ukTMukTMukTM/uMTM4UjLzEDO14yMxgTN)</para>
        /// <para>必填：是</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("hiring_manager_id_list")]
        public string[] HiringManagerIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>协助人 ID 列表，可通过用户相关接口获取用户 ID，如[搜索用户](https://open.feishu.cn/document/ukTMukTMukTM/uMTM4UjLzEDO14yMxgTN)</para>
        /// <para>必填：否</para>
        /// <para>示例值：6960663240925956554</para>
        /// </summary>
        [JsonPropertyName("assistant_id_list")]
        public string[]? AssistantIdList { get; set; }
    }

    /// <summary>
    /// <para>招聘流程，枚举通过接口[获取招聘流程信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_process/list) 获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956554</para>
    /// </summary>
    [JsonPropertyName("job_process_id")]
    public string? JobProcessId { get; set; }

    /// <summary>
    /// <para>项目ID，枚举通过「获取项目列表」接口</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("subject_id")]
    public string? SubjectId { get; set; }

    /// <summary>
    /// <para>职能分类ID，通过「获取职能分类」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956555</para>
    /// </summary>
    [JsonPropertyName("job_function_id")]
    public string? JobFunctionId { get; set; }

    /// <summary>
    /// <para>部门 ID，须传入open_department_id，格式为"od-xxxx"。可通过[获取部门信息列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/list) 获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-b2fafdce6fc5800b574ba5b0e2798b36</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

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
    /// <para>最高薪资，单位：k，即千</para>
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
    /// <para>职位亮点</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956554</para>
    /// </summary>
    [JsonPropertyName("highlight_list")]
    public string[]? HighlightList { get; set; }

    /// <summary>
    /// <para>职位类别ID，枚举可通过 [获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list) 获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6960663240925956551</para>
    /// </summary>
    [JsonPropertyName("job_type_id")]
    public string JobTypeId { get; set; } = string.Empty;

    /// <summary>
    /// <para>最高职级ID，枚举通过接口「获取职级列表」获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956548</para>
    /// </summary>
    [JsonPropertyName("max_level_id")]
    public string? MaxLevelId { get; set; }

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
    /// <para>序列ID，通过 [获取租户序列列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/job_family/list) 接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956550</para>
    /// </summary>
    [JsonPropertyName("job_category_id")]
    public string? JobCategoryId { get; set; }

    /// <summary>
    /// <para>工作地点，枚举通过接口「获取地址列表」获取，选择地点用途为「职位地址」</para>
    /// <para>必填：否</para>
    /// <para>示例值：7035374761602959660</para>
    /// </summary>
    [JsonPropertyName("address_id_list")]
    public string[]? AddressIdList { get; set; }

    /// <summary>
    /// <para>职位属性，1是实体职位，2是虚拟职位</para>
    /// <para>必填：否</para>
    /// <para>示例值：6960663240925956554</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：实体职位</item>
    /// <item>2：虚拟职位</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("job_attribute")]
    public int? JobAttribute { get; set; }

    /// <summary>
    /// <para>到期日期的毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1622484739955</para>
    /// </summary>
    [JsonPropertyName("expiry_timestamp")]
    public string? ExpiryTimestamp { get; set; }

    /// <summary>
    /// <para>目标专业ID，枚举通过[分页批量查询专业](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/mdm-v3/major/list)接口的返回值获取（返回值中的专业目录列表下的主数据编码），「0」 为不限专业</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_major_id_list")]
    public string[]? TargetMajorIdList { get; set; }
}
