// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="OkrSuffix.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>OKR Block</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>OKR Block</para>
/// </summary>
public abstract record OkrSuffix
{
    /// <summary>
    /// <para>是否设置过私密权限</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    /// <summary>
    /// <para>位置编号</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("position")]
    public int? Position { get; set; }

    /// <summary>
    /// <para>打分信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("score")]
    public int? Score { get; set; }

    /// <summary>
    /// <para>是否可见</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// <para>默认值：true</para>
    /// </summary>
    [JsonPropertyName("visible")]
    public bool? Visible { get; set; }

    /// <summary>
    /// <para>权重</para>
    /// <para>必填：否</para>
    /// <para>示例值：0.5</para>
    /// </summary>
    [JsonPropertyName("weight")]
    public float? Weight { get; set; }

    /// <summary>
    /// <para>进展信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("progress_rate")]
    public OkrProgressRate? ProgressRate { get; set; }

    /// <summary>
    /// <para>文本内容</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("content")]
    public BlockText? Content { get; set; }
}

/// <summary>
/// <para>OKR Objective Block</para>
/// </summary>
public record BlockOkrObjective : OkrSuffix
{
    /// <summary>
    /// <para>Objective ID</para>
    /// <para>必填：否</para>
    /// <para>示例值："7109022409227026460"</para>
    /// </summary>
    [JsonPropertyName("objective_id")]
    public string? ObjectiveId { get; set; }
}

/// <summary>
/// <para>OKR Key Result</para>
/// </summary>
public record BlockOkrKeyResult : OkrSuffix
{
    /// <summary>
    /// <para>Key Result 的 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值："7109022573011894300"</para>
    /// </summary>
    [JsonPropertyName("kr_id")]
    public string? KrId { get; set; }
}

/// <summary>
/// <para>进展信息</para>
/// </summary>
public record OkrProgressRate
{
    /// <summary>
    /// <para>状态模式</para>
    /// <para>必填：否</para>
    /// <para>示例值："simple"</para>
    /// <para>可选值：<list type="bullet">
    /// <item>simple：简单模式</item>
    /// <item>advanced：高级模式</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// <para>当前进度</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("current")]
    public float? Current { get; set; }

    /// <summary>
    /// <para>当前进度百分比，simple mode 下使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：100</para>
    /// </summary>
    [JsonPropertyName("percent")]
    public float? Percent { get; set; }

    /// <summary>
    /// <para>进展状态</para>
    /// <para>必填：否</para>
    /// <para>示例值："normal"</para>
    /// <para>可选值：<list type="bullet">
    /// <item>unset：未设置</item>
    /// <item>normal：正常</item>
    /// <item>risk：有风险</item>
    /// <item>extended：已延期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("progress_status")]
    public string? ProgressStatus { get; set; }

    /// <summary>
    /// <para>进度起始值，advanced模式使用</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonPropertyName("start")]
    public float? Start { get; set; }

    /// <summary>
    /// <para>状态类型</para>
    /// <para>必填：否</para>
    /// <para>示例值："default"</para>
    /// <para>可选值：<list type="bullet">
    /// <item>default：风险最高的Key Result状态</item>
    /// <item>custom：自定义</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status_type")]
    public string? StatusType { get; set; }

    /// <summary>
    /// <para>进度目标值，advanced模式使用</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target")]
    public float? Target { get; set; }
}