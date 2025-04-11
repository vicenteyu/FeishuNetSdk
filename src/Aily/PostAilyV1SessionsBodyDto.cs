// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAilyV1SessionsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建会话 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建会话 请求体
/// <para>该 API 用于创建与某个飞书智能伙伴应用的一次会话（Session）；当创建会话成功后，可以发送消息、创建运行。</para>
/// <para>## 实体概念说明</para>
/// <para>- **会话**（Session）：管理用户与 Aily 助手之间的交互会话；每次会话记录了用户发送给 Aily 助手的消息以及 Aily 助手的响应。</para>
/// <para>- **消息**（Message）：消息可以包含文本、表格、图片等多种类型的内容。</para>
/// <para>- **运行**（Run）：Aily 助手基于会话内消息进行意图判定、调用匹配的技能，并返回技能执行后的结果消息。</para>
/// <para>接口ID：7358047310868316164</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsBodyDto
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
