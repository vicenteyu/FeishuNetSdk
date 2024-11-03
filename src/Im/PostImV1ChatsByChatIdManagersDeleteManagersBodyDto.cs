// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdManagersDeleteManagersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除群管理员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除群管理员 请求体
/// <para>指定群组，删除群组内指定的管理员，包括用户类型的管理员和机器人类型的管理员。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>仅群组内的群主可以删除群管理员。</para>
/// <para>接口ID：6995085510524715009</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/delete_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fdelete_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersDeleteManagersBodyDto
{
    /// <summary>
    /// <para>要删除的管理员 ID，ID 类型与查询参数 member_id_type 取值一致。</para>
    /// <para>- 如果是用户（member_id_type 取值为 user_id/open_id/union_id），推荐使用用户的 open_id，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>- 如果是机器人（member_id_type 取值为 app_id），请参考[如何获取应用的 App ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：每次请求最多指定 50 个用户或者 5 个机器人</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("manager_ids")]
    public string[]? ManagerIds { get; set; }
}
