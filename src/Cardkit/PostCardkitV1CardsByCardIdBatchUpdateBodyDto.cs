// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-01-05
//
// Last Modified By : yxr
// Last Modified On : 2025-01-05
// ************************************************************************
// <copyright file="PostCardkitV1CardsByCardIdBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新卡片实体 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Cardkit;
/// <summary>
/// 批量更新卡片实体 请求体
/// <para>更新指定卡片实体局部，包括配置和组件等。</para>
/// <para>## 使用限制</para>
/// <para>- 本接口仅支持[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
/// <para>- 调用该接口时，不支持将卡片设置为独享卡片模式。即不支持将卡片 JSON 数据中的 `update_multi` 属性设置为 `false`。</para>
/// <para>- 调用该接口的应用身份需与创建目标卡片实体的应用身份一致。</para>
/// <para>接口ID：7397253002364633091</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard%2fbatch_update</para>
/// </summary>
public record PostCardkitV1CardsByCardIdBatchUpdateBodyDto
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
    /// <para>卡片处于流式更新模式时，操作卡片的序号。用于保证多次更新的时序性。该序号的值应为正整数，由开发者自定义。取值范围为 int32 范围内的值。</para>
    /// <para>**注意**：</para>
    /// <para>在卡片的单次流式更新开启期间，若多次更新卡片，你需确保 `sequence` 逐次递增，否则将报 300317 错误码。</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("sequence")]
    public int Sequence { get; set; }

    /// <summary>
    /// <para>操作列表，可选值有：</para>
    /// <para>- `partial_update_setting`：更新卡片配置，支持更新卡片的 config 和 card_link 字段。参数结构可参考[更新卡片配置](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card/settings)；</para>
    /// <para>- `add_elements`：添加组件，支持 type、 target_element_id、elements 字段。参数结构可参考[新增组件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card-element/create)接口请求体；</para>
    /// <para>- `delete_elements`：删除组件，支持 element_ids 字段。参数值为组件 ID 数组。参数结构可参考[删除组件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card-element/delete)；</para>
    /// <para>- `partial_update_element`：更新组件的属性，支持 element_id 和 partial_element 字段。参数结构可参考[更新组件属性](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card-element/patch)接口的路径参数 element_id 和请求体 partial_element 字段 ;</para>
    /// <para>- `update_element`：全量更新组件，支持 element_id 和 element 字段。参数结构可参考[全量更新组件](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/cardkit-v1/card-element/update)接口的路径参数 element_id 和请求体 element 字段</para>
    /// <para>必填：是</para>
    /// <para>示例值：[{\"action\":\"partial_update_setting\",\"params\":{\"config\":{\"streaming_mode\":true},\"card_link\":{\"url\":\"https://open.feishu.cn\"}}},{\"action\":\"add_elements\",\"params\":{\"type\":\"insert_before\",\"target_element_id\":\"text_1\",\"elements\":[{\"tag\":\"markdown\",\"id\":\"md_1\",\"content\":\"示例文本\"}]}},{\"action\":\"delete_elements\",\"params\":{\"element_ids\":[\"text_1\",\"text_2\"]}},{\"action\":\"partial_update_element\",\"params\":{\"element_id\":\"target_element\",\"partial_element\":{\"content\":\"更新后的组件文本\"}}},{\"action\":\"update_element\",\"params\":{\"element_id\":\"target_element\",\"element\":{\"tag\":\"markdown\",\"id\":\"md_1\",\"content\":\"普通文本\"}}}]</para>
    /// <para>最大长度：1000000</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("actions")]
    public string Actions { get; set; } = string.Empty;
}
