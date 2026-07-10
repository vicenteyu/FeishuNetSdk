// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="PostImV1MessageCotBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建COT 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建COT 请求体
/// <para>调用该接口支持创建一条COT消息，用于与Agent交互时展示Agent的思考过程。</para>
/// <para>接口ID：7657479549125069790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fcreate</para>
/// </summary>
public record PostImV1MessageCotBodyDto
{
    /// <summary>
    /// <para>消息接收者的 ID，ID 类型与查询参数 `receive_id_type` 的取值一致。</para>
    /// <para>**注意事项**：</para>
    /// <para>- 给用户发送消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。例如，你需要给企业全员发送消息，则需要将应用的可用范围设置为全体员工。</para>
    /// <para>- 给群组发送消息时，机器人需要在该群组中，且在群组内拥有发言权限。</para>
    /// <para>- 如果消息接收者为用户，推荐使用用户的 `open_id`。</para>
    /// <para>必填：是</para>
    /// <para>示例值：oc_1b325300f109e05a435e4bde1f7b2ab0</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;

    /// <summary>
    /// <para>需要回复的消息ID, 获取消息ID方式：</para>
    /// <para>取用调用发送消息接口后返回的message_id，[发送消息介绍](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage%2Fcreate)</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_x100b508415d77930ee08f62ce1c1c39</para>
    /// </summary>
    [JsonPropertyName("origin_message_id")]
    public string? OriginMessageId { get; set; }
}
