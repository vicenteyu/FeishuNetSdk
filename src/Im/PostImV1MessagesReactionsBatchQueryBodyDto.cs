// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-11
//
// Last Modified By : yxr
// Last Modified On : 2026-05-01
// ************************************************************************
// <copyright file="PostImV1MessagesReactionsBatchQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量获取消息表情回复 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 批量获取消息表情回复 请求体
/// <para>支持批量分页的获取消息上的表情详情、支持批量获取消息上表情的统计</para>
/// <para>## 前提条件</para>
/// <para>- 应用身份调用接口需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人或者用户，需要在待查询的消息所属的会话内。</para>
/// <para>## 使用限制</para>
/// <para>已被撤回的消息、消息不可见等情况无法获取表情回复列表。</para>
/// <para>接口ID：7626724000588991682</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage-reaction%2fbatch_query</para>
/// </summary>
public record PostImV1MessagesReactionsBatchQueryBodyDto
{
    /// <summary>
    /// <para>要查询的消息</para>
    /// <para>必填：是</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("queries")]
    public MessageQuery[] Queries { get; set; } = [];

    /// <summary>
    /// <para>要查询的消息</para>
    /// </summary>
    public record MessageQuery
    {
        /// <summary>
        /// <para>消息ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：om_8964d1b4*********2b31383276113</para>
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果。</para>
        /// <para>必填：否</para>
        /// <para>示例值：YhljsPiGfUgnVAg9urvRFd-BvSqRL20</para>
        /// </summary>
        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    /// <summary>
    /// <para>每个消息最多返回多少个表情</para>
    /// <para>**默认值：**10</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
    /// <para>最大值：10</para>
    /// <para>最小值：1</para>
    /// </summary>
    [JsonPropertyName("page_size_per_message")]
    public int? PageSizePerMessage { get; set; }

    /// <summary>
    /// <para>待查询的表情类型，支持的枚举值参考[表情文案说明](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message-reaction/emojis-introduce)中的 emoji_type 值。</para>
    /// <para>**注意**：该参数为可选参数，不传入该参数时将查询消息内所有的表情回复。</para>
    /// <para>必填：否</para>
    /// <para>示例值：LAUGH</para>
    /// </summary>
    [JsonPropertyName("reaction_type")]
    public string? ReactionType { get; set; }
}
