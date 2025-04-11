// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-11-22
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询部门调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询部门调整内容 请求体
/// <para>根据部门调整记录 ID 批量查询部门调整内容</para>
/// <para>接口ID：7317581509003771908</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_department_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_department_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryDepartmentChangeListByIdsBodyDto
{
    /// <summary>
    /// <para>部门调整记录 ID 列表， 返回的变更 ID 类型与 请求体中的```department_id_type``` 一致。 调整记录详情可通过[【根据流程 ID 查询组织架构调整记录】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get) 获取。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("department_change_ids")]
    public string[]? DepartmentChangeIds { get; set; }

    /// <summary>
    /// <para>是否返回部门全路径， 用于在组织架构调整中级联创建部门的场景， 由于上级部门还未生效， 因此返回全路径用于数据查询。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("need_department_path")]
    public bool? NeedDepartmentPath { get; set; }
}
