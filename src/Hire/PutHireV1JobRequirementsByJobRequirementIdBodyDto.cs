using Newtonsoft.Json;
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
    [JsonProperty("name")]
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
    [JsonProperty("display_progress")]
    public int DisplayProgress { get; set; }

    /// <summary>
    /// <para>需求人数</para>
    /// <para>必填：是</para>
    /// <para>示例值：11</para>
    /// </summary>
    [JsonProperty("head_count")]
    public int HeadCount { get; set; }

    /// <summary>
    /// <para>职位性质 ID，可在「招聘枚举常量」文档中查看枚举值，即将下线，请尽快切换至「employee_type_id」字段,与「employee_type_id」必填其一</para>
    /// <para>必填：否</para>
    /// <para>示例值：101</para>
    /// </summary>
    [JsonProperty("recruitment_type_id")]
    public string? RecruitmentTypeId { get; set; }

    /// <summary>
    /// <para>人员类型，枚举值通过[「获取员工类型列表</para>
    /// <para>」](https://open.feishu.cn/document/server-docs/people_admin-v1/employee_type/list)接口获取，可完全替代之前的「职位性质」字段、且有更好的扩展性。请确保已开通「招聘需求使用人员类型数据」灰度，如不确定，可联系技术支持。</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254285</para>
    /// </summary>
    [JsonProperty("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>最高职级 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6807409776231254285</para>
    /// </summary>
    [JsonProperty("max_level_id")]
    public string? MaxLevelId { get; set; }

    /// <summary>
    /// <para>最低职级 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6911957338526091534</para>
    /// </summary>
    [JsonProperty("min_level_id")]
    public string? MinLevelId { get; set; }

    /// <summary>
    /// <para>职位序列 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6911957338526091536</para>
    /// </summary>
    [JsonProperty("sequence_id")]
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
    [JsonProperty("category")]
    public int? Category { get; set; }

    /// <summary>
    /// <para>需求部门的 open department id</para>
    /// <para>必填：否</para>
    /// <para>示例值：od-4e6ac4d14bcd5071a37a39de902c7141</para>
    /// </summary>
    [JsonProperty("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>需求负责人 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("recruiter_id_list")]
    public string[]? RecruiterIdList { get; set; }

    /// <summary>
    /// <para>需求用人经理 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("jr_hiring_manager_id_list")]
    public string[]? JrHiringManagerIdList { get; set; }

    /// <summary>
    /// <para>直属上级 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonProperty("direct_leader_id_list")]
    public string[]? DirectLeaderIdList { get; set; }

    /// <summary>
    /// <para>开始日期，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1625729379000</para>
    /// </summary>
    [JsonProperty("start_time")]
    public string? StartTime { get; set; }

    /// <summary>
    /// <para>预计完成日期，毫秒级时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1625729379000</para>
    /// </summary>
    [JsonProperty("deadline")]
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
    [JsonProperty("priority")]
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
    [JsonProperty("required_degree")]
    public int? RequiredDegree { get; set; }

    /// <summary>
    /// <para>最高薪资，单位：千</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// </summary>
    [JsonProperty("max_salary")]
    public string? MaxSalary { get; set; }

    /// <summary>
    /// <para>最低薪资，单位：千</para>
    /// <para>必填：否</para>
    /// <para>示例值：15</para>
    /// </summary>
    [JsonProperty("min_salary")]
    public string? MinSalary { get; set; }

    /// <summary>
    /// <para>工作地点 ID，枚举值可通过「获取地址列表」接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：11</para>
    /// </summary>
    [JsonProperty("address_id")]
    public string? AddressId { get; set; }

    /// <summary>
    /// <para>需求描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：11</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("customized_data_list")]
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
        [JsonProperty("object_id")]
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
        [JsonProperty("value")]
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
    [JsonProperty("process_type")]
    public int? ProcessType { get; set; }

    /// <summary>
    /// <para>职位类别，枚举值通过「获取职位类别列表」接口获取，是否必填以「获取招聘需求模板」中字段限制为准，通过招聘需求新建职位时会根据此字段回填职位类别</para>
    /// <para>必填：否</para>
    /// <para>示例值：6930815272790114324</para>
    /// </summary>
    [JsonProperty("job_type_id")]
    public string? JobTypeId { get; set; }
}
