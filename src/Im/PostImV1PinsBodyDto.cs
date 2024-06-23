// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1PinsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>Pin 消息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// Pin 消息 请求体
/// <para>Pin 一条指定的消息。</para>
/// <para>接口ID：7138313270488858626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/pin/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fpin%2fcreate</para>
/// </summary>
public record PostImV1PinsBodyDto
{
    /// <summary>
    /// <para>待Pin的消息ID，详情参见[消息ID说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/intro#ac79c1c2)</para>
    /// <para>必填：是</para>
    /// <para>示例值：om_dc13264520392913993dd051dba21dcf</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;
}
