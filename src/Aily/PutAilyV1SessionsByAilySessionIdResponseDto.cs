// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutAilyV1SessionsByAilySessionIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新会话 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 更新会话 响应体
/// <para>该 API 用于更新与某个飞书智能伙伴应用的一次会话（Session）的信息。</para>
/// <para>接口ID：7358047310868234244</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session%2fupdate</para>
/// </summary>
public record PutAilyV1SessionsByAilySessionIdResponseDto
{
    /// <summary>
    /// <para>会话信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("session")]
    public AilySession? Session { get; set; }

    /// <summary>
    /// <para>会话信息</para>
    /// </summary>
    public record AilySession
    {
        /// <summary>
        /// <para>会话 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：session_4dfunz7sp1g8m</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：9</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话的创建时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话的上次更新时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("modified_at")]
        public string ModifiedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话的创建人（Aily UserID）</para>
        /// <para>必填：是</para>
        /// <para>示例值：1794840334557292</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; } = string.Empty;

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
}
