// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-25
//
// Last Modified By : yxr
// Last Modified On : 2024-10-25
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdSkillsBySkillIdStartBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>调用技能 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 调用技能 请求体
/// <para>该 API 用于调用某个 Aily 应用的特定技能，支持指定技能入参；并同步返回技能执行的结果。</para>
/// <para>&gt; **技能 API** 能显著简化业务系统的集成工作（单轮 API 调用）。技能 API 提供更贴合系统间服务调用的参数传递模式（JSON 入参 / 出参），且无需通过文本消息对话的方式调用 AI 能力。</para>
/// <para>&lt;div style="text-align: center;"&gt;</para>
/// <para>接口ID：7429225800963031042</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/app-skill/start</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fstart</para>
/// </summary>
public record PostAilyV1AppsByAppIdSkillsBySkillIdStartBodyDto
{
    /// <summary>
    /// <para>技能的全局变量</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("global_variable")]
    public SkillGlobalVariable? GlobalVariable { get; set; }

    /// <summary>
    /// <para>技能的全局变量</para>
    /// </summary>
    public record SkillGlobalVariable
    {
        /// <summary>
        /// <para>触发技能的消息文本；即用户在飞书机器人等渠道**对话输入的内容**</para>
        /// <para>必填：否</para>
        /// <para>示例值：你好</para>
        /// <para>最大长度：40960</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// <para>触发技能的文件信息（如 OCR 节点等所需消费的图片文件）</para>
        /// <para>&gt; 如技能不需要文件，`files` 参数传空即可</para>
        /// <para>必填：否</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("files")]
        public string[]? Files { get; set; }

        /// <summary>
        /// <para>渠道信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("channel")]
        public SkillGlobalVariableChannel? Channel { get; set; }

        /// <summary>
        /// <para>渠道信息</para>
        /// </summary>
        public record SkillGlobalVariableChannel
        {
            /// <summary>
            /// <para>自定义传入的变量；可在 Workflow 技能全局变量中消费</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"custom_key": "custom_value"}</para>
            /// <para>最大长度：255</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("variables")]
            public string? Variables { get; set; }
        }
    }

    /// <summary>
    /// <para>技能的自定义变量</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"custom_string\":\"my string\",\"custom_integer\":22}</para>
    /// <para>最大长度：40960</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }
}
