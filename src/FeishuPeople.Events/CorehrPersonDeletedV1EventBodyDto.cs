// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrPersonDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>【事件】个人信息删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 【事件】个人信息删除 事件体
/// <para>个人信息删除{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=person&amp;event=deleted)</para>
/// <para>接口ID：7215117200150544412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/person/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fperson%2fevents%2fdeleted</para>
/// </summary>
public record CorehrPersonDeletedV1EventBodyDto() : EventBodyDto("corehr.person.deleted_v1")
{
    /// <summary>
    /// <para>人员ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }
}
