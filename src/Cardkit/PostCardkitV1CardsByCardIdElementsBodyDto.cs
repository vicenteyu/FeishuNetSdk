// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCardkitV1CardsByCardIdElementsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增组件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 新增组件 请求体
/// <para>为指定卡片实体新增组件。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397253002364551171</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcreate</para>
/// </summary>
public record PostCardkitV1CardsByCardIdElementsBodyDto
{
    /// <summary>
    /// <para>添加组件的方式。</para>
    /// <para>必填：是</para>
    /// <para>示例值：insert_before</para>
    /// <para>可选值：<list type="bullet">
    /// <item>insert_before：在目标组件前插入</item>
    /// <item>insert_after：在目标组件后插入</item>
    /// <item>append：在卡片或容器组件末尾添加</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// <para>目标组件的 ID。 填写规则如下所示：</para>
    /// <para>- 当 `type` 为 `insert_before`、`insert_after` 时，为用于定位的目标组件</para>
    /// <para>- 当 `type` 为 `append` 时，该字段仅支持容器类组件，为用于指定末尾添加的目标组件</para>
    /// <para>- 未填写默认为在卡片 body 末尾添加</para>
    /// <para>必填：否</para>
    /// <para>示例值：markdown_1</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("target_element_id")]
    public string? TargetElementId { get; set; }

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
    /// <para>卡片处于流式更新模式时，操作卡片的序号。用于保证多次更新的时序性。该序号的值应为正整数，由开发者自定义。取值范围为 int32 范围内的值。</para>
    /// <para>**注意**：</para>
    /// <para>在卡片的单次流式更新开启期间，若多次更新卡片，你需确保 `sequence` 逐次递增，否则将报 300317 错误码。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }

    /// <summary>
    /// <para>添加的组件列表。以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"tag\":\"markdown\",\"element_id\":\"markdown_2\",\"content\":\"新增富文本组件示例文本\"}]</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("elements")]
    public string Elements { get; set; } = string.Empty;
}
