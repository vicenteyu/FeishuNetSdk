// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrCompanyCreatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建公司 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 创建公司 事件体
/// <para>飞书人事中「公司被创建」时将触发此事件。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=company&amp;event=created)</para>
/// <para>接口ID：7423693709786087427</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/company/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcompany%2fevents%2fcreated</para>
/// </summary>
public record CorehrCompanyCreatedV2EventBodyDto() : EventBodyDto("corehr.company.created_v2")
{
    /// <summary>
    /// <para>公司ID。</para>
    /// <para>- 调用[【查询单个公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)、[【通过 ID 批量查询公司信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/company/batch_get)接口返回公司详细信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("company_id")]
    public string? CompanyId { get; set; }
}
