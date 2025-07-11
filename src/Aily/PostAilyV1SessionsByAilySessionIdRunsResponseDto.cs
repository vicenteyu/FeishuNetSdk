// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAilyV1SessionsByAilySessionIdRunsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建运行 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建运行 响应体
/// <para>该 API 用于在某个飞书 Aily 应用会话（Session）上创建一次运行（Run）。</para>
/// <para>## 实体概念说明</para>
/// <para>- **会话**（Session）：管理用户与 Aily 助手之间的交互会话；每次会话记录了用户发送给 Aily 助手的消息以及 Aily 助手的响应。</para>
/// <para>- **消息**（Message）：消息可以包含文本、表格、图片等多种类型的内容。</para>
/// <para>- **运行**（Run）：Aily 助手基于会话内消息进行意图判定、调用匹配的技能，并返回技能执行后的结果消息。</para>
/// <para>接口ID：7358047310868185092</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/aily_session-run/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdRunsResponseDto
{
    /// <summary>
    /// <para>运行信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("run")]
    public PostAilyV1SessionsByAilySessionIdRunsResponseDtoRun? Run { get; set; }

    /// <summary>
    /// <para>运行信息</para>
    /// </summary>
    public record PostAilyV1SessionsByAilySessionIdRunsResponseDtoRun
    {
        /// <summary>
        /// <para>运行 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：run_4dfrxvctjqzzj</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：5</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>运行的创建时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：spring_xxx__c</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：session_4dfunz7sp1g8m</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：9</para>
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：IN_PROGRESS</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// <para>结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("ended_at")]
        public string? EndedAt { get; set; }

        /// <summary>
        /// <para>失败时的错误信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("error")]
        public RunError? Error { get; set; }

        /// <summary>
        /// <para>失败时的错误信息</para>
        /// </summary>
        public record RunError
        {
            /// <summary>
            /// <para>错误码</para>
            /// <para>必填：是</para>
            /// <para>示例值：sp_ec_sm_900101</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>错误信息</para>
            /// <para>必填：是</para>
            /// <para>示例值：技能不存在或已删除</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("message")]
            public string Message { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>其他透传信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("metadata")]
        public string? Metadata { get; set; }
    }
}
