// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrContractUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>合同更新 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople.Events;
/// <summary>
/// 合同更新 事件体
/// <para>通过开放平台更新合同或者在飞书人事系统进行变更和续约等业务操作时，会触发本事件{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v1&amp;resource=contract&amp;event=updated)</para>
/// <para>接口ID：7287992767983796225</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fevents%2fupdated</para>
/// </summary>
public record CorehrContractUpdatedV1EventBodyDto() : EventBodyDto("corehr.contract.updated_v1")
{
    /// <summary>
    /// <para>合同ID，该合同详细信息可通过[【合同信息查询接口】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/get)获取</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contract_id")]
    public string? ContractId { get; set; }
}
