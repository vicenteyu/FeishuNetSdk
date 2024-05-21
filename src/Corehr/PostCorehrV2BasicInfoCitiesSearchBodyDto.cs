namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询城市信息 请求体
/// <para>根据上级省份/行政区 ID 、城市 ID、状态 查询城市（自治区、地区、县「美」、町、村「日」）信息</para>
/// <para>接口ID：7301516605753131011</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-city%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCitiesSearchBodyDto
{
    /// <summary>
    /// <para>省份/行政区 ID 列表，可通过[查询省份/行政区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search)接口获取，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("country_region_subdivision_id_list")]
    public string[]? CountryRegionSubdivisionIdList { get; set; }

    /// <summary>
    /// <para>城市 ID 列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("city_id_list")]
    public string[]? CityIdList { get; set; }

    /// <summary>
    /// <para>城市状态列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
