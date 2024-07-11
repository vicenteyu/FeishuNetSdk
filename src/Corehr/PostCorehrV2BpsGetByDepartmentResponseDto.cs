// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BpsGetByDepartmentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询部门 HRBP 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询部门 HRBP 响应体
/// <para>查询部门的 HRBP 信息，包括来自上级部门的 HRBP。</para>
/// <para>接口ID：7261860942295547906</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/bp/get_by_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2fget_by_department</para>
/// </summary>
public record PostCorehrV2BpsGetByDepartmentResponseDto
{
    /// <summary>
    /// <para>部门 HRBP 信息，依次为部门及各层级上级部门</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public DepartmentHrbp[]? Items { get; set; }

    /// <summary>
    /// <para>部门 HRBP 信息，依次为部门及各层级上级部门</para>
    /// </summary>
    public record DepartmentHrbp
    {
        /// <summary>
        /// <para>部门 ID，ID类型与department_id_type的取值意义一致。</para>
        /// <para>如想获取部门详细信息，可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search)接口获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门 HRBP 员工 ID，ID类型与user_id_type的取值意义一致。</para>
        /// <para>如想获取员工详细信息，可通过[搜索员工信息](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/search)接口获取。</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("hrbp_ids")]
        public string[]? HrbpIds { get; set; }
    }
}
