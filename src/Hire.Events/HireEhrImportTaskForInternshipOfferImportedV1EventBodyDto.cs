// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>导入 e-HR（实习 Offer） 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire.Events;
/// <summary>
/// 导入 e-HR（实习 Offer） 事件体
/// <para>飞书招聘系统内用户选择实习 Offer 导入 e-HR 系统之后，将通过该事件推送候选人信息。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=hire&amp;version=v1&amp;resource=ehr_import_task_for_internship_offer&amp;event=imported)</para>
/// <para>接口ID：7219143467641470979</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/events/imported</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fehr_import_task_for_internship_offer%2fevents%2fimported</para>
/// </summary>
public record HireEhrImportTaskForInternshipOfferImportedV1EventBodyDto() : EventBodyDto("hire.ehr_import_task_for_internship_offer.imported_v1")
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
    /// <para>Offer ID，详情请参考[获取 Offer 详情](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/offer/get)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("offer_id")]
    public string? OfferId { get; set; }

    /// <summary>
    /// <para>入职ID（实习）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pre_onboard_id")]
    public string? PreOnboardId { get; set; }

    /// <summary>
    /// <para>导入部门 ID，等同于`ehr_department. department_id`字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ehr_department_id")]
    public string? EhrDepartmentId { get; set; }

    /// <summary>
    /// <para>操作人的用户user id，等同于`operator_user_id.user_id`字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public string? OperatorId { get; set; }

    /// <summary>
    /// <para>操作人用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_user_id")]
    public UserIdSuffix? OperatorUserId { get; set; }

    /// <summary>
    /// <para>导入部门ID</para>
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
