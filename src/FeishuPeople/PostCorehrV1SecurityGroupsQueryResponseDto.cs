// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1SecurityGroupsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询部门 / 地点的 HRBP / 属地 BP 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询部门 / 地点的 HRBP / 属地 BP 响应体
/// <para>通过部门或工作地点，查询对应的 HRBP / 属地 BP，返回的信息中包含BP的员工ID、部门ID、属地ID等信息。</para>
/// <para>接口ID：7089329362222448644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2fquery</para>
/// </summary>
public record PostCorehrV1SecurityGroupsQueryResponseDto
{
    /// <summary>
    /// <para>HRBP/属地 BP 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("hrbp_list")]
    public Hrbp[]? HrbpLists { get; set; }

    /// <summary>
    /// <para>HRBP/属地 BP 信息</para>
    /// </summary>
    public record Hrbp
    {
        /// <summary>
        /// <para>HRBP/属地 BP 的雇员ID ：</para>
        /// <para>对于 HRBP 而言，若入参的部门没有找到对应的 HRBP，将向上找寻，即向其上级部门取对应的 HRBP，且同一部门可能有多个 HRBP；</para>
        /// <para>对于 属地 BP 而言，若入参的部门和地点没有找到对应的属地 BP，将优先拿地点向上找寻，即向其上级地点取对应的属地 BP</para>
        /// <para>如想获取BP的详细信息，可通过[搜索员工信息](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/search)接口获取。</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("employment_id_list")]
        public string[] EmploymentIdList { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>部门 ID</para>
        /// <para>如想获取部门详细信息，可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search)接口获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：7063072995761456670</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>工作地点 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6892687221355185677</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }
    }
}
