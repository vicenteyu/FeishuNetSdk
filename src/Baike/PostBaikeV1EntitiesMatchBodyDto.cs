// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBaikeV1EntitiesMatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>精准搜索词条 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 精准搜索词条 请求体
/// <para>将关键词与词条名、别名精准匹配，并返回对应的 词条 ID。</para>
/// <para>接口ID：7016992864837337116</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/baike-v1/entity/match</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbaike-v1%2fentity%2fmatch</para>
/// </summary>
public record PostBaikeV1EntitiesMatchBodyDto
{
    /// <summary>
    /// <para>搜索关键词，将与词条名、别名进行精准匹配</para>
    /// <para>必填：是</para>
    /// <para>示例值：飞书词典</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("word")]
    public string Word { get; set; } = string.Empty;
}
