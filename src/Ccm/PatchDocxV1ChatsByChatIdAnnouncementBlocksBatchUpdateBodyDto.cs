// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-21
//
// Last Modified By : yxr
// Last Modified On : 2024-12-21
// ************************************************************************
// <copyright file="PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量更新群公告块的内容 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 批量更新群公告块的内容 请求体
/// <para>接口ID：7450053428095549468</para>
/// <para>文档地址：https://open.feishu.cn/document/group/upgraded-group-announcement/chat-announcement-block/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fchat-announcement-block%2fbatch_update</para>
/// </summary>
public record PatchDocxV1ChatsByChatIdAnnouncementBlocksBatchUpdateBodyDto
{
    /// <summary>
    /// <para>批量更新 Block</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("requests")]
    public UpdateBlockRequest[]? Requests { get; set; }

    /// <summary>
    /// <para>批量更新 Block</para>
    /// </summary>
    public record UpdateBlockRequest
    {
        /// <summary>
        /// <para>更新文本元素请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_text_elements")]
        public UpdateTextElementsRequest? UpdateTextElements { get; set; }

        /// <summary>
        /// <para>更新文本元素请求</para>
        /// </summary>
        public record UpdateTextElementsRequest
        {
            /// <summary>
            /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
            /// <para>必填：是</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>更新文本样式请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_text_style")]
        public UpdateTextStyleRequest? UpdateTextStyle { get; set; }

        /// <summary>
        /// <para>更新文本样式请求</para>
        /// </summary>
        public record UpdateTextStyleRequest
        {
            /// <summary>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("style")]
            public TextStyle Style { get; set; } = new();

            /// <summary>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro（已废弃）</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo（已废弃）</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL（已废弃）</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript（已废弃）</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG（已废弃）</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch（已废弃）</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("wrap")]
                public bool? Wrap { get; set; }

                /// <summary>
                /// <para>块背景色</para>
                /// <para>必填：否</para>
                /// <para>示例值：LightGrayBackground</para>
                /// <para>可选值：<list type="bullet">
                /// <item>LightGrayBackground：浅灰色</item>
                /// <item>LightRedBackground：浅红色</item>
                /// <item>LightOrangeBackground：浅橙色</item>
                /// <item>LightYellowBackground：浅黄色</item>
                /// <item>LightGreenBackground：浅绿色</item>
                /// <item>LightBlueBackground：浅蓝色</item>
                /// <item>LightPurpleBackground：浅紫色</item>
                /// <item>PaleGrayBackground：淡灰色</item>
                /// <item>DarkGrayBackground：深灰色</item>
                /// <item>DarkRedBackground：深红色</item>
                /// <item>DarkOrangeBackground：深橙色</item>
                /// <item>DarkYellowBackground：深黄色</item>
                /// <item>DarkGreenBackground：深绿色</item>
                /// <item>DarkBlueBackground：深蓝色</item>
                /// <item>DarkPurpleBackground：深紫色</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// <para>首行缩进级别</para>
                /// <para>必填：否</para>
                /// <para>示例值：NoIndent</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoIndent：无缩进</item>
                /// <item>OneLevelIndent：一级缩进</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("indentation_level")]
                public string? IndentationLevel { get; set; }

                /// <summary>
                /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                /// <para>必填：否</para>
                /// <para>示例值："auto"</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public string? Sequence { get; set; }
            }

            /// <summary>
            /// <para>应更新的字段，必须至少指定一个字段。例如，要调整 Block 对齐方式，请设置 fields 为 [1]。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public int[] Fields { get; set; } = Array.Empty<int>();
        }

        /// <summary>
        /// <para>更新表格属性请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_table_property")]
        public UpdateTablePropertyRequest? UpdateTableProperty { get; set; }

        /// <summary>
        /// <para>更新表格属性请求</para>
        /// </summary>
        public record UpdateTablePropertyRequest
        {
            /// <summary>
            /// <para>表格列宽</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// <para>最小值：50</para>
            /// </summary>
            [JsonPropertyName("column_width")]
            public int? ColumnWidth { get; set; }

