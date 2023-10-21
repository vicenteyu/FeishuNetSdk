using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 发送短信加急 响应体
/// <para>对指定消息进行应用内加急与短信加急。</para>
/// <para>接口ID：6948245234036637724</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_sms</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_sms</para>
/// </summary>
public record PatchImV1MessagesByMessageIdUrgentSmsResponseDto
{
    /// <summary>
    /// <para>无效的用户ID</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("invalid_user_id_list")]
    public string[] InvalidUserIdList { get; set; } = Array.Empty<string>();
}
