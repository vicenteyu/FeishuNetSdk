namespace FeishuNetSdk.Corehr;
/// <summary>
/// 搜索合同 请求体
/// <para>搜索合同信息</para>
/// <para>接口ID：7248868628551303172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/contract/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcontract%2fsearch</para>
/// </summary>
public record PostCorehrV2ContractsSearchBodyDto
{
    /// <summary>
    /// <para>雇佣 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id_list")]
    public string[]? EmploymentIdList { get; set; }

    /// <summary>
    /// <para>合同ID列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("contract_id_list")]
    public string[]? ContractIdList { get; set; }
}
