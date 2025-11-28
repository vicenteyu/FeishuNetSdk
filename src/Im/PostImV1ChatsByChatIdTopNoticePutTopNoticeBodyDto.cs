// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新群置顶 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新群置顶 请求体
/// <para>更新群组中的群置顶信息，可以将群中的某一条消息，或群公告置顶展示。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>调用接口的机器人或者用户必须要在群组内，且和该群组属于同一租户。</para>
/// <para>接口ID：7043611687799816193</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/put_top_notice</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-top_notice%2fput_top_notice</para>
/// </summary>
public record PostImV1ChatsByChatIdTopNoticePutTopNoticeBodyDto
{
    /// <summary>
    /// <para>群置顶配置</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("chat_top_notice")]
    public ChatTopNotice[] ChatTopNotices { get; set; } = [];

    /// <summary>
    /// <para>群置顶配置</para>
    /// </summary>
    public record ChatTopNotice
    {
        /// <summary>
        /// <para>置顶类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：消息类型，必需填写 `message_id`</item>
        /// <item>2：群公告类型，无需填写 `message_id`</item>
        /// </list></para>
        /// <para>默认值：2</para>
        /// </summary>
        [JsonPropertyName("action_type")]
        public string? ActionType { get; set; }

        /// <summary>
        /// <para>消息 ID。ID 获取方式：</para>
        /// <para>- 调用[发送消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/create)接口后，从响应结果的 `message_id` 参数获取。</para>
        /// <para>- 监听[接收消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/events/receive)事件，当触发该事件后可以从事件体内获取消息的 `message_id`。</para>
        /// <para>- 调用[获取会话历史消息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/list)接口，从响应结果的 `message_id` 参数获取。</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }
    }
}
