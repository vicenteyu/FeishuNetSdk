// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-05-25
//
// Last Modified By : yxr
// Last Modified On : 2025-05-25
// ************************************************************************
// <copyright file="PostDirectoryV1EmployeesByEmployeeIdResurrectBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>恢复离职员工 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Directory;
/// <summary>
/// 恢复离职员工 请求体
/// <para>该接口用于恢复已离职的成员，恢复已离职成员至在职状态。</para>
/// <para>接口ID：7359428234122821636</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/resurrect</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fresurrect</para>
/// </summary>
public record PostDirectoryV1EmployeesByEmployeeIdResurrectBodyDto
{
    /// <summary>
    /// <para>部门信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("employee_order_in_departments")]
    public UpsertUserDepartmentSortInfo[]? EmployeeOrderInDepartments { get; set; }

    /// <summary>
    /// <para>部门信息</para>
    /// </summary>
    public record UpsertUserDepartmentSortInfo
    {
        /// <summary>
        /// <para>部门id，与department_id_type类型保持一致</para>
        /// <para>必填：否</para>
        /// <para>示例值：easdiedqds</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>用户在部门内的排序权重</para>
        /// <para>**数据校验规则：**</para>
        /// <para>长度范围：1～ 3</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("order_weight_in_deparment")]
        public string? OrderWeightInDeparment { get; set; }

        /// <summary>
        /// <para>用户多个部门间的排序权重</para>
        /// <para>**数据校验规则：**</para>
        /// <para>长度范围：1～ 3</para>
        /// <para>必填：否</para>
        /// <para>示例值：20</para>
        /// </summary>
        [JsonPropertyName("order_weight_among_deparments")]
        public string? OrderWeightAmongDeparments { get; set; }

        /// <summary>
        /// <para>是否为用户的主部门（用户只能有一个主部门，且排序权重应最大，不填则默认使用排序第一的部门作为主部门)</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_main_department")]
        public bool? IsMainDepartment { get; set; }
    }

    /// <summary>
    /// <para>选项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("options")]
    public ResurrectEmployeeOptions? Options { get; set; }

    /// <summary>
    /// <para>选项</para>
    /// </summary>
    public record ResurrectEmployeeOptions
    {
        /// <summary>
        /// <para>分配给员工的席位ID列表。可通过下方接口获取到该租户的可用席位ID，参见[获取席位信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/tenant-v2/tenant-product_assign_info/query)。当在混合license模式下，此字段为必填。</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("subscription_ids")]
        public string[]? SubscriptionIds { get; set; }
    }
}
