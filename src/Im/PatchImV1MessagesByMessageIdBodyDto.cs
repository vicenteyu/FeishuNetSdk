// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchImV1MessagesByMessageIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新应用发送的消息卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 更新应用发送的消息卡片 请求体
/// <para>更新应用已发送的消息卡片内容。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 注意事项</para>
/// <para>- 若以 user_access_token 更新消息，该操作用户必须是卡片消息的发送者。</para>
/// <para>- 仅支持更新未撤回的[共享卡片](ukTMukTMukTM/uAjNwUjLwYDM14CM2ATN)消息。你需在卡片的 config 属性中，显式声明 =="update_multi":true==。</para>
/// <para>## 使用限制</para>
/// <para>- 不支持更新批量消息。</para>
/// <para>- 仅支持更新 14 天内发送的消息。</para>
/// <para>- 更新的文本消息请求体不可超过 150 KB；卡片及富文本消息请求体不可超过 30 KB。</para>
/// <para>- 单条消息更新频控为 5 QPS。</para>
/// <para>接口ID：6946222931479543809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpatch</para>
/// </summary>
public record PatchImV1MessagesByMessageIdBodyDto
{
    /// <summary>
    /// <para>消息内容 json 格式，[发送消息 content 说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/im-v1/message/create_json)，参考文档中的卡片格式</para>
    /// <para>必填：是</para>
    /// <para>示例值：参考链接</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
