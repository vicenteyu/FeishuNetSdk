// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCardkitV1CardsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建卡片实体 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 创建卡片实体 请求体
/// <para>基于卡片 JSON 代码，创建卡片实体。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 卡片实体的有效期为 14 天。即创建卡片实体超出 14 天后，你将无法调用相关接口操作卡片。</para>
/// <para>接口ID：7397265677100974083</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fcreate</para>
/// </summary>
public record PostCardkitV1CardsBodyDto
{
    /// <summary>
    /// <para>卡片数据的类型。取固定值 `card_json`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：card_json</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>卡片 JSON 数据的内容。仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)，即你必须声明 schema 为 2.0。以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"schema\":\"2.0\",\"header\":{\"title\":{\"content\":\"卡片标题\",\"tag\":\"plain_text\"}},\"body\":{\"elements\":[{\"tag\":\"markdown\",\"content\":\"卡片内容\"}]}}</para>
    /// <para>最大长度：3000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = string.Empty;
}
