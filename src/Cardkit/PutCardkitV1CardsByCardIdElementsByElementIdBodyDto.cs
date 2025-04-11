// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PutCardkitV1CardsByCardIdElementsByElementIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新组件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 更新组件 请求体
/// <para>更新卡片实体中的指定组件为新组件。支持传入多个组件。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397265677100990467</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fupdate</para>
/// </summary>
public record PutCardkitV1CardsByCardIdElementsByElementIdBodyDto
{
    /// <summary>
    /// <para>幂等 ID，可通过传入唯一的 UUID 以保证相同批次的操作只进行一次。</para>
    /// <para>必填：否</para>
    /// <para>示例值：191857678434</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// <para>新的组件的完整的 JSON 数据。以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"tag\":\"markdown\",\"element_id\":\"md_1\",\"content\":\"示例文本\"}</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("element")]
    public string Element { get; set; } = string.Empty;

    /// <summary>
    /// <para>卡片处于流式更新模式时，操作卡片的序号。用于保证多次更新的时序性。该序号的值应为正整数，由开发者自定义。取值范围为 int32 范围内的值。</para>
    /// <para>**注意**：</para>
    /// <para>在卡片的单次流式更新开启期间，若多次更新卡片，你需确保 `sequence` 逐次递增，否则将报 300317 错误码。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }
}
