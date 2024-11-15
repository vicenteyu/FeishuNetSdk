// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-11-15
//
// Last Modified By : yxr
// Last Modified On : 2024-11-15
// ************************************************************************
// <copyright file="GetDocsV1ContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取云文档内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取云文档内容 响应体
/// <para>可获取云文档内容，当前只支持获取新版文档 Markdown 格式的内容。</para>
/// <para>接口ID：7437110392792858625</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/docs-v1/content/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocs-v1%2fcontent%2fget</para>
/// </summary>
public record GetDocsV1ContentResponseDto
{
    /// <summary>
    /// <para>内容</para>
    /// <para>必填：否</para>
    /// <para>示例值：# Markdown Export Example Document\n\n# Text\n\n**Bold**\n\n*Italic*\n\n~~Strikethrough~~\n\nHyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\nInline code: `inline code`\n\nUnderline\n\nBackground color + font color\n\nPlain text with markdown syntax needs to be escaped, such as \\*\\*bold syntax\\*\\*, \\*italic syntax\\*, ~~strikethrough syntax~~, \\[hyperlink syntax\\]\\(https://open\\.feishu\\.cn\\), \\`inline code syntax\\`, etc.\n\nMentionDoc: [Markdown Export Example Document](https://example.feishu.cn/docx/FlYadoUfloTbYcxoJcccEoabcef)\n\nMentionUser: @Zhang San\n\nDate reminder: ⏰2024-04-27 15:30\n\nButton: Follow document updates open hyperlink - google\n\nInline file: \\[Markdown Export Example Document.md\\]\n\n# Bullet\n\n- **Bold**\n\n - *Italic*\n\n - ~~Strikethrough~~\n\n- Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\n - Inline code: `inline code`\n\n- Underline\n\n - Background color + font color\n\n# Ordered\n\n1. **Bold**\n\n 1. *Italic*\n\n 2. ~~Strikethrough~~\n\n2. Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\n 1. Inline code: `inline code`\n\n 1. Underline\n\n 2. Background color + font color\n\n# Code\n\n```JavaScript\nfunction greeting() {\n console.log(\"Hello, World!\");\n}\n```\n\n# Quote\n\n&gt; **Bold**\n&gt; \n&gt; *Italic*\n&gt; \n&gt; ~~Strikethrough~~\n&gt; \n&gt; Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n&gt; \n&gt; Inline code: `inline code`\n&gt; \n&gt; Underline\n&gt; \n&gt; Background color + font color\n&gt; \n\n# Task\n\n* [ ] ~~This is an incomplete task list [Markdown Export Example Document](https://example.feishu.cn/docx/FlYadoUfloTbYcxoJcccEoabcef)⏰2024-04-27 15:30~~\n\n* [x] ~~This is a completed task list~~\n\n# Divider (Horizontal Rule)\n\n---\n\n# Table\n\n&lt;table&gt;&lt;tbody&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\n**Location**\n\n&lt;/td&gt;\n&lt;td&gt;\n\n**Features**\n\n&lt;/td&gt;\n&lt;td&gt;\n\n**Cuisine**\n\n&lt;/td&gt;\n&lt;td&gt;\n\n**Price**\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\nShenzhen Old Street Snacks\n\n&lt;/td&gt;\n&lt;td&gt;\n\nTraditional Cuisine\n\n&lt;/td&gt;\n&lt;td&gt;\n\n- Roast Meat\n\n - Roast Duck\n\n - Roast Goose\n\n - Roast Pork\n\n- Dim Sum\n\n - Rice Noodle Roll\n\n - Glutinous Rice Chicken\n\n- Seafood\n\n - Shark Fin\n\n - Seafood Congee\n\n&lt;/td&gt;\n&lt;td&gt;\n\nMedium\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\nDameisha Seafood Street\n\n&lt;/td&gt;\n&lt;td&gt;\n\nSeafood Market\n\n&lt;/td&gt;\n&lt;td&gt;\n\n- Fresh Seafood\n\n - Lobster\n\n - Crab\n\n - Scallops\n\n&lt;/td&gt;\n&lt;td&gt;\n\nMedium-High\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\nNanshan District Seafood Street\n\n&lt;/td&gt;\n&lt;td&gt;\n\nSeafood Market\n\n&lt;/td&gt;\n&lt;td&gt;\n\n- Crab Roe Bun\n\n - Crab Roe Soup Dumpling\n\n - Crab Roe Steamed Bun\n\n- Stir-Fried Snail Rice Noodle\n\n - Stir-Fried Snail Rice Noodle\n\n - Stir-Fried Rice Noodle\n\n&lt;/td&gt;\n&lt;td&gt;\n\nMedium\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\nLianhua Mountain Restaurant\n\n&lt;/td&gt;\n&lt;td&gt;\n\nMountain Cuisine\n\n&lt;/td&gt;\n&lt;td&gt;\n\n- Wild Game\n\n - Wild Boar Meat\n\n - Goat Meat\n\n - Venison\n\n- Farmer's Dish\n\n - Farmer's Stir-Fry\n\n - Farmer's Claypot Rice\n\n&lt;/td&gt;\n&lt;td&gt;\n\nMedium-High\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;tr&gt;\n&lt;td&gt;\n\nShenzhen Huaqiangbei Food Street\n\n&lt;/td&gt;\n&lt;td&gt;\n\nFood Street\n\n&lt;/td&gt;\n&lt;td&gt;\n\n- Hot Pot\n\n - Spicy Hot Pot\n\n - Clear Soup Hot Pot\n\n- Skewered Snacks\n\n - Spicy Skewered Snacks\n\n - Sour and Spicy Skewered Snacks\n\n- Barbecue\n\n - Grilled Fish\n\n - Grilled Meat\n\n&lt;/td&gt;\n&lt;td&gt;\n\nLow to Medium\n\n&lt;/td&gt;\n&lt;/tr&gt;\n&lt;/tbody&gt;&lt;/table&gt;\n\n# Grid\n\n&lt;table&gt;&lt;tbody&gt;&lt;tr&gt;\n&lt;td&gt;\n\n**Image One**\n\n&lt;/td&gt;\n&lt;td&gt;\n\n**Image Two**\n\n&lt;/td&gt;\n&lt;td&gt;\n\n**Image Three**\n\n&lt;/td&gt;\n&lt;/tr&gt;&lt;/tbody&gt;&lt;/table&gt;\n\n# Callout\n\n&lt;div class=\"callout\"&gt;\n\nPlain text with markdown syntax needs to be escaped, such as \\*\\*bold syntax\\*\\*, \\*italic syntax\\*, ~~strikethrough syntax~~, \\[hyperlink syntax\\]\\(https://open\\.feishu\\.cn\\), \\`inline code syntax\\`, etc.\n\n&lt;/div&gt;\n\n# SyncedSource\n\n**Bold**\n\n*Italic*\n\n~~Strikethrough~~\n\nHyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\nInline code: `inline code`\n\nUnderline\n\n# SyncedReference\n\n# File\n\n\\[Markdown Export Example Document.md\\]\n\n# Bookmark\n\n[https://open.feishu.cn/]()\n\n# Poll\n\n# Agenda\n\nThis is the content of the agenda\n\n# Sheet\n\n# Bitable\n\n# Chart\n\n# Group Name Card\n\n# Whiteboard\n\n# Widget</para>
    /// <para>最大长度：10485760</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
