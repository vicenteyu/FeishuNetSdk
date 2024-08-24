// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1BatchMessagesByBatchMessageIdReadUserResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询批量消息推送和阅读人数 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 查询批量消息推送和阅读人数 响应体
/// <para>[批量发送消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)后，可通过该接口查询消息推送的总人数以及消息已读人数。</para>
/// <para>## 前提条件</para>
/// <para>应用需要启用[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 注意事项</para>
/// <para>- 只能查询 30 天内，通过[批量发送消息](https://open.feishu.cn/document/ukTMukTMukTM/ucDO1EjL3gTNx4yN4UTM)接口发送的消息。</para>
/// <para>- 该接口返回的数据为查询时刻的快照数据。</para>
/// <para>接口ID：7021850211959275548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/read_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fread_user</para>
/// </summary>
public record GetImV1BatchMessagesByBatchMessageIdReadUserResponseDto
{
    /// <summary>
    /// <para>批量发送消息的推送与阅读情况。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("read_user")]
    public BatchMessageReadUser? ReadUser { get; set; }

    /// <summary>
    /// <para>批量发送消息的推送与阅读情况。</para>
    /// </summary>
    public record BatchMessageReadUser
    {
        /// <summary>
        /// <para>已读的人数</para>
        /// <para>必填：是</para>
        /// <para>示例值：10</para>
        /// </summary>
        [JsonPropertyName("read_count")]
        public string ReadCount { get; set; } = string.Empty;

        /// <summary>
        /// <para>推送的总人数</para>
        /// <para>必填：是</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; } = string.Empty;
    }
}
