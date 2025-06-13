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
/// <para>用户点击卡片进行交互、你的服务端在收到并响应卡片的回调请求后，可调用该接口延时更新卡片。</para>
/// <para>接口ID：6907568030018469890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delay-update-message-card</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDO1YjLzgTN24yM4UjN</para>
/// </summary>
public record PostInteractiveV1CardUpdateBodyDto
{
    /// <summary>
    /// <para>[卡片回传交互](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-callback-communication)回调中包含的 token 参数值。</para>
    /// <para>**示例值**："c-295ee57216a5dc9de90fefd0aadb4b1d7dxxxx"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息卡片的内容，可以是[卡片 JSON 数据](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)，也可以传入[卡片搭建工具](https://open.feishu.cn/cardkit?from=open_docs_overview)搭建的卡片相关信息。详情参考下方的请求体示例。</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("card")]
    public object Card { get; set; } = new();

    /// <summary>
    /// <para>用户的 open_id 列表，用于定义接收更新卡片的用户范围。获取方式参考[如何获取自己的 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>**示例值**：["ou_5ad573a6411d72b8305fda3a9c15xxxx"]</para>
    /// <para>**注意**：</para>
    /// <para>- 该参数仅支持[卡片 JSON 1.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-structure)，且仅在卡片的 `config.update_multi` 参数设置为` false`（即独享卡片）时可用。</para>
    /// <para>- 当卡片 `config.update_multi` 为 `false` 时，该参数必填；若为 `true`（即共享卡片），请勿使用该参数，否则可能导致卡片更新异常。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("open_ids")]
    public string[]? OpenIds { get; set; }
}
