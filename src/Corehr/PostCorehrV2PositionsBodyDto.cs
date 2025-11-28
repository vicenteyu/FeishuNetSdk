// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="PostCorehrV2PositionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建岗位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建岗位信息 请求体
/// <para>创建岗位，可定义岗位关联的职务、职级、序列，以及岗位描述等</para>
/// <para>接口ID：7384280065851113473</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fcreate</para>
/// </summary>
public record PostCorehrV2PositionsBodyDto
{
    /// <summary>
    /// <para>岗位编码 (不能与其他记录的编码重复)</para>
    /// <para>- 开启自动编码时，以自动生成的编码值为准，传入值不生效</para>
    /// <para>- 未开启自动编码时，编码字段值以传入值为准</para>
    /// <para>必填：否</para>
    /// <para>示例值：A01234</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// <para>名称</para>
    /// <para>必填：是</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("names")]
    public I18n[] Names { get; set; } = [];

    /// <summary>
    /// <para>名称</para>
    /// </summary>
    public record I18n
    {
        /// <summary>
        /// <para>名称信息的语言，支持中文和英文。中文用zh-CN；英文用en-US</para>
        /// <para>必填：是</para>
        /// <para>示例值：zh-CN</para>
        /// </summary>
        [JsonPropertyName("lang")]
        public string Lang { get; set; } = string.Empty;

        /// <summary>
        /// <para>支持 zh-CN 和 en-US，最大长度为 255 字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：高级产品经理</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>描述</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("descriptions")]
    public I18n[]? Descriptions { get; set; }

    /// <summary>
    /// <para>序列 ID 列表，详细信息可通过[查询单个序列](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)接口获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_family_ids")]
    public string[]? JobFamilyIds { get; set; }

    /// <summary>
    /// <para>成本中心 ID，可以通过[搜索成本中心信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口获取对应的成本中心信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// <para>职务，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详细信息</para>
    /// <para>必填：是</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string JobId { get; set; } = string.Empty;

    /// <summary>
    /// <para>职级 ID 列表，可通过[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_level_ids")]
    public string[]? JobLevelIds { get; set; }

    /// <summary>
    /// <para>人员类型 ID 列表，可通过文档[查询人员类型](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获得详细信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employee_type_ids")]
    public string[]? EmployeeTypeIds { get; set; }

    /// <summary>
    /// <para>职等 ID 列表，可通过 [【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取详细信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("job_grade_ids")]
    public string[]? JobGradeIds { get; set; }

    /// <summary>
    /// <para>工作地点 ID 列表，详细信息可通过[查询单个地点](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)接口获得</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("work_location_ids")]
    public string[]? WorkLocationIds { get; set; }

    /// <summary>
    /// <para>工时制度 ID 列表，可通过[【查询单个工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)查询详细信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>部门 ID，详细信息可通过[查询单个部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/get)接口获得</para>
    /// <para>- ID 类型必须与查询参数 department_id_type 的取值一致</para>
    /// <para>必填：是</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string DepartmentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>直属上级岗位ID，详细信息可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("direct_leader_id")]
    public string? DirectLeaderId { get; set; }

    /// <summary>
    /// <para>虚线上级岗位ID，详细信息可通过[查询岗位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query)接口获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：4719519211875096301</para>
    /// </summary>
    [JsonPropertyName("dotted_line_leader_id")]
    public string? DottedLineLeaderId { get; set; }

    /// <summary>
    /// <para>是否关键岗位</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_key_position")]
    public bool? IsKeyPosition { get; set; }

    /// <summary>
    /// <para>生效日期，输入日期格式的字符串</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-01</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public CustomFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// </summary>
    public record CustomFieldData
    {
        /// <summary>
        /// <para>自定义字段 apiname，即自定义字段的唯一标识，由租户自定义，可通过 [查询岗位信息] (https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/position/query) 获取</para>
        /// <para>- 最多传入 200 个自定义字段</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("custom_api_name")]
        public string CustomApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是 json 转义后的字符串，根据元数据定义不同，字段格式不同（如 123, 123.23, "true", ["id1","id2"], "2006-01-02 15:04:05"）</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"231\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
