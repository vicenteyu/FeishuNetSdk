// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-22
//
// Last Modified By : yxr
// Last Modified On : 2025-06-22
// ************************************************************************
// <copyright file="TextElement.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文本元素</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Dtos;

/// <summary>
/// <para>文本元素</para>
/// </summary>
public record TextElement
{
    /// <summary>
    /// <para>文本局部样式</para>
    /// </summary>
    public record TextElementStyle
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
        public TextElementStyleLink? Link { get; set; }

        /// <summary>
        /// <para>链接</para>
        /// </summary>
        public record TextElementStyleLink
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
        public TextElementStyle? TextElementStyle { get; set; }
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
        public TextElementStyle? TextElementStyle { get; set; }
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
        /// <para>云文档链接（需要 url_encode)，指定了 fallback_type 时此字段必填</para>
        /// <para>必填：否</para>
        /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <para>文档标题，fallback_type 为 FallbackToLink 时此字段必填</para>
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
        public TextElementStyle? TextElementStyle { get; set; }

        /// <summary>
        /// <para>无云文档阅读权限或云文档已删除时的降级方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：FallbackToLink</para>
        /// <para>可选值：<list type="bullet">
        /// <item>FallbackToLink：降级为超链接形式写入，超链接的文本内容为当前传入的文档标题，链接为当前传入的云文档链接（需要 url_encode）</item>
        /// <item>FallbackToText：降级为文本形式写入，文本内容为当前传入的云文档链接进行 URL 解码后的结果</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("fallback_type")]
        public string? FallbackType { get; set; }
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
        public TextElementStyle? TextElementStyle { get; set; }
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
        public TextElementStyle? TextElementStyle { get; set; }
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
        public TextElementStyle? TextElementStyle { get; set; }
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
        public TextElementStyle? TextElementStyle { get; set; }
    }
}