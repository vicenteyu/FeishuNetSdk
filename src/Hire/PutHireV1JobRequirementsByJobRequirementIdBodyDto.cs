// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutHireV1JobRequirementsByJobRequirementIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新招聘需求 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 更新招聘需求 请求体
/// <para>更新招聘需求</para>
/// <para>接口ID：6989078472837169155</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/job_requirement/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fjob_requirement%2fupdate</para>
/// </summary>
public record PutHireV1JobRequirementsByJobRequirementIdBodyDto
{
    /// <summary>
    /// <para>需求名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：test</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>需求状态</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：待启动</item>
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
    /// <para>示例值：11</para>
    /// </summary>
    [JsonPropertyName("head_count")]
    public int HeadCount { get; set; }

    /// <summary>
    /// <para>职位性质 ID，可在「招聘枚举常量」文档中查看枚举值，即将下线，请尽快切换至「employee_type_id」字段,与「employee_type_id」必填其一</para>
    /// <para>必填：否</para>
    /// <para>示例值：101</para>
    /// </summary>
    [JsonPropertyName("recruitment_type_id")]
    public string? RecruitmentTypeId { get; set; }

    /// <summary>
    /// <para>人员类型ID</para>
    /// <para>获取枚举详情见本文档「查询参数」部分；使用该字段前，请联系招聘团队确认已在灰度内</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254285</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>最高职级 ID</para>
    /// <para>获取枚举详情见本文档「查询参数」部分</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254285</para>
    /// </summary>
    [JsonPropertyName("max_level_id")]
    public string? MaxLevelId { get; set; }

    /// <summary>
    /// <para>最低职级 ID</para>
    /// <para>获取枚举详情见本文档「查询参数」部分</para>
    /// <para>必填：否</para>
    /// <para>示例值：6911957338526091534</para>
    /// </summary>
    [JsonPropertyName("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>职位序列 ID</para>
    /// <para>获取枚举详情见本文档「查询参数」部分</para>
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
    /// <para>需求部门的 open department id</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>需求负责人 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("recruiter_id_list")]
    public string[]? RecruiterIdList { get; set; }

    /// <summary>
    /// <para>需求用人经理 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("jr_hiring_manager_id_list")]
    public string[]? JrHiringManagerIdList { get; set; }

    /// <summary>
    /// <para>直属上级 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("direct_leader_id_list")]
    public string[]? DirectLeaderIdList { get; set; }

    /// <summary>
    /// <para>开始日期，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1625729379000</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>预计完成日期，毫秒级时间戳</para>
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
    /// <para>最高薪资，单位：千</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonPropertyName("max_salary")]
    public string? MaxSalary { get; set; }

    /// <summary>
    /// <para>最低薪资，单位：千</para>
    /// <para>必填：否</para>
    /// <para>示例值：15</para>
    /// </summary>
    [JsonPropertyName("min_salary")]
    public string? MinSalary { get; set; }

    /// <summary>
    /// <para>工作地点 ID，枚举值可通过「获取地址列表」接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：11</para>
    /// </summary>
    [JsonPropertyName("address_id")]
    public string? AddressId { get; set; }

    /// <summary>
    /// <para>需求描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：11</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("customized_data_list")]
    public JobRequirementCustomizedData[]? CustomizedDataLists { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record JobRequirementCustomizedData
    {
        /// <summary>
        /// <para>自定义字段 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1213213123123</para>
        /// </summary>
        [JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// <para>自定义字段 value，1. 对于自定义字段，若字段类型为单行文本/多行文本，传值格式为"这是一个文本"；2. 若字段类型为单选，传值内容为选项的 ID，格式为"6890840516938696974"；</para>
        /// <para>3. 若字段类型为多选，传值内容为选项的ID 列表，格式为"[\"6890840516938696974\", \"6890840516938696975\" ]"；</para>
        /// <para>4. 若字段类型为时间段，传值格式为"[\"1609430400000\", \"1612108800000\" ]"，单位是毫米级时间戳；</para>
        /// <para>5. 若字段类型为年份选择，传值格式为"1609430400000"，单位是毫秒级时间戳；</para>
        /// <para>6. 若字段类型为月份选择，传值格式为"1625068800000"，单位是毫秒级时间戳；</para>
        /// <para>7. 若字段类型为数字，传值格式为"1";</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>招聘类型，是否必填以「获取招聘需求模板」中字段限制为准，通过招聘需求新建职位时会根据此字段回填职位招聘类型</para>
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
    /// <para>职位类别，枚举值通过「获取职位类别列表」接口获取，是否必填以「获取招聘需求模板」中字段限制为准，通过招聘需求新建职位时会根据此字段回填职位类别</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonPropertyName("job_type_id")]
    public string? JobTypeId { get; set; }
}
