// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdChatTabsSortTabsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会话标签页排序 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 会话标签页排序 请求体
/// <para>会话标签页排序。</para>
/// <para>接口ID：7111246605500628993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/sort_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fsort_tabs</para>
/// </summary>
public record PostImV1ChatsByChatIdChatTabsSortTabsBodyDto
{
    /// <summary>
    /// <para>会话标签页ID列表，Tab ID可以在[添加会话标签页](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/create)与[拉取会话标签页](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/list_tabs)的返回值中获取</para>
    /// <para>**注意**：必须包含该会话中全部的Tab ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7101214603622940671","7101214603622940672"]</para>
    /// </summary>
    [JsonPropertyName("tab_ids")]
    public string[]? TabIds { get; set; }
}
