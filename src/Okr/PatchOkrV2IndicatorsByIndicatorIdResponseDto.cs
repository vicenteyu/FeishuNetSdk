// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="PatchOkrV2IndicatorsByIndicatorIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新量化指标 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 更新量化指标 响应体
/// <para>更新现有量化指标的配置和数值，包括计算方式、状态、当前值、目标值和单位设置。</para>
/// <para>接口ID：7644764969658207180</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-indicator/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-indicator%2fpatch</para>
/// </summary>
public record PatchOkrV2IndicatorsByIndicatorIdResponseDto
{
    /// <summary>
    /// <para>指标</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("indicator")]
    public IndicatorSuffix? Indicator { get; set; }

    /// <summary>
    /// <para>指标</para>
    /// </summary>
    public record IndicatorSuffix
    {
        /// <summary>
        /// <para>指标的 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>所有者</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("owner")]
        public OwnerSuffix Owner { get; set; } = new();

        /// <summary>
        /// <para>所有者</para>
        /// </summary>
        public record OwnerSuffix
        {
            /// <summary>
            /// <para>所有者类型</para>
            /// <para>必填：是</para>
            /// <para>示例值：user</para>
            /// <para>可选值：<list type="bullet">
            /// <item>user：员工</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("owner_type")]
            public string OwnerType { get; set; } = string.Empty;

            /// <summary>
            /// <para>员工 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
            /// </summary>
            [JsonPropertyName("user_id")]
            public string? UserId { get; set; }
        }

        /// <summary>
        /// <para>指标所属的实体类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>2：目标</item>
        /// <item>3：关键结果</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("entity_type")]
        public int EntityType { get; set; }

        /// <summary>
        /// <para>指标所属的实体 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398473</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标的状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>-1：未定义</item>
        /// <item>0：正常</item>
        /// <item>1：有风险</item>
        /// <item>2：已延期</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("indicator_status")]
        public int IndicatorStatus { get; set; }

        /// <summary>
        /// <para>指标的状态的计算方式</para>
        /// <para>必填：是</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：手动更新</item>
        /// <item>1：基于进度和当前时间自动更新</item>
        /// <item>2：基于风险最高的关键结果状态更新</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status_calculate_type")]
        public int StatusCalculateType { get; set; }

        /// <summary>
        /// <para>指标的起始值</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：99999999999</para>
        /// <para>最小值：-99999999999</para>
        /// </summary>
        [JsonPropertyName("start_value")]
        public double? StartValue { get; set; }

        /// <summary>
        /// <para>指标的目标值</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：99999999999</para>
        /// <para>最小值：-99999999999</para>
        /// </summary>
        [JsonPropertyName("target_value")]
        public double? TargetValue { get; set; }

        /// <summary>
        /// <para>指标的当前值</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>最大值：99999999999</para>
        /// <para>最小值：-99999999999</para>
        /// </summary>
        [JsonPropertyName("current_value")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// <para>指标的当前值的计算方</para>
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
        /// <para>指标的单位</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("unit")]
        public IndicatorUnit? Unit { get; set; }

        /// <summary>
        /// <para>指标的单位</para>
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
    }
}
