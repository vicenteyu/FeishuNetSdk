using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 发送应用内加急 请求体
/// <para>对指定消息进行应用内加急。</para>
/// <para>接口ID：6948245234036621340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/buzz-messages/urgent_app</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fmessage%2furgent_app</para>
/// </summary>
public record PatchImV1MessagesByMessageIdUrgentAppBodyDto
{
    /// <summary>
    /// <para>目标用户的ID，列表不可为空；推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>**注意**：</para>
    /// <para>请确保所填的用户ID正确，并且用户在加急消息所在的群组中</para>
    /// <para>必填：是</para>
    /// <para>示例值：["ou_6yf8af6bgb9100449565764t3382b168"]</para>
    /// </summary>
    [JsonProperty("user_id_list")]
    public string[] UserIdList { get; set; } = Array.Empty<string>();
}
