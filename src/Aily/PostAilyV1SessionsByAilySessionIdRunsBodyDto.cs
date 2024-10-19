// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostAilyV1SessionsByAilySessionIdRunsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>创建运行 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建运行 请求体
/// <para>该 API 用于在某个飞书智能伙伴应用会话（Session）上创建一次运行（Run）。</para>
/// <para>## 实体概念说明</para>
/// <para>- **会话**（Session）：管理用户与 Aily 助手之间的交互会话；每次会话记录了用户发送给 Aily 助手的消息以及 Aily 助手的响应。</para>
/// <para>- **消息**（Message）：消息可以包含文本、表格、图片等多种类型的内容。</para>
/// <para>- **运行**（Run）：Aily 助手基于会话内消息进行意图判定、调用匹配的技能，并返回技能执行后的结果消息。</para>
/// <para>接口ID：7358047310868185092</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdRunsBodyDto
{
    /// <summary>
    /// <para>为 Aily 应用 ID（`spring_xxx__c`），可以在 Aily 应用开发页面的浏览器地址里获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：spring_449d72db2f__c</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>指定技能 ID（`skill_xxx`），可以在 Aily 技能配置页面的浏览器地址里获取</para>
    /// <para>&gt; 指定技能后、能够节省意图匹配的耗时</para>
    /// <para>必填：否</para>
    /// <para>示例值：skill_6cc6166178ca</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("skill_id")]
    public string? SkillId { get; set; }

    /// <summary>
    /// <para>指定技能 ID 时可以同时指定技能输入</para>
    /// <para>&gt; 备注：常用于工作流技能内指定自定义参数，`skill_input` 需要配合 `skill_id` 同时传递才能生效</para>
    /// <para>必填：否</para>
    /// <para>示例值：{\"key\": \"value\"}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("skill_input")]
    public string? SkillInput { get; set; }

    /// <summary>
    /// <para>其他扩展的参数（JSON String）</para>
    /// <para>&gt; 备注：`metadata` 传递的参数，可以在后续 `GetRun` 调用中原样读取获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}
