// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireEhrImportTaskImportedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>导入 e-HR 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 导入 e-HR 事件体
/// <para>当用户在招聘系统中对候选人的投递操作「导入 e-HR」后，将会触发该事件，推送候选人信息至订阅系统。如需接收到该事件，则需先配置事件订阅。详情参考 [事件订阅概述](https://open.feishu.cn/document/ukTMukTMukTM/uUTNz4SN1MjL1UzM)。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=ehr_import_task&amp;event=imported)</para>
/// <para>接口ID：7385126614165389313</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/ehr_import_task/events/imported</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fehr_import_task%2fevents%2fimported</para>
/// </summary>
public record HireEhrImportTaskImportedV1EventBodyDto() : EventBodyDto("hire.ehr_import_task.imported_v1")
{
    /// <summary>
    /// <para>导入任务 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }

    /// <summary>
    /// <para>投递 ID，详情请参考[获取投递信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>导入部门 ID，类型为 `people_admin_department_id`，已不推荐使用，请使用 ehr_department 字段的部门数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ehr_department_id")]
    public string? EhrDepartmentId { get; set; }

    /// <summary>
    /// <para>招聘需求 ID，详情请参考[获取招聘需求信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/job_requirement/list_by_id)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ehr_requirement_id")]
    public string? EhrRequirementId { get; set; }

    /// <summary>
    /// <para>操作人的飞书招聘 user_id，类型为`people_admin_id`，已不推荐使用，请使用 operator_user_id 字段的用户数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>操作用户，用户资源详情请参考[用户资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/field-overview)</para>
    /// <para>如何获取用户信息请参考[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public UserIdSuffix? OperatorUserId { get; set; }

    /// <summary>
    /// <para>导入部门，部门资源详情请参考[部门资源介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/field-overview)，如何获取部门请参考[获取单个部门信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/department/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ehr_department")]
    public DepartmentIdSuffix? EhrDepartment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record DepartmentIdSuffix
    {
        /// <summary>
        /// <para>导入部门的部门 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>导入部门的飞书部门 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("open_department_id")]
        public string? OpenDepartmentId { get; set; }
    }
}
