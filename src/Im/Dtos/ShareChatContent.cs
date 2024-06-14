namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享群名片消息
    /// </summary>
    /// <param name="ShareChatId">群名片Id</param>
    public record ShareChatContent([property: JsonPropertyName("share_chat_id")] string ShareChatId = "") : MessageContent("share_chat");

}
