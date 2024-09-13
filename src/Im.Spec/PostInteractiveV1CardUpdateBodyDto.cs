// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-08-24
// ************************************************************************
// <copyright file="PostInteractiveV1CardUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>延时更新消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 延时更新消息卡片 请求体
/// <para>用户点击卡片进行交互、你的服务端在收到并响应卡片的回调请求后，可调用该接口延时更新卡片。了解完整的卡片交互配置流程，可参考[配置卡片交互](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/configuring-card-interactions#1b37805e)。</para>
/// <para>接口ID：6907568030018469890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delay-update-message-card</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDO1YjLzgTN24yM4UjN</para>
/// </summary>
public record PostInteractiveV1CardUpdateBodyDto
{
    /// <summary>
    /// <para>[卡片回传交互](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-callback-communication)回调中包含的 token 参数值。</para>
    /// <para>**示例值**：c-295ee57216a5dc9de90fefd0aadb4b1d7dxxxx</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息卡片的 JSON 结构内容。具体结构说明可参见[卡片 JSON 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-structure)。</para>
    /// <para>**示例值**：{"open_ids":["ou_515fbe9d04838174e2035f8xxxx"],"elements":[{"tag":"div","text":{"tag":"plain_text","content":"overflow &amp; datePicker 功能测试"},"fields":[{"is_short":true,"text":{"tag":"lark_md","content":"已同意"}}]}]}</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("card")]
    public object Card { get; set; } = new();

    /// <summary>
    /// <para>用户的 open_id 列表。在卡片 JSON 结构内，支持添加 open_ids 数组参数，通过该参数指定用户 open_id 来定义需要更新卡片的用户范围。用户 open_id 获取方式参考[如何获取自己的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>**示例值**：["ou_5ad573a6411d72b8305fda3a9c15xxxx"]</para>
    /// <para>**注意**：</para>
    /// <para>- 如果卡片为共享卡片（卡片 JSON 结构 `config` 参数内 `"update_multi": true` 表示共享卡片），则无需传入该值，默认会更新所有用户接收到的卡片内容。若传入该值，会导致无法正常更新。</para>
    /// <para>- 非共享卡片必须设置 open_ids。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_ids")]
    public string[]? OpenIds { get; set; }
}
