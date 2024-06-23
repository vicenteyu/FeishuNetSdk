// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询省份/行政区信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询省份/行政区信息 请求体
/// <para>根据省份/行政区 ID、状态批量查询行政区、省份、州等数据</para>
/// <para>接口ID：7301516605753245699</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region_subdivision/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region_subdivision%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCountryRegionSubdivisionsSearchBodyDto
{
    /// <summary>
    /// <para>国家/地区 ID 列表，可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口获取，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("country_region_id_list")]
    public string[]? CountryRegionIdList { get; set; }

    /// <summary>
    /// <para>省份/行政区 ID 列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("country_region_subdivision_id_list")]
    public string[]? CountryRegionSubdivisionIdList { get; set; }

    /// <summary>
    /// <para>省份/行政区状态列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
