// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-03-27
//
// Last Modified By : yxr
// Last Modified On : 2026-03-27
// ************************************************************************
// <copyright file="GetMinutesV1MinutesByMinuteTokenArtifactsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取妙记AI产物 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Minutes;
/// <summary>
/// 获取妙记AI产物 响应体
/// <para>通过妙记唯一标识minute_token获取AI产物</para>
/// <para>接口ID：7621494177948142790</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/minutes-v1/minute/artifacts</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fminutes-v1%2fminute%2fartifacts</para>
/// </summary>
public record GetMinutesV1MinutesByMinuteTokenArtifactsResponseDto
{
    /// <summary>
    /// <para>妙记总结</para>
    /// <para>必填：否</para>
    /// <para>示例值：妙记总结</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// <para>妙记章节</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minute_chapters")]
    public MinuteChapter[]? MinuteChapters { get; set; }

    /// <summary>
    /// <para>妙记章节</para>
    /// </summary>
    public record MinuteChapter
    {
        /// <summary>
        /// <para>章节标题，用于区分纪要内不同的讨论模块，需简洁明确概括章节核心内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：项目进度回顾与风险评估</para>
        /// <para>最大长度：1000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>章节对应的讨论内容开始时间戳，单位为毫秒，用于定位会议录像或录音的对应片段。需与stop_ms配合使用，且数值需小于stop_ms。</para>
        /// <para>必填：否</para>
        /// <para>示例值：31000</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("start_ms")]
        public string? StartMs { get; set; }

        /// <summary>
        /// <para>章节对应的讨论内容结束时间戳，单位为毫秒，用于定位会议录像或录音的对应片段。需与start_ms配合使用，且数值需大于start_ms。</para>
        /// <para>必填：否</para>
        /// <para>示例值：33000</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("stop_ms")]
        public string? StopMs { get; set; }

        /// <summary>
        /// <para>章节的核心讨论内容摘要，需准确提炼该章节的决策结果、行动项、待跟进事项等关键信息。支持富文本格式，最大长度限制为10000字符。</para>
        /// <para>必填：否</para>
        /// <para>示例值：1. 确认Q3项目交付节点为9月30日，延迟交付将触发合同违约条款； 2. 指派张三负责协调供应商资源，需在7月15日前提交资源保障方案； 3. 风险预警：核心组件供应链可能存在断供风险，需启动备选供应商评估流程。</para>
        /// <para>最大长度：100000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("summary_content")]
        public string? SummaryContent { get; set; }
    }

    /// <summary>
    /// <para>妙记待办</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("minute_todos")]
    public MinuteTodo[]? MinuteTodos { get; set; }

    /// <summary>
    /// <para>妙记待办</para>
    /// </summary>
    public record MinuteTodo
    {
        /// <summary>
        /// <para>待办内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：提交资源保障方案</para>
        /// <para>最大长度：10000</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// <para>负责人</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("assignees")]
        public string[]? Assignees { get; set; }
    }
}
