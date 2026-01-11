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
/// <para>为指定卡片实体新增组件，以扩展卡片内容，如在卡片中添加一个点击按钮。</para>
/// <para>## 使用限制</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份（tenant_access_token）需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397253002364551171</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fcreate</para>
/// </summary>
public record PostCardkitV1CardsByCardIdElementsBodyDto
{
    /// <summary>
    /// <para>添加组件的方式。</para>
    /// <para>必填：是</para>
    /// <para>示例值：insert_after</para>
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
    /// <para>- 当 `type` 为 `insert_before`、`insert_after` 时，字段必填，为用于定位的目标组件</para>
    /// <para>- 当 `type` 为 `append` 时，该字段仅支持容器类组件，用于指定在末尾添加的目标组件。若未填写，则默认在卡片 body 末尾添加</para>
    /// <para>必填：否</para>
    /// <para>示例值：markdown_1</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("target_element_id")]
    public string? TargetElementId { get; set; }

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

    /// <summary>
    /// <para>添加的组件列表。</para>
    /// <para>**注意**：</para>
    /// <para>- 以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>- 本参数仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"tag\":\"button\",\"element_id\":\"button_1\",\"text\":{\"tag\":\"plain_text\",\"content\":\"查看更多\"},\"type\":\"default\",\"width\":\"default\",\"size\":\"medium\",\"behaviors\":[{\"type\":\"open_url\",\"default_url\":\"https://open.feishu.cn/?lang=zh-CN\",\"pc_url\":\"\",\"ios_url\":\"\",\"android_url\":\"\"}]}]</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("elements")]
    public string Elements { get; set; } = string.Empty;
}
