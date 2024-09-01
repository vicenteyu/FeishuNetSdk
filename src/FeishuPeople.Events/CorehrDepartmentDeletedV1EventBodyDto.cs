// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrDepartmentDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】删除部门 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】删除部门 事件体
/// <para>飞书人事中「部门被删除」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=department&amp;event=deleted)</para>
/// <para>接口ID：7125370197952069636</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fevents%2fdeleted</para>
/// </summary>
public record CorehrDepartmentDeletedV1EventBodyDto() : EventBodyDto("corehr.department.deleted_v1")
{
    /// <summary>
    /// <para>被删除部门的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>部门编码</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
