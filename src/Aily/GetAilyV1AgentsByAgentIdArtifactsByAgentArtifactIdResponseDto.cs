// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="GetAilyV1AgentsByAgentIdArtifactsByAgentArtifactIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>下载智能体产物 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 下载智能体产物 响应体
/// <para>根据产物 ID(agent_artifact_id)获取该产物的下载地址及基础信息(名称、URL),用于开发者拉取智能体在会话中生成的图片、文件、云文档等产物。</para>
/// <para>接口ID：7646811253679852723</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/agent-agent_artifact/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fagent-agent_artifact%2fget</para>
/// </summary>
public record GetAilyV1AgentsByAgentIdArtifactsByAgentArtifactIdResponseDto
{
    /// <summary>
    /// <para>产物</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("agent_artifact")]
    public AgentArtifactSuffix? AgentArtifact { get; set; }

    /// <summary>
    /// <para>产物</para>
    /// </summary>
    public record AgentArtifactSuffix
    {
        /// <summary>
        /// <para>产物id</para>
        /// <para>必填：是</para>
        /// <para>示例值：artifact_4k6m2dbmrjeqf</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("artifact_id")]
        public string ArtifactId { get; set; } = string.Empty;

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：cute_kitten.png</para>
        /// <para>最大长度：256</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>下载URL，24小时内有效</para>
        /// <para>必填：是</para>
        /// <para>示例值：https://.tos-cn-...volces.com/agent_runtime/artifact/.../dog2.png?X-Tos</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}
