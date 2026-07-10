// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="PostImV1MessageCotResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建COT 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 创建COT 响应体
/// <para>调用该接口支持创建一条COT消息，用于与Agent交互时展示Agent的思考过程。</para>
/// <para>接口ID：7657479549125069790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fcreate</para>
/// </summary>
public record PostImV1MessageCotResponseDto
{
    /// <summary>
    /// <para>思考过程唯一ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7655611992547478740</para>
    /// </summary>
    [JsonPropertyName("cot_id")]
    public string? CotId { get; set; }

    /// <summary>
    /// <para>消息ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：om_xx</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }
}
