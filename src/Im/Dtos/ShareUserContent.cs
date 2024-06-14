namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 分享个人名片消息
    /// </summary>
    /// <param name="UserId">个人名片Id</param>
    public record ShareUserContent([property: JsonPropertyName("user_id")] string UserId = "") : MessageContent("share_user");

}