            /// <summary>
            /// <para>需要修改列宽的表格列的索引（修改表格列宽时必填）</para>
            /// <para>必填：否</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int? ColumnIndex { get; set; }

            /// <summary>
            /// <para>设置首行为标题行</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("header_row")]
            public bool? HeaderRow { get; set; }

            /// <summary>
            /// <para>设置首列为标题列</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("header_column")]
            public bool? HeaderColumn { get; set; }
        }

        /// <summary>
        /// <para>表格插入新行请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("insert_table_row")]
        public InsertTableRowRequest? InsertTableRow { get; set; }

        /// <summary>
        /// <para>表格插入新行请求</para>
        /// </summary>
        public record InsertTableRowRequest
        {
            /// <summary>
            /// <para>插入的行在表格中的索引。（-1表示在表格末尾插入一行）</para>
            /// <para>必填：是</para>
            /// <para>示例值：-1</para>
            /// <para>最小值：-1</para>
            /// </summary>
            [JsonPropertyName("row_index")]
            public int RowIndex { get; set; }
        }

        /// <summary>
        /// <para>表格插入新列请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("insert_table_column")]
        public InsertTableColumnRequest? InsertTableColumn { get; set; }

        /// <summary>
        /// <para>表格插入新列请求</para>
        /// </summary>
        public record InsertTableColumnRequest
        {
            /// <summary>
            /// <para>插入的列在表格中的索引。（-1表示在表格末尾插入一列）</para>
            /// <para>必填：是</para>
            /// <para>示例值：-1</para>
            /// <para>最小值：-1</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int ColumnIndex { get; set; }
        }

        /// <summary>
        /// <para>表格批量删除行请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("delete_table_rows")]
        public DeleteTableRowsRequest? DeleteTableRows { get; set; }

        /// <summary>
        /// <para>表格批量删除行请求</para>
        /// </summary>
        public record DeleteTableRowsRequest
        {
            /// <summary>
            /// <para>行开始索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("row_start_index")]
            public int RowStartIndex { get; set; }

            /// <summary>
            /// <para>行结束索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("row_end_index")]
            public int RowEndIndex { get; set; }
        }

        /// <summary>
        /// <para>表格批量删除列请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("delete_table_columns")]
        public DeleteTableColumnsRequest? DeleteTableColumns { get; set; }

        /// <summary>
        /// <para>表格批量删除列请求</para>
        /// </summary>
        public record DeleteTableColumnsRequest
        {
            /// <summary>
            /// <para>列开始索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("column_start_index")]
            public int ColumnStartIndex { get; set; }

            /// <summary>
            /// <para>列结束索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("column_end_index")]
            public int ColumnEndIndex { get; set; }
        }

        /// <summary>
        /// <para>表格合并单元格请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("merge_table_cells")]
        public MergeTableCellsRequest? MergeTableCells { get; set; }

        /// <summary>
        /// <para>表格合并单元格请求</para>
        /// </summary>
        public record MergeTableCellsRequest
        {
            /// <summary>
            /// <para>行起始索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("row_start_index")]
            public int RowStartIndex { get; set; }

            /// <summary>
            /// <para>行结束索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("row_end_index")]
            public int RowEndIndex { get; set; }

            /// <summary>
            /// <para>列起始索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("column_start_index")]
            public int ColumnStartIndex { get; set; }

            /// <summary>
            /// <para>列结束索引（区间左闭右开）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonPropertyName("column_end_index")]
            public int ColumnEndIndex { get; set; }
        }

        /// <summary>
        /// <para>表格取消单元格合并状态请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("unmerge_table_cells")]
        public UnmergeTableCellsRequest? UnmergeTableCells { get; set; }

        /// <summary>
        /// <para>表格取消单元格合并状态请求</para>
        /// </summary>
        public record UnmergeTableCellsRequest
        {
            /// <summary>
            /// <para>table 行索引</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("row_index")]
            public int RowIndex { get; set; }

