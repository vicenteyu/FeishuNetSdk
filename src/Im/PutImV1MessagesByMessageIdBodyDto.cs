// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutImV1MessagesByMessageIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>编辑消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 编辑消息 请求体
/// <para>调用该接口编辑已发送的消息内容，支持编辑文本、富文本消息。如需编辑卡片消息，请使用[更新应用发送的消息卡片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/patch)接口。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 编辑用户单聊内的消息时，用户需要在机器人的[可用范围](https://open.feishu.cn/document/home/introduction-to-scope-and-authorization/availability)内。</para>
/// <para>- 编辑群组内的消息时，机器人需要在该群组中，且拥有发言权限。</para>
/// <para>## 使用限制</para>
/// <para>- 一条消息最多可编辑 20 次。</para>
/// <para>- 仅可编辑当前操作者自己发送的消息。</para>
/// <para>- 不可编辑已撤回，已删除，超出可编辑时间的消息。可编辑时间由企业管理员设定，详情了解[管理员设置撤回和编辑消息权限](https://www.feishu.cn/hc/zh-CN/articles/325339752183)。</para>
/// <para>接口ID：7239186075281358852</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fupdate</para>
/// </summary>
public record PutImV1MessagesByMessageIdBodyDto
{
    /// <summary>
    /// <para>消息类型。</para>
    /// <para>**可选值有**：</para>
    /// <para>- text：文本</para>
    /// <para>- post：富文本</para>
    /// <para>必填：是</para>
    /// <para>示例值：text</para>
    /// </summary>
    [JsonPropertyName("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息内容，JSON 结构序列化后的字符串。该参数的取值与 `msg_type` 对应，例如 `msg_type` 取值为 `text`，则该参数需要传入文本类型的内容。</para>
    /// <para>**注意：**</para>
    /// <para>- JSON字符串需进行转义，如换行符转义后为`\\n`</para>
    /// <para>- 文本消息请求体最大不能超过 150 KB</para>
    /// <para>- 富文本消息请求体最大不能超过 30 KB</para>
    /// <para>- 如果消息中包含样式标签，会使实际消息体长度大于您输入的请求体长度。</para>
    /// <para>了解不同类型的消息内容格式、使用限制，可参见[发送消息内容](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{\"text\":\"test content\"}</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
