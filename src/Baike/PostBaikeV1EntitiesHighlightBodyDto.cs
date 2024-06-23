// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBaikeV1EntitiesHighlightBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>词条高亮 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 词条高亮 请求体
/// <para>传入一句话，智能识别句中对应的词条，并返回词条位置和 entity_id，可在外部系统中快速实现词条智能高亮。</para>
/// <para>接口ID：7016992864837369884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fhighlight</para>
/// </summary>
public record PostBaikeV1EntitiesHighlightBodyDto
{
    /// <summary>
    /// <para>需要识别词条的内容（不超过1000字）</para>
    /// <para>必填：是</para>
    /// <para>示例值：词典是飞书提供的一款知识管理工具</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;
}
