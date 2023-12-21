namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询货币信息v2 请求体
/// <para>根据货币 ID、状态查询货币信息</para>
/// <para>接口ID：7301516605753163779</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-currency/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-currency%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCurrenciesSearchBodyDto
{
    /// <summary>
    /// <para>货币 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("currency_id_list")]
    public string[]? CurrencyIdList { get; set; }

    /// <summary>
    /// <para>状态列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
