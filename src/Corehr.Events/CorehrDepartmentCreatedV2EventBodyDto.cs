// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-02-09
//
// Last Modified By : yxr
// Last Modified On : 2025-02-09
// ************************************************************************
// <copyright file="CorehrDepartmentCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建部门V2 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建部门V2 事件体
/// <para>飞书人事中「部门被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=department&amp;event=created)</para>
/// <para>- **v2版本事件支持上级部门的创建事件先于下级部门创建事件推送**，但由于事件不稳定的特性，无法保证100%的事件有序，请确保集成时做好兼容处理（有序事件相较于无序事件时效性有所下降，若不依赖事件有序且对事件时效有强诉求，可使用v1版本事件[【事件】创建部门](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created))</para>
/// <para>接口ID：7451820895977553948</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/events/created-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fevents%2fcreated</para>
/// </summary>
public record CorehrDepartmentCreatedV2EventBodyDto() : EventBodyDto("corehr.department.created_v2")
{
    /// <summary>
    /// <para>部门id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }
}
