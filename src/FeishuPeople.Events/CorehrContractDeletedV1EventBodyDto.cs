// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrContractDeletedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>合同删除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 合同删除 事件体
/// <para>通过开放平台删除合同时，会触发该事件。注意：删除后，无法通过搜索接口查询到合同信息。{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=contract&amp;event=deleted)</para>
/// <para>接口ID：7287992767983812609</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/contract/contract-events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fevents%2fdeleted</para>
/// </summary>
public record CorehrContractDeletedV1EventBodyDto() : EventBodyDto("corehr.contract.deleted_v1")
{
    /// <summary>
    /// <para>合同ID，删除后无法通过接口查询到数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }
}
