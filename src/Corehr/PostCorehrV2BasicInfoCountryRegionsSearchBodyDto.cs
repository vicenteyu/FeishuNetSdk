// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCountryRegionsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询国家/地区信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询国家/地区信息 请求体
/// <para>根据国家/地区 ID、状态，批量查询国家/地区信息</para>
/// <para>接口ID：7301516605753229315</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-4</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-country_region%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCountryRegionsSearchBodyDto
{
    /// <summary>
    /// <para>国家/地区 ID 列表，不填写则返回全部</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("country_region_id_list")]
    public string[]? CountryRegionIdList { get; set; }

    /// <summary>
    /// <para>国家/地区数据的状态列表，不填写则返回全部</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：生效</item>
    /// <item>0：失效</item>
    /// </list></para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