            /// <summary>
            /// <para>table 列索引</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：0</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int ColumnIndex { get; set; }
        }

        /// <summary>
        /// <para>分栏插入新的分栏列请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("insert_grid_column")]
        public InsertGridColumnRequest? InsertGridColumn { get; set; }

        /// <summary>
        /// <para>分栏插入新的分栏列请求</para>
        /// </summary>
        public record InsertGridColumnRequest
        {
            /// <summary>
            /// <para>插入列索引，从 1 开始，如 1 表示在第一列后插入，注意不允许传 0（-1表示在最后一列后插入）</para>
            /// <para>必填：是</para>
            /// <para>示例值：1</para>
            /// <para>最小值：-1</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int ColumnIndex { get; set; }
        }

        /// <summary>
        /// <para>分栏删除列请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("delete_grid_column")]
        public DeleteGridColumnRequest? DeleteGridColumn { get; set; }

        /// <summary>
        /// <para>分栏删除列请求</para>
        /// </summary>
        public record DeleteGridColumnRequest
        {
            /// <summary>
            /// <para>删除列索引，从 0 开始，如 0 表示删除第一列（-1表示删除最后一列）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最小值：-1</para>
            /// </summary>
            [JsonPropertyName("column_index")]
            public int ColumnIndex { get; set; }
        }

        /// <summary>
        /// <para>更新分栏列宽比例请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_grid_column_width_ratio")]
        public UpdateGridColumnWidthRatioRequest? UpdateGridColumnWidthRatio { get; set; }

        /// <summary>
        /// <para>更新分栏列宽比例请求</para>
        /// </summary>
        public record UpdateGridColumnWidthRatioRequest
        {
            /// <summary>
            /// <para>更新列宽比例时，需要传入所有列宽占比</para>
            /// <para>必填：是</para>
            /// <para>示例值：50</para>
            /// <para>最大长度：99</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("width_ratios")]
            public int[] WidthRatios { get; set; } = Array.Empty<int>();
        }

        /// <summary>
        /// <para>替换图片请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("replace_image")]
        public ReplaceImageRequest? ReplaceImage { get; set; }

        /// <summary>
        /// <para>替换图片请求</para>
        /// </summary>
        public record ReplaceImageRequest
        {
            /// <summary>
            /// <para>图片 token</para>
            /// <para>必填：是</para>
            /// <para>示例值：boxbcVA91JtFgNhaCgy6s6wK4he</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;

            /// <summary>
            /// <para>图片宽度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("width")]
            public int? Width { get; set; }

            /// <summary>
            /// <para>图片高度，单位 px</para>
            /// <para>必填：否</para>
            /// <para>示例值：100</para>
            /// </summary>
            [JsonPropertyName("height")]
            public int? Height { get; set; }

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("align")]
            public int? Align { get; set; }
        }

        /// <summary>
        /// <para>替换附件请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("replace_file")]
        public ReplaceFileRequest? ReplaceFile { get; set; }

