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
/// <para>给一个群内的一级菜单排序。</para>
/// <para>接口ID：7174746098262687748</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-menu_tree/sort</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-menu_tree%2fsort</para>
/// </summary>
public record PostImV1ChatsByChatIdMenuTreeSortBodyDto
{
    /// <summary>
    /// <para>新的一级菜单的顺序，进行排序ID列表需要跟群内目前存在的一级菜单ID列表对齐。通过 [获取群菜单](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-menu_tree/get) 接口获取群内菜单详情。</para>
    /// <para>必填：是</para>
    /// <para>示例值：7156553273518882844</para>
    /// </summary>
    [JsonPropertyName("chat_menu_top_level_ids")]
    public string[] ChatMenuTopLevelIds { get; set; } = Array.Empty<string>();
}
