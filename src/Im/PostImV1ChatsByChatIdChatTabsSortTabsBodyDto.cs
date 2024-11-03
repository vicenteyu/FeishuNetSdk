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
/// <para>调整指定会话内的多个会话标签页排列顺序。</para>
/// <para>## 前提条件</para>
/// <para>- 应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>- 调用当前接口的用户或者机器人必须在对应的会话内。</para>
/// <para>## 使用限制</para>
/// <para>- 会话内消息类型的标签页固定为第一顺位，不参与排序，但需要注意请求时 tab_ids 必须包含消息类型标签页的 ID。</para>
/// <para>- 如果群组配置了 **仅群主和群管理员可以管理标签页**，则仅群主或者群管理员可以调整会话标签页排序。</para>
/// <para>- 操作内部群时，操作者须与群组在同一租户下。</para>
/// <para>接口ID：7111246605500628993</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat-tab/sort_tabs</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat-tab%2fsort_tabs</para>
/// </summary>
public record PostImV1ChatsByChatIdChatTabsSortTabsBodyDto
{
    /// <summary>
    /// <para>会话标签页 ID 列表，ID 可以在[添加会话标签页](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/create)或者[拉取会话标签页](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-tab/list_tabs)接口返回值中获取。</para>
    /// <para>**注意**：</para>
    /// <para>- 必须包含会话内全部标签页的 ID。</para>
    /// <para>- 当前参数的排序，对应会话内从左往右的排序。</para>
    /// <para>- 会话内消息类型的标签页固定在第一顺位。</para>
    /// <para>必填：否</para>
    /// <para>示例值：["7101214603622940671", "7101214603622940672"]</para>
    /// </summary>
    [JsonPropertyName("tab_ids")]
    public string[]? TabIds { get; set; }
}
