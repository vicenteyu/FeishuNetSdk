// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteImV2AppFeedCardBatchResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除应用消息流卡片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除应用消息流卡片 响应体
/// <para>该接口用于删除应用消息流卡片</para>
/// <para>接口ID：7302258202712490012</para>
/// <para>文档地址：https://open.feishu.cn/document/im-v2/app_feed_card/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card-batch%2fdelete</para>
/// </summary>
public record DeleteImV2AppFeedCardBatchResponseDto
{
    /// <summary>
    /// <para>失败的卡片</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("failed_cards")]
    public OpenFailedUserAppFeedCardItem[]? FailedCards { get; set; }

    /// <summary>
    /// <para>失败的卡片</para>
    /// </summary>
    public record OpenFailedUserAppFeedCardItem
    {
        /// <summary>
        /// <para>业务 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：bdf22389-87ec-4890-9eb6-78a7efaeecbb</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; } = string.Empty;

        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_88553eda9014c201e6969b478895c223</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>原因</para>
        /// <para>必填：否</para>
        /// <para>示例值：NO_PERMISSION</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：未知</item>
        /// <item>1：无权限</item>
        /// <item>2：未创建</item>
        /// <item>3：频率限制</item>
        /// <item>4：重复</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
    }
}
