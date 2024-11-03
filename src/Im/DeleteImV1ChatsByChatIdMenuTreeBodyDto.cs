// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="DeleteImV1ChatsByChatIdMenuTreeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除群菜单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 删除群菜单 请求体
/// <para>删除指定群内的一级菜单。成功调用后接口会返回群组内最新的群菜单信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口仅支持群模式为 `group` 的群组，你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，在返回结果中查看 `chat_mode` 参数取值是否为 `group`。</para>
/// <para>- 仅支持删除群组内的一级菜单。</para>
/// <para>接口ID：7174746098262654980</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fdelete</para>
/// </summary>
public record DeleteImV1ChatsByChatIdMenuTreeBodyDto
{
    /// <summary>
    /// <para>一级菜单 ID。ID 可通过 [获取群菜单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-menu_tree/get) 接口获取。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7156553273518882844</para>
    /// </summary>
    [JsonPropertyName("chat_menu_top_level_ids")]
    public string[] ChatMenuTopLevelIds { get; set; } = Array.Empty<string>();
}
