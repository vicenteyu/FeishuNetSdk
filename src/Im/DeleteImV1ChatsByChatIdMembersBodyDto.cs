using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人移出群聊 请求体
/// <para>将用户或机器人移出群聊。</para>
/// <para>接口ID：6946222929790468124</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fdelete</para>
/// </summary>
public record DeleteImV1ChatsByChatIdMembersBodyDto
{
    /// <summary>
    /// <para>成员列表。移除群内的用户时推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)；移除群内的机器人时需填写应用的App ID，请参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：</para>
    /// <para>- 成员列表不可为空</para>
    /// <para>- 列表中填写的成员ID类型应与 ==member_id_type== 参数中选择的类型相对应</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// </summary>
    [JsonProperty("id_list")]
    public string[]? IdList { get; set; }
}
