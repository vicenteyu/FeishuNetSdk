// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-07-10
//
// Last Modified By : yxr
// Last Modified On : 2026-07-10
// ************************************************************************
// <copyright file="PutImV1MessageCotBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>COT事件写入 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// COT事件写入 请求体
/// <para>该接口用于持续写入COT(思考过程)事件，写入后客户端可以流式开始思考过程。</para>
/// <para>接口ID：7657479549125118942</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message_cot/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage_cot%2fupdate</para>
/// </summary>
public record PutImV1MessageCotBodyDto
{
    /// <summary>
    /// <para>AG2UI事件列表 [event构造参考](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage_cot%2Fcot-message-brief)</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("events")]
    public MessageCot[] Events { get; set; } = [];

    /// <summary>
    /// <para>AG2UI事件列表 [event构造参考](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage_cot%2Fcot-message-brief)</para>
    /// </summary>
    public record MessageCot
    {
        /// <summary>
        /// <para>agent AG2UI事件类型，eg. TOOL_CALL_START ，event_type的取值直接参考[COT消息概述](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage_cot%2Fcot-message-brief)</para>
        /// <para>必填：是</para>
        /// <para>示例值：TOOL_CALL_START</para>
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType { get; set; } = string.Empty;

        /// <summary>
        /// <para>agent AG2UI事件详情，json串，单条event最长不能超过4096字符</para>
        /// <para>必填：是</para>
        /// <para>示例值：{ "toolCallId": "tool-run-bash-1", "icon": "bash", "title": "搜索一下今天的天气", "toolCallName": "web_search", "parentMessageId": "msg-100" }</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// <para>agent传入的用于给客户端排序的事件时间戳,单位毫秒</para>
        /// <para>必填：是</para>
        /// <para>示例值：1777279818</para>
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>消息ID，注意这里的message_id直接使用创建接口返回的message_id，[创建COT接口](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage_cot%2Fcreate)</para>
    /// <para>必填：是</para>
    /// <para>示例值：om_x100b51bdee2ca964b4c213e6356a173</para>
    /// </summary>
    [JsonPropertyName("message_id")]
    public string MessageId { get; set; } = string.Empty;

    /// <summary>
    /// <para>思考过程ID，注意这里的cot_id直接使用创建接口返回的cot_id, [创建COT接口](https://lark-oapi-tools-console.bytedance.net/document-mod/index?fullPath=%2FuAjLw4CM%2FukTMukTMukTM%2Freference%2Fim-v1%2Fmessage_cot%2Fcreate)</para>
    /// <para>必填：是</para>
    /// <para>示例值：7633695736571366941</para>
    /// </summary>
    [JsonPropertyName("cot_id")]
    public string CotId { get; set; } = string.Empty;
}
