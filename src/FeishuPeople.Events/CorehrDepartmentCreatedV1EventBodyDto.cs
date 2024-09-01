// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrDepartmentCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】创建部门 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】创建部门 事件体
/// <para>飞书人事中「部门被创建」时将触发此事件。注意：1. 触发时间为部门实际生效时间，如在 2022-01-01 创建部门，部门生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。2. 现在创建部门也会同时触发「部门更新」事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=department&amp;event=created)</para>
/// <para>接口ID：7125370197952086020</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fevents%2fcreated</para>
/// </summary>
public record CorehrDepartmentCreatedV1EventBodyDto() : EventBodyDto("corehr.department.created_v1")
{
    /// <summary>
    /// <para>新建部门的 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }
}
