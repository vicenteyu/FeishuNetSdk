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
/// <para>调用该接口，通过消息 ID（message_id）更新指定的消息卡片内容。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用场景</para>
/// <para>- 本接口适用于场景卡片发送后，对卡片无条件直接更新的场景。</para>
/// <para>- 如果你需要在用户与卡片进行交互后更新卡片，可参考[处理卡片回调](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/handle-card-callbacks)，选择在 3 秒内立即更新卡片、或 30 分钟内[延时更新卡片](https://open.feishu.cn/document/ukTMukTMukTM/uMDO1YjLzgTN24yM4UjN)的方式。</para>
/// <para>- 如果你需要仅更新部分成员接收到的卡片，你需调用[延时更新消息卡片](https://open.feishu.cn/document/ukTMukTMukTM/uMDO1YjLzgTN24yM4UjN)接口，指定用户的 open_id。</para>
/// <para>## 注意事项</para>
/// <para>- 若以 user_access_token 更新消息，该操作用户必须是卡片消息的发送者。</para>
/// <para>- 仅支持更新未撤回的卡片。</para>
/// <para>- 你需在更新**前后**卡片的 `config` 属性中，均显式声明 =="update_multi":true==（表示卡片为共享卡片，卡片的更新对所有接收的用户可见）。</para>
/// <para>## 使用限制</para>
/// <para>- 不支持更新[批量发送的消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)。</para>
/// <para>- 仅支持更新 14 天内发送的消息。</para>
/// <para>- 单条消息更新频控为 5 QPS。</para>
/// <para>接口ID：6946222931479543809</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fpatch</para>
/// </summary>
public record PatchImV1MessagesByMessageIdBodyDto
{
    /// <summary>
    /// <para>消息卡片的内容，支持卡片 JSON 或[搭建工具](https://open.feishu.cn/cardkit?from=open_docs)构建的卡片，需为 JSON 结构序列化后的字符串。</para>
    /// <para>- 要使用卡片 JSON，参考[卡片 JSON 2.0 结构](https://open.feishu.cn/document/uAjLw4CM/ukzMukzMukzM/feishu-cards/card-json-v2-structure)。</para>
    /// <para>- 要使用[搭建工具](https://open.feishu.cn/cardkit?from=open_docs)构建的卡片模板，参考下文传入参数。</para>
    /// <para>**注意**：</para>
    /// <para>- 更新的卡片消息最大不能超过 30 KB。若消息中包含大量样式标签，会使实际消息体长度大于你输入的请求体长度。</para>
    /// <para>- 以下示例值未转义，使用时请注意将其转为 JSON 序列化后的字符串。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{"elements":[{"tag":"div","text":{"content":"This is the plain text","tag":"plain_text"}}],"header":{"template":"blue","title":{"content":"This is the title","tag":"plain_text"}}}</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = string.Empty;
}
