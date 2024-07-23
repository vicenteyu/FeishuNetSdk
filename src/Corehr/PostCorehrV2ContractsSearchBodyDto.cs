// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2ContractsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索合同 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索合同 请求体
/// <para>该接口可用于搜索合同信息，包括合同开始时间、合同预计结束时间、合同实际结束时间、合同公司主体等信息</para>
/// <para>接口ID：7248868628551303172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/contract/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcontract%2fsearch</para>
/// </summary>
public record PostCorehrV2ContractsSearchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID 列表，雇佣ID可通过[【查询员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口查询；最多支持传入20个ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id_list")]
    public string[]? EmploymentIdList { get; set; }

    /// <summary>
    /// <para>合同 ID 列表，该ID可以通过[【批量查询合同】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/list)接口获取；最多支持传入20个ID。</para>
    /// <para>注意：以上两个筛选条件如果都填写，则是 「与」 的关系；如果都不填写，默认返回所有的合同列表信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contract_id_list")]
    public string[]? ContractIdList { get; set; }
}
