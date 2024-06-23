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
/// <para>Pin 一条指定的消息。</para>
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
public record PostImV1PinsResponseDto
{
    /// <summary>
    /// <para>Pin的操作信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("pin")]
    public PostImV1PinsResponseDtoPin? Pin { get; set; }

    /// <summary>
    /// <para>Pin的操作信息</para>
    /// </summary>
    public record PostImV1PinsResponseDtoPin
    {
        /// <summary>
        /// <para>Pin的消息ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// <para>Pin消息所在的群聊ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：oc_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// <para>Pin的操作人ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_7d8a6e6df7621556ce0d21922b676706ccs</para>
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string? OperatorId { get; set; }

        /// <summary>
        /// <para>Pin的操作人ID类型。当Pin的操作人为用户时，为==open_id==；当Pin的操作人为机器人时，为==app_id==</para>
        /// <para>必填：否</para>
        /// <para>示例值：open_id</para>
        /// </summary>
        [JsonPropertyName("operator_id_type")]
        public string? OperatorIdType { get; set; }

        /// <summary>
        /// <para>Pin的创建时间（毫秒级时间戳）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1615380573211</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }
    }
}
