using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 将用户或机器人拉入群聊 请求体
/// <para>将用户或机器人拉入群聊。</para>
/// <para>接口ID：6946222931479609345</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-members%2fcreate</para>
/// </summary>
public record PostImV1ChatsByChatIdMembersBodyDto
{
    /// <summary>
    /// <para>成员ID列表。邀请用户进群时推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)；邀请机器人进群时需填写应用的App ID，请参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：</para>
    /// <para>- 成员列表不可为空</para>
    /// <para>- 每次请求最多拉50个用户或者5个机器人，并且群组最多容纳15个机器人</para>
    /// <para>- 列表中填写的成员ID类型应与 ==member_id_type== 参数中选择的类型相对应</para>
    /// <para>- 对于已认证企业的飞书的群人数默认上限：普通群5000人，会议群3000人，话题群5000人。若租户管理员配置了群人数上限，则群人数上限为该人数上限。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// </summary>
    [JsonProperty("id_list")]
    public string[]? IdList { get; set; }
}