        /// <summary>
        /// <para>替换附件请求</para>
        /// </summary>
        public record ReplaceFileRequest
        {
            /// <summary>
            /// <para>附件 token</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("token")]
            public string Token { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>Block 唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：doxcnSS4ouQkQEouGSUkTg9NJPe</para>
        /// </summary>
        [JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// <para>更新文本元素及样式请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_text")]
        public UpdateTextRequest? UpdateText { get; set; }

        /// <summary>
        /// <para>更新文本元素及样式请求</para>
        /// </summary>
        public record UpdateTextRequest
        {
            /// <summary>
            /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
            /// <para>必填：是</para>
            /// <para>最小长度：1</para>
            /// </summary>
            [JsonPropertyName("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>更新的文本元素列表，单次更新中 reminder 上限 30 个，mention_doc 上限 50 个，mention_user 上限 100 个</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonPropertyName("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonPropertyName("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文档标题，只读属性</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：undefined</para>
                    /// <para>最大长度：800</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("title")]
                    public string? Title { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonPropertyName("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是否通知</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_notify")]
                    public bool? IsNotify { get; set; }

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonPropertyName("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级事件戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonPropertyName("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>触发通知的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1643166000000</para>
                    /// </summary>
                    [JsonPropertyName("notify_time")]
                    public string NotifyTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonPropertyName("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonPropertyName("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>未支持的 TextElement</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("undefined")]
                public object? Undefined { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonPropertyName("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonPropertyName("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonPropertyName("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonPropertyName("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonPropertyName("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 id 列表</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonPropertyName("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }

            /// <summary>
            /// <para>更新的文本样式</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("style")]
            public TextStyle Style { get; set; } = new();

            /// <summary>
            /// <para>更新的文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro（已废弃）</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo（已废弃）</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL（已废弃）</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript（已废弃）</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG（已废弃）</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch（已废弃）</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("wrap")]
                public bool? Wrap { get; set; }

                /// <summary>
                /// <para>块背景色</para>
                /// <para>必填：否</para>
                /// <para>示例值：LightGrayBackground</para>
                /// <para>可选值：<list type="bullet">
                /// <item>LightGrayBackground：浅灰色</item>
                /// <item>LightRedBackground：浅红色</item>
                /// <item>LightOrangeBackground：浅橙色</item>
                /// <item>LightYellowBackground：浅黄色</item>
                /// <item>LightGreenBackground：浅绿色</item>
                /// <item>LightBlueBackground：浅蓝色</item>
                /// <item>LightPurpleBackground：浅紫色</item>
                /// <item>PaleGrayBackground：淡灰色</item>
                /// <item>DarkGrayBackground：深灰色</item>
                /// <item>DarkRedBackground：深红色</item>
                /// <item>DarkOrangeBackground：深橙色</item>
                /// <item>DarkYellowBackground：深黄色</item>
                /// <item>DarkGreenBackground：深绿色</item>
                /// <item>DarkBlueBackground：深蓝色</item>
                /// <item>DarkPurpleBackground：深紫色</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("background_color")]
                public string? BackgroundColor { get; set; }

                /// <summary>
                /// <para>首行缩进级别</para>
                /// <para>必填：否</para>
                /// <para>示例值：NoIndent</para>
                /// <para>可选值：<list type="bullet">
                /// <item>NoIndent：无缩进</item>
                /// <item>OneLevelIndent：一级缩进</item>
                /// </list></para>
                /// </summary>
                [JsonPropertyName("indentation_level")]
                public string? IndentationLevel { get; set; }

                /// <summary>
                /// <para>用于确定有序列表项编号，为具体数值或'auto'</para>
                /// <para>必填：否</para>
                /// <para>示例值："auto"</para>
                /// </summary>
                [JsonPropertyName("sequence")]
                public string? Sequence { get; set; }
            }

            /// <summary>
            /// <para>文本样式中应更新的字段，必须至少指定一个字段。例如，要调整 Block 对齐方式，请设置 fields 为 [1]。</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonPropertyName("fields")]
            public int[] Fields { get; set; } = Array.Empty<int>();
        }

        /// <summary>
        /// <para>更新任务 Block 请求</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("update_task")]
        public UpdateTaskRequest? UpdateTask { get; set; }

        /// <summary>
        /// <para>更新任务 Block 请求</para>
        /// </summary>
        public record UpdateTaskRequest
        {
            /// <summary>
            /// <para>任务 ID。该字段仅在首次更新 Task Block 时生效，更新成功后，后续请求中将忽略该字段。</para>
            /// <para>必填：否</para>
            /// <para>示例值：ba5040f4-8116-4042-ab3c-254e5cfe3ce7</para>
            /// </summary>
            [JsonPropertyName("task_id")]
            public string? TaskId { get; set; }

            /// <summary>
            /// <para>折叠状态，字段为空时不更新折叠状态</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// </summary>
            [JsonPropertyName("folded")]
            public bool? Folded { get; set; }
        }
    }
}
