// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV2BasicInfoCurrenciesSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询货币信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询货币信息 请求体
/// <para>根据货币 ID、状态查询货币信息</para>
/// <para>接口ID：7301516605753163779</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-infomation/currency/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-currency%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoCurrenciesSearchBodyDto
{
    /// <summary>
    /// <para>货币 ID 列表，不填写则返回全部列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("currency_id_list")]
    public string[]? CurrencyIdList { get; set; }

    /// <summary>
    /// <para>货币状态列表，不填写则返回全部列表</para>
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
