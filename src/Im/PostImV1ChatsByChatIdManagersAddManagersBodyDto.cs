using Newtonsoft.Json;
namespace FeishuNetSdk.Im;
/// <summary>
/// 指定群管理员 请求体
/// <para>将用户或机器人指定为群管理员。</para>
/// <para>接口ID：6995085510524698625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/add_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fadd_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersAddManagersBodyDto
{
    /// <summary>
    /// <para>要增加的 manager_id。指定用户为管理员时推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)；指定机器人为管理员时需填写应用的App ID，请参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：</para>
    /// <para>- 对于普通群，最多指定 10 个管理员</para>
    /// <para>- 对于超大群，最多指定 20 个管理员</para>
    /// <para>- 每次请求最多指定 50 个用户或者 5 个机器人</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonProperty("manager_ids")]
    public string[]? ManagerIds { get; set; }
}
