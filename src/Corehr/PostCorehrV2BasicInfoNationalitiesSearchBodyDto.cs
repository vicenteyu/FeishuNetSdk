// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoNationalitiesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询国籍信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询国籍信息 请求体
/// <para>根据国籍 ID、国家 ID，查询国籍信息</para>
/// <para>接口ID：7301516605753180163</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/basic_info-nationality/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-nationality%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoNationalitiesSearchBodyDto
{
    /// <summary>
    /// <para>国籍 ID 列表，可从[批量查询员工信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/batch_get)接口返回的 `person_info.nationality_id_v2` 等字段中获取，不填则返回全部</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("nationality_id_list")]
    public string[]? NationalityIdList { get; set; }

    /// <summary>
    /// <para>国家 / 地区 ID 列表，可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search)接口查询，不填则返回全部</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("country_region_id_list")]
    public string[]? CountryRegionIdList { get; set; }

    /// <summary>
    /// <para>状态列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }
}
