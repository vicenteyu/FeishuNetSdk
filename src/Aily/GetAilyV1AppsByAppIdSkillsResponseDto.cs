// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-25
//
// Last Modified By : yxr
// Last Modified On : 2024-10-25
// ************************************************************************
// <copyright file="GetAilyV1AppsByAppIdSkillsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询技能列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 查询技能列表 响应体
/// <para>该 API 用于查询某个 Aily 应用的技能列表</para>
/// <para>&gt; 包括内置的数据分析与问答技能、以及未在对话开启的技能。</para>
/// <para>接口ID：7429225800963063810</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/app-skill/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2flist</para>
/// </summary>
public record GetAilyV1AppsByAppIdSkillsResponseDto
{
    /// <summary>
    /// <para>技能列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("skills")]
    public Skill[]? Skills { get; set; }

    /// <summary>
    /// <para>技能列表</para>
    /// </summary>
    public record Skill
    {
        /// <summary>
        /// <para>技能 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：skill_6cc6166178ca</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>技能名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：数据分析和问答</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// <para>技能描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：理解用户提出的问题，对当前助手已经配置的数据资产进行知识搜索、数据分析、文档阅读，总结并返回答案。</para>
        /// <para>最大长度：512</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>用户提问示例</para>
        /// <para>必填：否</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("samples")]
        public string[]? Samples { get; set; }

        /// <summary>
        /// <para>技能入参定义</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"name":"custom_s","type":"String","required":true,"defaultValue":"qwert","description":"自定义字符串"},{"name":"custom_i","type":"Integer","required":true,"defaultValue":null,"description":""},{"name":"custom_b","type":"Boolean","required":true,"defaultValue":true,"description":""},{"name":"custom_f","type":"Float","required":true,"defaultValue":2.1,"description":""}]</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("input_schema")]
        public string? InputSchema { get; set; }

        /// <summary>
        /// <para>技能出参定义</para>
        /// <para>必填：否</para>
        /// <para>示例值：[{"name":"input","type":"String","required":false,"defaultValue":null},{"name":"custom","type":"Boolean","required":false,"defaultValue":null}]</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("output_schema")]
        public string? OutputSchema { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
