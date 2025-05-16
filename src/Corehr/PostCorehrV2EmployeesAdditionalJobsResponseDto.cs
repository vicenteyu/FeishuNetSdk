// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-15
//
// Last Modified By : yxr
// Last Modified On : 2025-05-16
// ************************************************************************
// <copyright file="PostCorehrV2EmployeesAdditionalJobsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建兼职 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 创建兼职 响应体
/// <para>创建员工的兼职</para>
/// <para>接口ID：7387981900317540354</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/job_data/employees-additional_job/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployees-additional_job%2fcreate</para>
/// </summary>
public record PostCorehrV2EmployeesAdditionalJobsResponseDto
{
    /// <summary>
    /// <para>兼职信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("additional_job")]
    public EmployeesAdditionalJobWriteResp? AdditionalJob { get; set; }

    /// <summary>
    /// <para>兼职信息</para>
    /// </summary>
    public record EmployeesAdditionalJobWriteResp
    {
        /// <summary>
        /// <para>兼职记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>人员类型 ID，可通过[【查询单个人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/get)获取详细信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("employee_type_id")]
        public string EmployeeTypeId { get; set; } = string.Empty;

        /// <summary>
        /// <para>工时制度 ID，可通过[【查询单个工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("working_hours_type_id")]
        public string? WorkingHoursTypeId { get; set; }

        /// <summary>
        /// <para>工作地点 ID，可通过[【查询单个地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }

        /// <summary>
        /// <para>部门 ID，可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)获取详细信息</para>
        /// <para>类型与 department_id_type 一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>职务 ID，可通过[【查询单个职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// <para>职级 ID，可通过[【查询单个职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372679</para>
        /// </summary>
        [JsonPropertyName("job_level_id")]
        public string? JobLevelId { get; set; }

        /// <summary>
        /// <para>序列 ID，可通过[【查询单个序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：1245678</para>
        /// </summary>
        [JsonPropertyName("job_family_id")]
        public string? JobFamilyId { get; set; }

        /// <summary>
        /// <para>雇佣 ID，可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取详细信息</para>
        /// <para>类型与 user_id_type 一致</para>
        /// <para>必填：是</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>兼职开始日期</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-01</para>
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; } = string.Empty;

        /// <summary>
        /// <para>兼职结束日期</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-02</para>
        /// </summary>
        [JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// <para>直属上级的雇佣 ID，可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取详细信息</para>
        /// <para>类型与 user_id_type 一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("direct_manager_id")]
        public string? DirectManagerId { get; set; }

        /// <summary>
        /// <para>虚线上级的雇佣 ID，可通过[【批量查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)获取详细信息</para>
        /// <para>类型与 user_id_type 一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("dotted_line_manager_id")]
        public string? DottedLineManagerId { get; set; }

        /// <summary>
        /// <para>排班类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "job_data"</para>
        /// <para>- custom_api_name = "work_shift"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("work_shift")]
        public Enum? WorkShift { get; set; }

        /// <summary>
        /// <para>排班类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "job_data"</para>
        /// <para>- custom_api_name = "work_shift"</para>
        /// </summary>
        public record Enum
        {
            /// <summary>
            /// <para>枚举值</para>
            /// <para>必填：是</para>
            /// <para>示例值：phone_type</para>
            /// </summary>
            [JsonPropertyName("enum_name")]
            public string EnumName { get; set; } = string.Empty;

            /// <summary>
            /// <para>枚举多语展示</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("display")]
            public I18n[]? Displies { get; set; }

            /// <summary>
            /// <para>枚举多语展示</para>
            /// </summary>
            public record I18n
            {
                /// <summary>
                /// <para>语言编码（IETF BCP 47）</para>
                /// <para>必填：是</para>
                /// <para>示例值：zh-CN</para>
                /// </summary>
                [JsonPropertyName("lang")]
                public string Lang { get; set; } = string.Empty;

                /// <summary>
                /// <para>文本内容</para>
                /// <para>必填：是</para>
                /// <para>示例值：中文示例</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>薪资类型，可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
        /// <para>- object_api_name = "job_data"</para>
        /// <para>- custom_api_name = "compensation_type"</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("compensation_type")]
        public Enum? CompensationType { get; set; }

        /// <summary>
        /// <para>任职公司，可通过[【查询单个公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)获取详细信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("service_company")]
        public string? ServiceCompany { get; set; }

        /// <summary>
        /// <para>周工作时长【0~168】</para>
        /// <para>必填：否</para>
        /// <para>示例值：5</para>
        /// </summary>
        [JsonPropertyName("weekly_working_hours")]
        public string? WeeklyWorkingHours { get; set; }

        /// <summary>
        /// <para>工作日历 ID，可通过[【查询工作日历】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/leave/work_calendar)获取</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("work_calendar_id")]
        public string? WorkCalendarId { get; set; }

        /// <summary>
        /// <para>岗位 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("position_id")]
        public string? PositionId { get; set; }

        /// <summary>
        /// <para>人员子类型 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6890452208593372680</para>
        /// </summary>
        [JsonPropertyName("employee_subtype_id")]
        public string? EmployeeSubtypeId { get; set; }
    }
}
