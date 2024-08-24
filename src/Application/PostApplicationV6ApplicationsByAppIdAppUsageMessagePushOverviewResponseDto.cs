// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-24
//
// Last Modified By : yxr
// Last Modified On : 2024-07-24
// ************************************************************************
// <copyright file="PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取消息推送概览 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Application;
/// <summary>
/// 获取消息推送概览 响应体
/// <para>目标：查看应用在某一天/某一周/某一个月的机器人消息推送数据，可以根据部门做筛选</para>
/// <para>接口ID：7036626399368953884</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/message_push_overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2fmessage_push_overview</para>
/// </summary>
public record PostApplicationV6ApplicationsByAppIdAppUsageMessagePushOverviewResponseDto
{
    /// <summary>
    /// <para>消息推送情况，指标值包括：send_msg_count：消息推送数、send_user_count：消息触达人数、read_in_1h_count：消息1h阅读量、read_in_12h_count：消息12h阅读量</para>
    /// <para>**注意**：将一条消息推送至群聊，该消息的推送数等于群聊人数。例如群聊内有 5 个人：</para>
    /// <para>- 如果将 1 条消息推送至群聊后，消息推送数（send_msg_count）为 5、消息触达人数（send_user_count）为 5。</para>
    /// <para>- 如果将 2 条消息推送至群聊后，消息推送数（send_msg_count）为 10、消息触达人数（send_user_count）为 5。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：10</para>
    /// </summary>
    [JsonPropertyName("items")]
    public ApplicationAppUsage[]? Items { get; set; }

    /// <summary>
    /// <para>消息推送情况，指标值包括：send_msg_count：消息推送数、send_user_count：消息触达人数、read_in_1h_count：消息1h阅读量、read_in_12h_count：消息12h阅读量</para>
    /// <para>**注意**：将一条消息推送至群聊，该消息的推送数等于群聊人数。例如群聊内有 5 个人：</para>
    /// <para>- 如果将 1 条消息推送至群聊后，消息推送数（send_msg_count）为 5、消息触达人数（send_user_count）为 5。</para>
    /// <para>- 如果将 2 条消息推送至群聊后，消息推送数（send_msg_count）为 10、消息触达人数（send_user_count）为 5。</para>
    /// </summary>
    public record ApplicationAppUsage
    {
        /// <summary>
        /// <para>指标名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：pv</para>
        /// </summary>
        [JsonPropertyName("metric_name")]
        public string MetricName { get; set; } = string.Empty;

        /// <summary>
        /// <para>指标值</para>
        /// <para>必填：是</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("metric_value")]
        public int MetricValue { get; set; }
    }
}
