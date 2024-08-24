// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1PinsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Pin 消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// Pin 消息 响应体
/// <para>Pin 一条指定的消息。Pin 消息的效果可参见[Pin 消息概述](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/pin/pin-overview)。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- Pin 消息时，机器人必须在消息所属的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 当前操作者不可见的消息无法 Pin。</para>
/// <para>- 对同一条消息的 Pin 操作不能超过 5 QPS。</para>
/// <para>## 注意事项</para>
/// <para>如果消息已经被 Pin，则该接口会返回该 Pin 的操作信息。</para>
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
public record PostImV1PinsResponseDto
{
    /// <summary>
    /// <para>Pin 的操作信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pin")]
    public PostImV1PinsResponseDtoPin? Pin { get; set; }

    /// <summary>
    /// <para>Pin 的操作信息</para>
    /// </summary>
    public record PostImV1PinsResponseDtoPin
    {
        /// <summary>
        /// <para>Pin 的消息 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Pin 消息所在的群聊 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>Pin 的操作人 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>Pin 的操作人 ID 类型。可能值有：</para>
        /// <para>- open_id：表示操作人为用户，此时 `operator_id` 返回值为用户的 open_id。</para>
        /// <para>- app_id：表示操作人为应用，此时 `operator_id` 返回值为应用的 app_id。</para>
        /// <para>必填：否</para>
        /// <para>示例值：open_id</para>
        /// </summary>
        [JsonPropertyName("operator_id_type")]
        public string? OperatorIdType { get; set; }

        /// <summary>
        /// <para>Pin 的创建时间（毫秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1615380573211</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }
}
