using Newtonsoft.Json;
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 发送仅特定人可见的消息卡片 请求体
/// <para>用于机器人在群会话中发送仅指定用户可见的消息卡片。卡片上将展示"仅对你可见"标识。</para>
/// <para>![image.png](//sf3-cn.feishucdn.com/obj/open-platform-opendoc/b0ec0ce45942463381457edc7b62e144_RXYCFtfUtb.png?lazyload=true&width=1592&height=486)</para>
/// <para>接口ID：6907569523177078785</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/send-message-cards-that-are-only-visible-to-certain-people</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuETOyYjLxkjM24SM5IjN</para>
/// </summary>
public record PostEphemeralV1SendBodyDto
{
    /// <summary>
    /// <para>发送临时消息的群ID可通过事件推送获取</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("chat_id")]
    public string ChatId { get; set; } = string.Empty;

    /// <summary>
    /// <para>指定发送临时消息卡片的用户，其他人将无法看到临时消息卡片；只需要填 open_id、email、user_id中的一个即可，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid) （服务端依次读取字段的顺序为 **open_id** > **user_id** > **email**）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("open_id")]
    public string? OpenId { get; set; }

    /// <summary>
    /// <para>指定发送临时消息卡片的用户，其他人将无法看到临时消息卡片；只需要填 open_id、email、user_id中的一个即可，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid) （服务端依次读取字段的顺序为 **open_id** > **user_id** > **email**）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("user_id")]
    public string? UserId { get; set; }

    /// <summary>
    /// <para>指定发送临时消息卡片的用户，其他人将无法看到临时消息卡片；只需要填 open_id、email、user_id中的一个即可，推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid) （服务端依次读取字段的顺序为 **open_id** > **user_id** > **email**）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("email")]
    public string? Email { get; set; }

    /// <summary>
    /// <para>消息的类型，此处固定填 "interactive"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("msg_type")]
    public string MsgType { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息卡片的描述内容，具体参考 [基础结构](https://open.feishu.cn/document/ukTMukTMukTM/uEjNwUjLxYDM14SM2ATN)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("card")]
    public object Card { get; set; } = new();
}
