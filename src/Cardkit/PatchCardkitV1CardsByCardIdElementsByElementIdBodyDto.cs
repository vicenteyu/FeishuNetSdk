// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PatchCardkitV1CardsByCardIdElementsByElementIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新组件属性 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 更新组件属性 请求体
/// <para>通过传入 `card_id`（卡片实体 ID）和 `element_id`（组件 ID），更新卡片实体中对应组件的属性。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口不支持修改组件的标签（tag）属性。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份（tenant_access_token）需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397253002364567555</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fpatch</para>
/// </summary>
public record PatchCardkitV1CardsByCardIdElementsByElementIdBodyDto
{
    /// <summary>
    /// <para>组件的新的配置项字段。传入 `element_id` 参数后，原组件的 ID 将更新。</para>
    /// <para>**注意**：</para>
    /// <para>- 不支持修改 `tag` 参数。</para>
    /// <para>- 以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>- 仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"content\":\"更新后的组件文本\"}</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("partial_element")]
    public string PartialElement { get; set; } = string.Empty;

    /// <summary>
    /// <para>幂等 ID，可通过传入唯一的 UUID 以保证相同批次的操作只进行一次。</para>
    /// <para>必填：否</para>
    /// <para>示例值：a0d69e20-1dd1-458b-k525-dfeca4015204</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>操作卡片的序号。用于保证多次更新的时序性。</para>
    /// <para>**注意**：</para>
    /// <para>请确保在通过卡片 OpenAPI 操作同一张卡片时，sequence 的值相较于上一次操作严格递增。</para>
    /// <para>**数据校验规则**：int32 范围（ `1`~`2147483647`）内的正整数。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }
}
