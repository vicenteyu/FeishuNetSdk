// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetOkrV1PeriodsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取 OKR 周期列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Okr;
/// <summary>
/// 获取 OKR 周期列表 响应体
/// <para>获取 OKR 周期列表。</para>
/// <para>接口ID：6961663213280706561</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/period/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fperiod%2flist</para>
/// </summary>
public record GetOkrV1PeriodsResponseDto : IPageableResponse<GetOkrV1PeriodsResponseDto.Period>
{
    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：asdasdasd</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>数据项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Period[]? Items { get; set; }

    /// <summary>
    /// <para>数据项</para>
    /// </summary>
    public record Period
    {
        /// <summary>
        /// <para>id</para>
        /// <para>必填：否</para>
        /// <para>示例值：635782378412311</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>中文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：中文周期</para>
        /// </summary>
        [JsonPropertyName("zh_name")]
        public string? ZhName { get; set; }

        /// <summary>
        /// <para>英文名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：english period</para>
        /// </summary>
        [JsonPropertyName("en_name")]
        public string? EnName { get; set; }

        /// <summary>
        /// <para>启用状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：正常状态</item>
        /// <item>1：暂不处理</item>
        /// <item>2：标记失效</item>
        /// <item>3：隐藏周期</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// <para>周期开始时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686740948123</para>
        /// </summary>
        [JsonPropertyName("period_start_time")]
        public string? PeriodStartTime { get; set; }

        /// <summary>
        /// <para>周期结束时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1686740948123</para>
        /// </summary>
        [JsonPropertyName("period_end_time")]
        public string? PeriodEndTime { get; set; }
    }
}
