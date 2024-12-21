// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PostCorehrV1SecurityGroupsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询部门 / 地点的 HRBP / 属地 BP 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询部门 / 地点的 HRBP / 属地 BP 请求体
/// <para>通过部门或工作地点，查询对应的 HRBP / 属地 BP，返回的信息中包含BP的员工ID、部门ID、属地ID等信息。</para>
/// <para>接口ID：7089329362222448644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fsecurity_group%2fquery</para>
/// </summary>
public record PostCorehrV1SecurityGroupsQueryBodyDto
{
    /// <summary>
    /// <para>角色列表，一次最多支持查询 50 个</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("item_list")]
    public BpRoleOrganization[] ItemLists { get; set; } = Array.Empty<BpRoleOrganization>();

    /// <summary>
    /// <para>角色列表，一次最多支持查询 50 个</para>
    /// </summary>
    public record BpRoleOrganization
    {
        /// <summary>
        /// <para>角色类型的唯一标识</para>
        /// <para>- HRBP：与部门有关，role_key 固定为 「hrbp」</para>
        /// <para>- 属地 BP：与部门、工作地点有关，role_key 固定为 「location_bp」</para>
        /// <para>必填：是</para>
        /// <para>示例值：location_bp</para>
        /// </summary>
        [JsonPropertyName("role_key")]
        public string RoleKey { get; set; } = string.Empty;

        /// <summary>
        /// <para>部门 ID，查询 HRBP 需输入部门 ID，ID类型与department_id_type的取值意义一致。</para>
        /// <para>可以使用 [ID转换服务](https://open.larkoffice.com/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)换取 ==department_id==</para>
        /// <para>部门id也可通过[搜索部门信息](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/department/search)接口获取。</para>
        /// <para>必填：是</para>
        /// <para>示例值：7063072995761456670</para>
        /// </summary>
        [JsonPropertyName("department_id")]
        public string DepartmentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>工作地点 ID，查询属地 BP 需要输入部门 ID 与 工作地点 ID</para>
        /// <para>可从[批量查询地点](https://open.larkoffice.com/document/server-docs/corehr-v1/organization-management/location/list)接口获取，或者在「[飞书人事](https://people.feishu.cn/people/)-组织管理-地点」中查看。</para>
        /// <para>必填：否</para>
        /// <para>示例值：6892687221355185677</para>
        /// </summary>
        [JsonPropertyName("work_location_id")]
        public string? WorkLocationId { get; set; }
    }

    /// <summary>
    /// <para>授权时间大于</para>
    /// <para>必填：否</para>
    /// <para>示例值：1729773628</para>
    /// </summary>
    [JsonPropertyName("updated_at_gte")]
    public string? UpdatedAtGte { get; set; }

    /// <summary>
    /// <para>授权时间小于</para>
    /// <para>必填：否</para>
    /// <para>示例值：1729773628</para>
    /// </summary>
    [JsonPropertyName("updated_at_lte")]
    public string? UpdatedAtLte { get; set; }
}
