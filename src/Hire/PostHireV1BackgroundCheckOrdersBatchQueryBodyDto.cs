// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-08-22
//
// Last Modified By : yxr
// Last Modified On : 2025-08-22
// ************************************************************************
// <copyright file="PostHireV1BackgroundCheckOrdersBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询背调信息列表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 查询背调信息列表 请求体
/// <para>可根据背调 ID 列表或投递 ID 等过滤条件查询背调订单信息。</para>
/// <para>接口ID：7413697955198107652</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/delivery-process-management/background_check_order/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fbackground_check_order%2fbatch_query</para>
/// </summary>
public record PostHireV1BackgroundCheckOrdersBatchQueryBodyDto
{
    /// <summary>
    /// <para>背调订单 ID 列表，可通过本接口其他查询条件查询结果所得，当传递此值，以此值为准，其余查询字段失效</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// </summary>
    [JsonPropertyName("background_check_order_id_list")]
    public string[]? BackgroundCheckOrderIdList { get; set; }

    /// <summary>
    /// <para>最早更新时间，毫秒时间戳。需小于等于begin_end_time</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500000000</para>
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// <para>最晚更新时间，毫秒时间戳。需大于等于update_start_time</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }

    /// <summary>
    /// <para>最早创建时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("begin_start_time")]
    public string? BeginStartTime { get; set; }

    /// <summary>
    /// <para>最晚创建时间，毫秒时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1618500278663</para>
    /// </summary>
    [JsonPropertyName("begin_end_time")]
    public string? BeginEndTime { get; set; }

    /// <summary>
    /// <para>投递 ID，可通过[获取投递列表](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/list)接口获取</para>
    /// <para>必填：否</para>
    /// <para>示例值：7398493486516799788</para>
    /// </summary>
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; set; }

    /// <summary>
    /// <para>订单状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：2</para>
    /// <para>可选值：<list type="bullet">
    /// <item>2：已安排</item>
    /// <item>3：已完成</item>
    /// <item>4：已终止</item>
    /// <item>5：审批中</item>
    /// <item>6：审批已撤回</item>
    /// <item>8：审批通过</item>
    /// <item>9：审批未通过</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("order_status")]
    public string? OrderStatus { get; set; }
}
