// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PatchOkrV2IndicatorsByIndicatorIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新量化指标 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 更新量化指标 请求体
/// <para>更新现有量化指标的配置和数值，包括计算方式、状态、当前值、目标值和单位设置。</para>
/// <para>接口ID：7644764969658207180</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-indicator/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-indicator%2fpatch</para>
/// </summary>
public record PatchOkrV2IndicatorsByIndicatorIdBodyDto
{
    /// <summary>
    /// <para>指标的当前值的计算方式，目标仅支持 0、1；关键结果仅支持 0、2</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：手动更新</item>
    /// <item>1：基于关键结果进度自动更新</item>
    /// <item>2：基于拆解的关键结果进度更新</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("current_value_calculate_type")]
    public int? CurrentValueCalculateType { get; set; }

    /// <summary>
    /// <para>指标的状态的计算方式，目标仅支持 0、1、2；关键结果仅支持 0、1</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>0：手动更新</item>
    /// <item>1：基于进度和当前时间自动更新</item>
    /// <item>2：基于风险最高的关键结果状态更新</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status_calculate_type")]
    public int? StatusCalculateType { get; set; }

    /// <summary>
    /// <para>指标的起始值，不支持目标修改</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最大值：99999999999</para>
    /// <para>最小值：-99999999999</para>
    /// </summary>
    [JsonPropertyName("start_value")]
    public double? StartValue { get; set; }

    /// <summary>
    /// <para>指标的目标值，不支持目标修改；不支持有承接记录的关键结果修改</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最大值：99999999999</para>
    /// <para>最小值：-99999999999</para>
    /// </summary>
    [JsonPropertyName("target_value")]
    public double? TargetValue { get; set; }

    /// <summary>
    /// <para>指标的当前值，不支持基于关键结果进度自动更新的目标修改；不支持基于拆解记录自动更新的关键结果修改</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>最大值：99999999999</para>
    /// <para>最小值：-99999999999</para>
    /// </summary>
    [JsonPropertyName("current_value")]
    public double? CurrentValue { get; set; }

    /// <summary>
    /// <para>指标的单位，不支持目标修改；不支持有承接记录的关键结果修改</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("unit")]
    public IndicatorUnit? Unit { get; set; }

    /// <summary>
    /// <para>指标的单位，不支持目标修改；不支持有承接记录的关键结果修改</para>
    /// </summary>
    public record IndicatorUnit
    {
        /// <summary>
        /// <para>指标的单位类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：公共</item>
        /// <item>1：自定义</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("unit_type")]
        public int UnitType { get; set; }

        /// <summary>
        /// <para>指标单位的值。如果是自定义，字符长度不超过 5；如果单元类型是「公共」，单位值为以下枚举值 百分比：PERCENT；无单位：NONE；元：YUAN；美元：DOLLAR</para>
        /// <para>必填：是</para>
        /// <para>示例值：PERCENT</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("unit_value")]
        public string UnitValue { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>指标的状态，只支持指标的状态的计算方式为手动更新时修改</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>可选值：<list type="bullet">
    /// <item>-1：未定义</item>
    /// <item>0：正常</item>
    /// <item>1：有风险</item>
    /// <item>2：已延期</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("indicator_status")]
    public int? IndicatorStatus { get; set; }
}
