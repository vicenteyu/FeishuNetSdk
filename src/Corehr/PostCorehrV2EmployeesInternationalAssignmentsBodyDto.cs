// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-13
//
// Last Modified By : yxr
// Last Modified On : 2025-06-13
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesInternationalAssignmentsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建外派信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建外派信息 请求体
/// <para>为员工添加外派记录，包括外派信息、任职信息</para>
/// <para>接口ID：7446683431818395651</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-international_assignment/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-international_assignment%2fcreate</para>
/// </summary>
public record PostCorehrV2EmployeesInternationalAssignmentsBodyDto
{
    /// <summary>
    /// <para>外派工作地点 ID</para>
    /// <para>- 可通过[【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)获取，并选择【地点用途】为外派地点（international_assignment）的记录</para>
    /// <para>必填：是</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("work_location_id")]
    public string WorkLocationId { get; set; } = string.Empty;

    /// <summary>
    /// <para>外派任职公司 ID</para>
    /// <para>- 可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("service_company")]
    public string? ServiceCompany { get; set; }

    /// <summary>
    /// <para>排班类型</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：job_data</para>
    /// <para>- custom_api_name：work_shift</para>
    /// <para>必填：否</para>
    /// <para>示例值：work_shift</para>
    /// </summary>
    [JsonPropertyName("work_shift")]
    public string? WorkShift { get; set; }

    /// <summary>
    /// <para>周工作时长</para>
    /// <para>- 限制两位小数</para>
    /// <para>必填：否</para>
    /// <para>示例值：8</para>
    /// <para>最大值：168</para>
    /// <para>最小值：0</para>
    /// </summary>
    [JsonPropertyName("weekly_working_hours_v2")]
    public float? WeeklyWorkingHoursV2 { get; set; }

    /// <summary>
    /// <para>工时制度ID</para>
    /// <para>- 可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>人员类型ID</para>
    /// <para>- 可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>部门 ID</para>
    /// <para>- 可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)获取</para>
    /// <para>- 类型与 department_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>职务 ID</para>
    /// <para>- 可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }

    /// <summary>
    /// <para>序列 ID</para>
    /// <para>- 可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }

    /// <summary>
    /// <para>职级 ID</para>
    /// <para>- 可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }

    /// <summary>
    /// <para>职等 ID</para>
    /// <para>- 可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("job_grade_id")]
    public string? JobGradeId { get; set; }

    /// <summary>
    /// <para>薪资类型</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：job_data</para>
    /// <para>- custom_api_name：compensation_type</para>
    /// <para>必填：否</para>
    /// <para>示例值：daily</para>
    /// </summary>
    [JsonPropertyName("compensation_type")]
    public string? CompensationType { get; set; }

    /// <summary>
    /// <para>直属上级雇佣 ID</para>
    /// <para>- 可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取</para>
    /// <para>- 类型与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("direct_manager_id")]
    public string? DirectManagerId { get; set; }

    /// <summary>
    /// <para>虚线上级雇佣 ID</para>
    /// <para>- 可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取</para>
    /// <para>- 类型与 user_id_type 一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("dotted_line_manager_id")]
    public string? DottedLineManagerId { get; set; }

    /// <summary>
    /// <para>工作日历 ID</para>
    /// <para>- 可通过[【查询工作日历】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar)获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("work_calendar_id")]
    public string? WorkCalendarId { get; set; }

    /// <summary>
    /// <para>岗位 ID</para>
    /// <para>- 功能灰度中，请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
    /// <para>必填：否</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }

    /// <summary>
    /// <para>雇佣 ID</para>
    /// <para>- 可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取</para>
    /// <para>- 类型与 user_id_type 一致</para>
    /// <para>- 需要是在职人员的雇佣 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：7127921432117937708</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：180</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>- 请参考[【自定义字段说明】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom-fields-guide)</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(123, 123.23, true, [\"id1\",\"id2\], 2006-01-02 15:04:05])</para>
        /// <para>必填：是</para>
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>外派原因说明</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx 项目派遣</para>
    /// <para>最大长度：5000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("international_assignment_reason")]
    public string? InternationalAssignmentReason { get; set; }

    /// <summary>
    /// <para>备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx 项目</para>
    /// <para>最大长度：10000</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>预计结束日期</para>
    /// <para>- 格式：yyyy-mm-dd</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-02</para>
    /// </summary>
    [JsonPropertyName("international_assignment_expected_end_date")]
    public string? InternationalAssignmentExpectedEndDate { get; set; }

    /// <summary>
    /// <para>外派类型</para>
    /// <para>- 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name：international_assignment</para>
    /// <para>- custom_api_name：international_assignment_type</para>
    /// <para>必填：是</para>
    /// <para>示例值：global_assignment</para>
    /// </summary>
    [JsonPropertyName("international_assignment_type")]
    public string InternationalAssignmentType { get; set; } = string.Empty;

    /// <summary>
    /// <para>开始日期</para>
    /// <para>- 格式：yyyy-mm-dd</para>
    /// <para>必填：是</para>
    /// <para>示例值：2024-01-02</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>结束日期</para>
    /// <para>- 格式：yyyy-mm-dd</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-02</para>
    /// </summary>
    [JsonPropertyName("expiration_time")]
    public string? ExpirationTime { get; set; }
}
