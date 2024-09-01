// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrDepartmentUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】更新部门 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】更新部门 事件体
/// <para>飞书人事中「部门信息被更新」时将触发此事件。</para>
/// <para>注意事项：- 触发时间为部门更新实际生效时间，如在 2022-01-01 更新部门，部门更新生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。</para>
/// <para>- 删除部门不会触发「部门更新」事件。</para>
/// <para>接口ID：7125370197952053252</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fevents%2fupdated</para>
/// </summary>
public record CorehrDepartmentUpdatedV1EventBodyDto() : EventBodyDto("corehr.department.updated_v1")
{
    /// <summary>
    /// <para>被更新部门的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>发生变更的字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("field_changes")]
    public string[]? FieldChanges { get; set; }
}
