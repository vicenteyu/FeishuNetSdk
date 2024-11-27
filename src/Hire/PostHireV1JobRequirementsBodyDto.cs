// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-11-27
// ************************************************************************
// <copyright file="PostHireV1JobRequirementsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建招聘需求 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建招聘需求 请求体
/// <para>创建招聘需求，可指定招聘需求部门、招聘人数、需求描述等，具体可参考「飞书招聘」-「设置」-「招聘需求字段管理」，或者参考[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)。</para>
/// <para>接口ID：6989078472837283843</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2fcreate</para>
/// </summary>
public record PostHireV1JobRequirementsBodyDto
{
    /// <summary>
    /// <para>招聘需求编号，需传入唯一的编号</para>
    /// <para>必填：是</para>
    /// <para>示例值：R01905</para>
    /// </summary>
    [JsonPropertyName("short_code")]
    public string ShortCode { get; set; } = string.Empty;

    /// <summary>
    /// <para>需求名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：HR部门春季招聘需求</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>需求状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：未开始</item>
    /// <item>2：进行中</item>
    /// <item>3：已取消</item>
    /// <item>4：已暂停</item>
    /// <item>5：已完成</item>
    /// <item>6：已超期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("display_progress")]
    public int DisplayProgress { get; set; }

    /// <summary>
    /// <para>需求人数</para>
    /// <para>必填：是</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("head_count")]
    public int HeadCount { get; set; }

    /// <summary>
    /// <para>职位性质 ID，可在[枚举常量介绍](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/enum)查阅枚举值。</para>
    /// <para>- **注意**：该字段即将下线，请使用`employee_type_id`字段，与`employee_type_id`字段必填其一</para>
    /// <para>必填：否</para>
    /// <para>示例值：101</para>
    /// </summary>
    [JsonPropertyName("recruitment_type_id")]
    public string? RecruitmentTypeId { get; set; }

    /// <summary>
    /// <para>人员类型ID，类型需与`employee_type_id_type`保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254285</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>最高职级 ID，需与`job_level_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254286</para>
    /// </summary>
    [JsonPropertyName("max_level_id")]
    public string? MaxLevelId { get; set; }

    /// <summary>
    /// <para>最低职级 ID，需与`job_level_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254287</para>
    /// </summary>
    [JsonPropertyName("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>职位序列 ID，需与`job_family_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6911957338526091536</para>
    /// </summary>
    [JsonPropertyName("sequence_id")]
    public string? SequenceId { get; set; }

    /// <summary>
    /// <para>需求类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：新增</item>
    /// <item>2：替换</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("category")]
    public int? Category { get; set; }

    /// <summary>
    /// <para>需求部门 ID，需与`department_id_type`类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>需求负责人 ID 列表，需与`user_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("recruiter_id_list")]
    public string[]? RecruiterIdList { get; set; }

    /// <summary>
    /// <para>需求用人经理 ID 列表，需与`user_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("jr_hiring_manager_id_list")]
    public string[]? JrHiringManagerIdList { get; set; }

    /// <summary>
    /// <para>直属上级 ID，需与`user_id_type`类型保持一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("direct_leader_id_list")]
    public string[]? DirectLeaderIdList { get; set; }

    /// <summary>
    /// <para>开始日期，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1625729379000</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>预计完成日期，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1625729379000</para>
    /// </summary>
    [JsonPropertyName("deadline")]
    public string? Deadline { get; set; }

    /// <summary>
    /// <para>招聘优先级</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：高</item>
    /// <item>2：中</item>
    /// <item>3：低</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// <para>学历要求</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
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
    /// <para>月薪范围-最高薪资，单位：K</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("max_salary")]
    public string? MaxSalary { get; set; }

    /// <summary>
    /// <para>月薪范围-最低薪资，单位：K</para>
    /// <para>必填：否</para>
    /// <para>示例值：5</para>
    /// </summary>
    [JsonPropertyName("min_salary")]
    public string? MinSalary { get; set; }

    /// <summary>
    /// <para>工作地址 ID，可通过[获取地址列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/location/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7265901641899311105</para>
    /// </summary>
    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    /// <summary>
    /// <para>需求描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：部门人力紧缺，需要招聘资深工程师10名</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>自定义字段，可通过[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)获取自定义字段列表、类型等</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_data_list")]
    public JobRequirementCustomizedData[]? CustomizedDataLists { get; set; }

    /// <summary>
    /// <para>自定义字段，可通过[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)获取自定义字段列表、类型等</para>
    /// </summary>
    public record JobRequirementCustomizedData
    {
        /// <summary>
        /// <para>自定义字段 ID，可通过[获取招聘需求模板](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement_schema/list)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>自定义字段 value</para>
        /// <para>- 单选：`"1"`</para>
        /// <para>- 多选：`"[\"1\", \"2\"]"`</para>
        /// <para>- 单行：`"单行文本"`</para>
        /// <para>- 多行：`"多行文本"`</para>
        /// <para>- 数字：`"1"`</para>
        /// <para>- 月份选择：`"1627379423000"`</para>
        /// <para>- 年份选择：`"1627379423000"`</para>
        /// <para>- 日期选择：`"1627379423000"`</para>
        /// <para>- 时间段：`"[\"1577808000000\", \"1612108800000\"]"`</para>
        /// <para>必填：否</para>
        /// <para>示例值：简单文本</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>招聘类型</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：社招</item>
    /// <item>2：校招</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("process_type")]
    public int? ProcessType { get; set; }

    /// <summary>
    /// <para>职位类别，可通过[获取职位类别列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_type/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("job_type_id")]
    public string? JobTypeId { get; set; }

    /// <summary>
    /// <para>关联的职位 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("job_id_list")]
    public string[]? JobIdList { get; set; }

    /// <summary>
    /// <para>职务 ID，可通过[获取租户职务列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获取（仅限飞书人事租户使用）</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807407987381831949</para>
    /// </summary>
    [JsonPropertyName("employment_job_id")]
    public string? EmploymentJobId { get; set; }

    /// <summary>
    /// <para>岗位 ID，可通过[查询岗位信息](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)获取（仅限飞书人事租户使用，若链接无法打开，则说明飞书人事未启用岗位，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)开通）</para>
    /// <para>必填：否</para>
    /// <para>示例值：7094136522860922111</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }
}
