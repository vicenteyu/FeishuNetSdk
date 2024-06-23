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
/// <para>发送批量消息请求后，可以通过该接口查询批量消息推送的总人数和阅读人数。</para>
/// <para>接口ID：7021850211959275548</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/batch_message/read_user</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fbatch_message%2fread_user</para>
/// </summary>
public record GetImV1BatchMessagesByBatchMessageIdReadUserResponseDto
{
    /// <summary>
    /// <para>批量发送消息的用户阅读情况</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("read_user")]
    public BatchMessageReadUser? ReadUser { get; set; }

    /// <summary>
    /// <para>批量发送消息的用户阅读情况</para>
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
