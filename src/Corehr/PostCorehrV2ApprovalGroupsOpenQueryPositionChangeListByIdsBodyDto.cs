// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-11
//
// Last Modified By : yxr
// Last Modified On : 2025-10-11
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询岗位调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询岗位调整内容 请求体
/// <para>根据岗位调整记录 ID 批量查询岗位调整内容</para>
/// <para>接口ID：7428890785897234433</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_position_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_position_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryPositionChangeListByIdsBodyDto
{
    /// <summary>
    /// <para>岗位调整记录 ID 列表。可通过[【根据流程 ID 查询组织架构调整记录】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get) 获取</para>
    /// <para>- 流程 ID 对应的查询参数名称 "process_id"</para>
    /// <para>- 必须是查询参数process_id对应的流程下的岗位调整记录ID。</para>
    /// <para>- 未设置时查询到的岗位调整记录为空。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("position_change_ids")]
    public string[]? PositionChangeIds { get; set; }

    /// <summary>
    /// <para>是否返回部门全路径， 用于在组织架构调整中新建部门的场景， 由于岗位所属部门还未生效， 因此返回部门全路径用于数据查询</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("need_department_path")]
    public bool? NeedDepartmentPath { get; set; }
}
