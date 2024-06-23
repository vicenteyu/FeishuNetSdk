// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteImV2AppFeedCardBatchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除应用消息流卡片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除应用消息流卡片 请求体
/// <para>该接口用于删除应用消息流卡片</para>
/// <para>接口ID：7302258202712490012</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/app_feed_card-batch/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card-batch%2fdelete</para>
/// </summary>
public record DeleteImV2AppFeedCardBatchBodyDto
{
    /// <summary>
    /// <para>应用消息卡片</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("feed_cards")]
    public UserOpenAppFeedCardDeleter[]? FeedCards { get; set; }

    /// <summary>
    /// <para>应用消息卡片</para>
    /// </summary>
    public record UserOpenAppFeedCardDeleter
    {
        /// <summary>
        /// <para>业务 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：ed381d34-49ac-4876-8d9e-23447acb587e</para>
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
    }
}
