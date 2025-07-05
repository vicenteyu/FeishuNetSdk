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
/// <para>基于卡片 JSON 代码或卡片搭建工具搭建的卡片，创建卡片实体。用于后续通过卡片实体 ID（card_id）发送卡片、更新卡片等。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)或卡片搭建工具搭建的[新版卡片](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/feishu-card-cardkit/cardkit-upgraded-version-card-release-notes)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 一个卡片实体，仅支持发送一次。</para>
/// <para>- 卡片实体的有效期为 14 天。即创建卡片实体超出 14 天后，你将无法调用相关接口操作卡片。</para>
/// <para>接口ID：7397265677100974083</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fcreate</para>
/// </summary>
public record PostCardkitV1CardsBodyDto
{
    /// <summary>
    /// <para>卡片类型。可选值：</para>
    /// <para>- `card_json`：由卡片 JSON 代码构建的卡片</para>
    /// <para>- `template`：由[卡片搭建工具](https://open.feishu.cn/cardkit?from=open_docs)搭建的卡片模板</para>
    /// <para>必填：是</para>
    /// <para>示例值：card_json</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>卡片数据。需要与 `type` 指定的类型一致：</para>
    /// <para>- 若 `type` 为 `card_json`，则此处应传卡片 JSON 代码，并确保将其转义为字符串。仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)，即你必须声明 `schema` 为 `2.0`</para>
    /// <para>- 若 `type` 为 `template`，则此处应传卡片模板的数据，并确保将其转义为字符串。仅支持新版卡片。即在搭建工具中，卡片名称旁应有“新版”标识</para>
    /// <para>必填：是</para>
    /// <para>示例值：请参考下文请求体示例</para>
    /// <para>最大长度：3000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; } = string.Empty;
}
