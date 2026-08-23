// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-08-19
//
// Last Modified By : yxr
// Last Modified On : 2026-08-19
// ************************************************************************
// <copyright file="PostVcV1BotsMessageResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>发送会中消息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Vc;
/// <summary>
/// 发送会中消息 响应体
/// <para>向指定的视频会议发送会中消息。</para>
/// <para>接口ID：7672664994766982391</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/bot/message</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2fbot%2fmessage</para>
/// </summary>
public record PostVcV1BotsMessageResponseDto
{
    /// <summary>
    /// <para>本次实际使用的幂等去重 ID。若请求未传 uuid，则返回服务端生成的 uuid。</para>
    /// <para>必填：否</para>
    /// <para>示例值：a1b2c3d4-5678-90ef-ghij-klmnopqrstuv</para>
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}
