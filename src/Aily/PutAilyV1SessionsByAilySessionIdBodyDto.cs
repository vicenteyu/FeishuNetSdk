// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutAilyV1SessionsByAilySessionIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 更新会话 请求体
/// <para>该 API 用于更新与某个飞书 Aily 应用的一次会话（Session）的信息。</para>
/// <para>接口ID：7358047310868234244</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fupdate</para>
/// </summary>
public record PutAilyV1SessionsByAilySessionIdBodyDto
{
    /// <summary>
    /// <para>可自行构造的 Context [上下文变量](https://aily.feishu.cn/hc/1u7kleqg/en70bqqj#6a446d5e)；在 Workflow 技能中可消费这部分全局变量</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("channel_context")]
    public string? ChannelContext { get; set; }

    /// <summary>
    /// <para>会话的自定义变量内容，变量数据保存在服务端 Session 中，可在 `GetSession` 时原样返回，无需在 API 调用侧存储</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}
