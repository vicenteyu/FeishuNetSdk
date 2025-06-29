// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoDistrictsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询区/县信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询区/县信息 请求体
/// <para>根据区/县 ID、上级城市 ID，查询区/县信息</para>
/// <para>接口ID：7301516605753147395</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/location_data/search-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-district%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoDistrictsSearchBodyDto
{
    /// <summary>
    /// <para>所属城市 ID 列表，详细信息可通过[查询城市信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-city/search)</para>
    /// <para>接口查询获得，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("city_id_list")]
    public string[]? CityIdList { get; set; }

    /// <summary>
    /// <para>区/县 ID 列表，不填则返回全部</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("district_id_list")]
    public string[]? DistrictIdList { get; set; }

    /// <summary>
    /// <para>区/县状态列表，不填则返回全部</para>
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
