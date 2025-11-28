// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdMenuTreeSortBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>排序群菜单 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 排序群菜单 请求体
/// <para>调整指定群组内的群菜单排列顺序，成功调用后接口会返回群组内所有群菜单信息。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的机器人必须在对应的群组内。</para>
/// <para>## 使用限制</para>
/// <para>- 该接口仅支持群模式为 `group` 的群组，你可以调用[获取群信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat/get)接口，在返回结果中查看 `chat_mode` 参数取值是否为 `group`。</para>
/// <para>- 仅支持调整群组内一级菜单的排序。</para>
/// <para>接口ID：7174746098262687748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/sort</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fsort</para>
/// </summary>
public record PostImV1ChatsByChatIdMenuTreeSortBodyDto
{
    /// <summary>
    /// <para>通过一级菜单的 ID 进行排序。数组内的元素排序对应群组内一级菜单从左往右的排序。ID 可通过 [获取群菜单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-menu_tree/get) 接口获取。</para>
    /// <para>**说明**：进行排序的 ID 列表需要跟群内存在的一级菜单 ID 列表对齐。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7156553273518882844</para>
    /// </summary>
    [JsonPropertyName("chat_menu_top_level_ids")]
    public string[] ChatMenuTopLevelIds { get; set; } = [];
}
