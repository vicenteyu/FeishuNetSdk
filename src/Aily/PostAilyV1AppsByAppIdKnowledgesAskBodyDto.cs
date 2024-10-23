// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-23
//
// Last Modified By : yxr
// Last Modified On : 2024-10-23
// ************************************************************************
// <copyright file="PostAilyV1AppsByAppIdKnowledgesAskBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>执行数据知识问答 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 执行数据知识问答 请求体
/// <para>执行飞书智能伙伴的数据知识问答</para>
/// <para>接口ID：7424752773160779780</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/app-knowledge/ask</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-knowledge%2fask</para>
/// </summary>
public record PostAilyV1AppsByAppIdKnowledgesAskBodyDto
{
    /// <summary>
    /// <para>输入消息（当前仅支持纯文本输入）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("message")]
    public AilyKnowledgeMessage Message { get; set; } = new();

    /// <summary>
    /// <para>输入消息（当前仅支持纯文本输入）</para>
    /// </summary>
    public record AilyKnowledgeMessage
    {
        /// <summary>
        /// <para>消息内容</para>
        /// <para>必填：否</para>
        /// <para>示例值：推荐一部电影</para>
        /// <para>最大长度：65535</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }
    }

    /// <summary>
    /// <para>控制知识问答所依据的数据知识范围</para>
    /// <para>必填：否</para>
    /// <para>最大长度：65535</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("data_asset_ids")]
    public string[]? DataAssetIds { get; set; }

    /// <summary>
    /// <para>控制知识问答所依据的数据知识分类范围</para>
    /// <para>必填：否</para>
    /// <para>最大长度：65535</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("data_asset_tag_ids")]
    public string[]? DataAssetTagIds { get; set; }
}
