// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrOrgRoleAuthorizationUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】组织角色授权变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】组织角色授权变更 事件体
/// <para>当组织上的角色授权发生变更时，触发该事件。例如在部门上修改了角色，并在 2030-01-01 年生效，则事件将在 2030-01-01 触发。注意：当前事件只返回在飞书人事中组织角色的变化，下游组织的影响，可以通过 「获取组织类角色授权列表」获取。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=org_role_authorization&amp;event=updated)</para>
/// <para>接口ID：7188912476535488540</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/authorization/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2forg_role_authorization%2fevents%2fupdated</para>
/// </summary>
public record CorehrOrgRoleAuthorizationUpdatedV1EventBodyDto() : EventBodyDto("corehr.org_role_authorization.updated_v1")
{
    /// <summary>
    /// <para>角色id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("role_id")]
    public string? RoleId { get; set; }

    /// <summary>
    /// <para>管理范围信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("management_scope_list")]
    public ManagementScope[]? ManagementScopeList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public record ManagementScope
    {
        /// <summary>
        /// <para>管理维度</para>
        /// <para>可选值有：</para>
        /// <para>- department：部门</para>
        /// <para>- work_location：工作地点</para>
        /// <para>- company：公司</para>
        /// <para>- social_security_location：社保城市</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("management_dimension")]
        public string? ManagementDimension { get; set; }

        /// <summary>
        /// <para>被授权部门/工作地点/公司/社保城市 ID</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("obj_id")]
        public string? ObjId { get; set; }
    }

    /// <summary>
    /// <para>员工雇佣信息ID list</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id_list")]
    public string[]? EmploymentIdList { get; set; }
}
