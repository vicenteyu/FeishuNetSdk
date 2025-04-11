// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-25
//
// Last Modified By : yxr
// Last Modified On : 2024-10-25
// ************************************************************************
// <copyright file="GetAilyV1AppsByAppIdSkillsBySkillIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取技能信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 获取技能信息 响应体
/// <para>该 API 用于查询某个 Aily 应用的特定技能详情</para>
/// <para>接口ID：7429225800963047426</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/app-skill/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-skill%2fget</para>
/// </summary>
public record GetAilyV1AppsByAppIdSkillsBySkillIdResponseDto
{
    /// <summary>
    /// <para>技能信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("skill")]
    public GetAilyV1AppsByAppIdSkillsBySkillIdResponseDtoSkill? Skill { get; set; }

    /// <summary>
    /// <para>技能信息</para>
    /// </summary>
    public record GetAilyV1AppsByAppIdSkillsBySkillIdResponseDtoSkill
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
        /// <para>示例值：""</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// <para>技能描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：""</para>
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
        /// <para>示例值：""</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("input_schema")]
        public string? InputSchema { get; set; }

        /// <summary>
        /// <para>技能出参定义</para>
        /// <para>必填：否</para>
        /// <para>示例值：""</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("output_schema")]
        public string? OutputSchema { get; set; }
    }
}
