namespace FeishuNetSdk.Im;
/// <summary>
/// 删除群管理员 请求体
/// <para>删除指定的群管理员（用户或机器人）。</para>
/// <para>接口ID：6995085510524715009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fdelete_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersDeleteManagersBodyDto
{
    /// <summary>
    /// <para>要删除的 manager_id。移除用户类型的管理员时推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)；移除机器人类型的管理员时需填写应用的App ID，请参考[如何获取应用的 App ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：每次请求最多指定 50 个用户或者 5 个机器人</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("manager_ids")]
    public string[]? ManagerIds { get; set; }
}
