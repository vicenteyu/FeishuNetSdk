// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-22
//
// Last Modified By : yxr
// Last Modified On : 2024-11-22
// ************************************************************************
// <copyright file="PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询人员调整内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 批量查询人员调整内容 请求体
/// <para>根据人员异动记录 ID 批量查询人员调整内容</para>
/// <para>接口ID：7317581509003788292</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/approval_groups/open_query_job_change_list_by_ids</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fapproval_groups%2fopen_query_job_change_list_by_ids</para>
/// </summary>
public record PostCorehrV2ApprovalGroupsOpenQueryJobChangeListByIdsBodyDto
{
    /// <summary>
    /// <para>人员异动记录 ID List, 在组织架构调整发起后，会为调整涉及的员工生成一个 员工异动记录， 对应的记录 ID 即为 job_change_id。 调整记录可通过[【根据流程 ID 查询组织架构调整记录】](ssl://ttdocs/uAjLw4CM/ukTMukTMukTM/corehr-v2/approval_groups/get) 获取。</para>
    /// <para>- 必须是查询参数process_id对应的流程下的人员调整记录ID。</para>
    /// <para>- 未设置时查询到的人员调整记录为空。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("job_change_ids")]
    public string[]? JobChangeIds { get; set; }

    /// <summary>
    /// <para>是否返回部门全路径</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// <para>默认值：false</para>
    /// </summary>
    [JsonPropertyName("need_department_path")]
    public bool? NeedDepartmentPath { get; set; }
}
