// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-06-06
//
// Last Modified By : yxr
// Last Modified On : 2026-06-06
// ************************************************************************
// <copyright file="GetOkrV2CyclesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取用户 OKR 周期列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取用户 OKR 周期列表 响应体
/// <para>获取指定用户的 OKR 周期列表，包含周期状态、时间范围和分数等信息。</para>
/// <para>接口ID：7644863390543989724</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/okr-v2/okr-cycle/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fokr-v2%2fokr-cycle%2flist</para>
/// </summary>
public record GetOkrV2CyclesResponseDto : IPageableResponse<GetOkrV2CyclesResponseDto.Cycle>
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>用户周期列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Cycle[]? Items { get; set; }

    /// <summary>
    /// <para>用户周期列表</para>
    /// </summary>
    public record Cycle
    {
        /// <summary>
        /// <para>用户周期 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398471</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户周期的创建时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户周期的更新时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>租户周期 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：7342342398472398472</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("tenant_cycle_id")]
        public string TenantCycleId { get; set; } = string.Empty;

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
        /// <para>周期的开始时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>周期的结束时间，毫秒级时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1760604634563</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户周期状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：默认</item>
        /// <item>1：正常</item>
        /// <item>2：失效</item>
        /// <item>3：隐藏</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("cycle_status")]
        public int? CycleStatus { get; set; }

        /// <summary>
        /// <para>用户周期的分数：[0,1]，支持一位小数</para>
        /// <para>必填：否</para>
        /// <para>示例值：0.5</para>
        /// <para>最大值：1</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("score")]
        public double? Score { get; set; }
    }
}
