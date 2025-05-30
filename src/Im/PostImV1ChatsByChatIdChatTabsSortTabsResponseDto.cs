// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-05-31
// ************************************************************************
// <copyright file="PostImV1ChatsByChatIdChatTabsSortTabsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>会话标签页排序 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 会话标签页排序 响应体
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
public record PostImV1ChatsByChatIdChatTabsSortTabsResponseDto
{
    /// <summary>
    /// <para>会话标签页</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_tabs")]
    public ChatTab[]? ChatTabs { get; set; }

    /// <summary>
    /// <para>会话标签页</para>
    /// </summary>
    public record ChatTab
    {
        /// <summary>
        /// <para>会话标签页 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7101214603622940671</para>
        /// </summary>
        [JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// <para>会话标签页名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：文档</para>
        /// </summary>
        [JsonPropertyName("tab_name")]
        public string? TabName { get; set; }

        /// <summary>
        /// <para>会话标签页类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：doc</para>
        /// <para>可选值：<list type="bullet">
        /// <item>message：消息类型</item>
        /// <item>doc_list：云文档列表</item>
        /// <item>doc：文档</item>
        /// <item>pin：Pin</item>
        /// <item>meeting_minute：会议纪要</item>
        /// <item>chat_announcement：群公告</item>
        /// <item>url：URL</item>
        /// <item>file：文件</item>
        /// <item>files_resources：合并类型，包含文件、Doc文档、URL链接</item>
        /// <item>images_videos：合并类型，包含图片、视频</item>
        /// <item>task：任务</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("tab_type")]
        public string TabType { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话标签页内容</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tab_content")]
        public ChatTabContent? TabContent { get; set; }

        /// <summary>
        /// <para>会话标签页内容</para>
        /// </summary>
        public record ChatTabContent
        {
            /// <summary>
            /// <para>url 类型标签页对应的 URL 地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://www.feishu.cn</para>
            /// </summary>
            [JsonPropertyName("url")]
            public string? Url { get; set; }

            /// <summary>
            /// <para>文档类型标签页对应的云文档链接</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.feishu.cn/wiki/wikcnPIcqWjJQwkwDzrB9t40123xz</para>
            /// </summary>
            [JsonPropertyName("doc")]
            public string? Doc { get; set; }

            /// <summary>
            /// <para>会议纪要类型标签页对应的会议纪要地址</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://example.feishu.cn/docs/doccnvIXbV22i6hSD3utar4123dx</para>
            /// </summary>
            [JsonPropertyName("meeting_minute")]
            public string? MeetingMinute { get; set; }

            /// <summary>
            /// <para>任务</para>
            /// <para>必填：否</para>
            /// <para>示例值：https://bytedance.feishu.cn/client/todo/task_list?guid=fa03fb6d-344b-47d9-83e3-049e3b3da931</para>
            /// </summary>
            [JsonPropertyName("task")]
            public string? Task { get; set; }
        }

        /// <summary>
        /// <para>会话标签页配置</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("tab_config")]
        public ChatTabConfig? TabConfig { get; set; }

        /// <summary>
        /// <para>会话标签页配置</para>
        /// </summary>
        public record ChatTabConfig
        {
            /// <summary>
            /// <para>会话标签页图标。可调用[下载图片](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/image/get)（只能下载由当前机器人上传的图片），将图标下载至本地查看</para>
            /// <para>必填：否</para>
            /// <para>示例值：img_v2_b99741-7628-4abd-aad0-b881e4db83ig</para>
            /// </summary>
            [JsonPropertyName("icon_key")]
            public string? IconKey { get; set; }

            /// <summary>
            /// <para>会话标签页是否在 App 内嵌打开</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("is_built_in")]
            public bool? IsBuiltIn { get; set; }
        }
    }
}
