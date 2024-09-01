// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrPersonCreatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】个人信息创建 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】个人信息创建 事件体
/// <para>目前以下场景会触发该事件：</para>
/// <para>- 调用[【创建个人信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/person/create)、[【添加人员】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/create)接口</para>
/// <para>- 人事系统【添加人员】、【导入人员】功能{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=person&amp;event=created)</para>
/// <para>接口ID：7215117200150495260</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fevents%2fcreated</para>
/// </summary>
public record CorehrPersonCreatedV1EventBodyDto() : EventBodyDto("corehr.person.created_v1")
{
    /// <summary>
    /// <para>人员ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }
}
