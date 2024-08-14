// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1MessagesByMessageIdForwardBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>转发消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 转发消息 请求体
/// <para>调用该接口将一条指定的消息转发给用户、群聊或话题。</para>
/// <para>接口ID：7210967154035621891</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message/forward</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2fforward</para>
/// </summary>
public record PostImV1MessagesByMessageIdForwardBodyDto
{
    /// <summary>
    /// <para>消息接收者 ID，ID 类型与 `receive_id_type` 的值一致。</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_a0553eda9014c201e6969b478895c230</para>
    /// </summary>
    [JsonPropertyName("receive_id")]
    public string ReceiveId { get; set; } = string.Empty;
}
