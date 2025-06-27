// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>流式更新文本 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 流式更新文本 请求体
/// <para>对卡片中的普通文本元素（tag 为 plain_text 的元素）或富文本组件（tag 为 markdown 的组件）传入全量文本内容，以实现“打字机”式的文字输出效果。参考[流式更新卡片](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/streaming-updates-openapi-overview)，了解流式更新文本的完整流程。</para>
/// <para>## 输出效果说明</para>
/// <para>若旧文本为传入的新文本的前缀子串，新增文本将在旧文本末尾继续以打字机效果输出；若新旧文本前缀不同，全量文本将直接上屏输出，无打字机效果。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份（tenant_access_token）需与创建目标卡片实体的应用身份一致。</para>
/// <para>## 前提条件</para>
/// <para>调用该接口时，需确保已开启卡片的流式更新模式，即将 `streaming_mode` 设为 `true`。</para>
/// <para>接口ID：7397253002364649475</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/content</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcontent</para>
/// </summary>
public record PutCardkitV1CardsByCardIdElementsByElementIdContentBodyDto
{
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
    /// <para>新的全量文本内容。使用时请注意转义为字符串。</para>
    /// <para>**注意**：</para>
    /// <para>- 若 content 中含有代码块，你需将代码块前后的空格去掉，否则可能导致代码渲染失败。</para>
    /// <para>- 若旧文本为传入的新文本的前缀子串，新增文本将在旧文本末尾继续以打字机效果输出；若新旧文本前缀不同，全量文本将直接上屏输出，无打字机效果。</para>
    /// <para>必填：是</para>
    /// <para>示例值：这是更新后的文本内容。将以打字机式的效果输出</para>
    /// <para>最大长度：100000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// <para>卡片处于流式更新模式时，操作卡片的序号。用于保证多次更新的时序性。</para>
    /// <para>**注意**：</para>
    /// <para>请确保在通过卡片 OpenAPI 操作同一张卡片时，sequence 的值相较于上一次操作严格递增。</para>
    /// <para>**数据校验规则**：int32 范围（ `1`~`2147483647`）内的正整数。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }
}
