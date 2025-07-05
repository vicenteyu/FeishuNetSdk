// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PutCardkitV1CardsByCardIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>全量更新卡片实体 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 全量更新卡片实体 请求体
/// <para>传入新的卡片 JSON 代码，覆盖更新指定的卡片实体的所有内容。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份（tenant_access_token）需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397253002364682243</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fupdate</para>
/// </summary>
public record PutCardkitV1CardsByCardIdBodyDto
{
    /// <summary>
    /// <para>更新后的完整卡片 JSON 内容。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("card")]
    public PutCardkitV1CardsByCardIdBodyDtoCard Card { get; set; } = new();

    /// <summary>
    /// <para>更新后的完整卡片 JSON 内容。</para>
    /// </summary>
    public record PutCardkitV1CardsByCardIdBodyDtoCard
    {
        /// <summary>
        /// <para>卡片数据的类型。取固定值 `card_json`。</para>
        /// <para>必填：是</para>
        /// <para>示例值：card_json</para>
        /// <para>最大长度：50</para>
        /// <para>最小长度：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>card_json：卡片 JSON 数据类型</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>卡片 JSON 数据的内容。</para>
        /// <para>**注意**：</para>
        /// <para>- 仅支持 JSON 2.0 版本的卡片结构。</para>
        /// <para>- 以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
        /// <para>必填：是</para>
        /// <para>示例值：{\"schema\":\"2.0\",\"header\":{\"title\":{\"content\":\"项目进度更新提醒\",\"tag\":\"plain_text\"}},\"body\":{\"elements\":[{\"tag\":\"markdown\",\"content\":\"截至今日，项目完成度已达80%\"}]}}</para>
        /// <para>最大长度：1000000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; } = string.Empty;
    }

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
    /// <para>**数据校验规则**：int32 范围（ `1`~`2147483647`）内的正整数</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }
}
