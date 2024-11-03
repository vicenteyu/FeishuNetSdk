// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdManagersAddManagersBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>指定群管理员 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 指定群管理员 请求体
/// <para>指定群组，将群内指定的用户或者机器人设置为群管理员。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>仅群组内的群主可以指定群管理员。</para>
/// <para>接口ID：6995085510524698625</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-member/add_managers</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-managers%2fadd_managers</para>
/// </summary>
public record PostImV1ChatsByChatIdManagersAddManagersBodyDto
{
    /// <summary>
    /// <para>要设置为管理员的 ID，ID 类型与查询参数 member_id_type 取值一致。</para>
    /// <para>- 如果是用户（member_id_type 取值为 user_id/open_id/union_id），推荐使用用户的 open_id，获取方式可参考文档[如何获取 Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>- 如果是机器人（member_id_type 取值为 app_id），请参考[如何获取应用的 App ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-app-id)</para>
    /// <para>**注意**：</para>
    /// <para>- 对于普通群，最多可指定 10 个管理员。</para>
    /// <para>- 对于超大群，最多可指定 20 个管理员。</para>
    /// <para>- 每次请求最多可指定 50 个用户或者 5 个机器人。</para>
    /// <para>超大群和普通群的区别，参见[超大群与普通群有什么区别](https://www.feishu.cn/hc/zh-CN/articles/374791927841)。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["ou_9204a37300b3700d61effaa439f34295"]</para>
    /// <para>最大长度：50</para>
    /// </summary>
    [JsonPropertyName("manager_ids")]
    public string[]? ManagerIds { get; set; }
}
