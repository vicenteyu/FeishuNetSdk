// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetDocsV1ContentResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取云文档内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取云文档内容 响应体
/// <para>接口ID：7437110392792858625</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/docs-v1/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocs-v1%2fcontent%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDocsV1ContentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "content": "# Markdown Export Example Document\n\n# Text\n\n**Bold**\n\n*Italic*\n\n~~Strikethrough~~\n\nHyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\nInline code: `inline code`\n\nUnderline\n\nBackground color + font color\n\nPlain text with markdown syntax needs to be escaped, such as \\*\\*bold syntax\\*\\*, \\*italic syntax\\*, ~~strikethrough syntax~~, \\[hyperlink syntax\\]\\(https://open\\.feishu\\.cn\\), \\`inline code syntax\\`, etc.\n\nMentionDoc: [Markdown Export Example Document](https://example.feishu.cn/docx/FlYadoUfloTbYcxoJcccEoabcef)\n\nMentionUser: @Zhang San\n\nDate reminder: ⏰2024-04-27 15:30\n\nButton: Follow document updates open hyperlink - google\n\nInline file: \\[Markdown Export Example Document.md\\]\n\n# Bullet\n\n- **Bold**\n\n    - *Italic*\n\n    - ~~Strikethrough~~\n\n- Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\n    - Inline code: `inline code`\n\n- Underline\n\n    - Background color + font color\n\n# Ordered\n\n1. **Bold**\n\n    1. *Italic*\n\n    2. ~~Strikethrough~~\n\n2. Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\n    1. Inline code: `inline code`\n\n        1. Underline\n\n        2. Background color + font color\n\n# Code\n\n```JavaScript\nfunction greeting() {\n    console.log(\"Hello, World!\");\n}\n```\n\n# Quote\n\n> **Bold**\n> \n> *Italic*\n> \n> ~~Strikethrough~~\n> \n> Hyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n> \n> Inline code: `inline code`\n> \n> Underline\n> \n> Background color + font color\n> \n\n# Task\n\n* [ ] ~~This is an incomplete task list [Markdown Export Example Document](https://example.feishu.cn/docx/FlYadoUfloTbYcxoJcccEoabcef)⏰2024-04-27 15:30~~\n\n* [x] ~~This is a completed task list~~\n\n# Divider (Horizontal Rule)\n\n---\n\n# Table\n\n<table><tbody>\n<tr>\n<td>\n\n**Location**\n\n</td>\n<td>\n\n**Features**\n\n</td>\n<td>\n\n**Cuisine**\n\n</td>\n<td>\n\n**Price**\n\n</td>\n</tr>\n<tr>\n<td>\n\nShenzhen Old Street Snacks\n\n</td>\n<td>\n\nTraditional Cuisine\n\n</td>\n<td>\n\n- Roast Meat\n\n    - Roast Duck\n\n    - Roast Goose\n\n    - Roast Pork\n\n- Dim Sum\n\n    - Rice Noodle Roll\n\n    - Glutinous Rice Chicken\n\n- Seafood\n\n    - Shark Fin\n\n    - Seafood Congee\n\n</td>\n<td>\n\nMedium\n\n</td>\n</tr>\n<tr>\n<td>\n\nDameisha Seafood Street\n\n</td>\n<td>\n\nSeafood Market\n\n</td>\n<td>\n\n- Fresh Seafood\n\n    - Lobster\n\n    - Crab\n\n    - Scallops\n\n</td>\n<td>\n\nMedium-High\n\n</td>\n</tr>\n<tr>\n<td>\n\nNanshan District Seafood Street\n\n</td>\n<td>\n\nSeafood Market\n\n</td>\n<td>\n\n- Crab Roe Bun\n\n    - Crab Roe Soup Dumpling\n\n    - Crab Roe Steamed Bun\n\n- Stir-Fried Snail Rice Noodle\n\n    - Stir-Fried Snail Rice Noodle\n\n    - Stir-Fried Rice Noodle\n\n</td>\n<td>\n\nMedium\n\n</td>\n</tr>\n<tr>\n<td>\n\nLianhua Mountain Restaurant\n\n</td>\n<td>\n\nMountain Cuisine\n\n</td>\n<td>\n\n- Wild Game\n\n    - Wild Boar Meat\n\n    - Goat Meat\n\n    - Venison\n\n- Farmer's Dish\n\n    - Farmer's Stir-Fry\n\n    - Farmer's Claypot Rice\n\n</td>\n<td>\n\nMedium-High\n\n</td>\n</tr>\n<tr>\n<td>\n\nShenzhen Huaqiangbei Food Street\n\n</td>\n<td>\n\nFood Street\n\n</td>\n<td>\n\n- Hot Pot\n\n    - Spicy Hot Pot\n\n    - Clear Soup Hot Pot\n\n- Skewered Snacks\n\n    - Spicy Skewered Snacks\n\n    - Sour and Spicy Skewered Snacks\n\n- Barbecue\n\n    - Grilled Fish\n\n    - Grilled Meat\n\n</td>\n<td>\n\nLow to Medium\n\n</td>\n</tr>\n</tbody></table>\n\n# Grid\n\n<table><tbody><tr>\n<td>\n\n**Image One**\n\n</td>\n<td>\n\n**Image Two**\n\n</td>\n<td>\n\n**Image Three**\n\n</td>\n</tr></tbody></table>\n\n# Callout\n\n<div class=\"callout\">\n\nPlain text with markdown syntax needs to be escaped, such as \\*\\*bold syntax\\*\\*, \\*italic syntax\\*, ~~strikethrough syntax~~, \\[hyperlink syntax\\]\\(https://open\\.feishu\\.cn\\), \\`inline code syntax\\`, etc.\n\n</div>\n\n# SyncedSource\n\n**Bold**\n\n*Italic*\n\n~~Strikethrough~~\n\nHyperlink: [Feishu Open Platform](https%3A%2F%2Fopen.feishu.cn)\n\nInline code: `inline code`\n\nUnderline\n\n# SyncedReference\n\n# File\n\n\\[Markdown Export Example Document.md\\]\n\n# Bookmark\n\n[https://open.feishu.cn/]()\n\n# Poll\n\n# Agenda\n\nThis is the content of the agenda\n\n# Sheet\n\n# Bitable\n\n# Chart\n\n# Group Name Card\n\n# Whiteboard\n\n# Widget"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocsV1ContentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}