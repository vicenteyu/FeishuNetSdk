namespace FeishuNetSdk.Aily;
/// <summary>
/// 创建运行 请求体
/// <para>该 API 用于在某个飞书智能伙伴应用会话（Session）上创建一次运行（Run）。</para>
/// <para>接口ID：7358047310868185092</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcreate</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdRunsBodyDto
{
    /// <summary>
    /// <para>应用 ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：spring_xxx__c</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("app_id")]
    public string AppId { get; set; } = string.Empty;

    /// <summary>
    /// <para>技能 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：skill_6cc6166178ca</para>
    /// <para>最大长度：32</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("skill_id")]
    public string? SkillId { get; set; }

    /// <summary>
    /// <para>指定技能 ID 时可以同时指定技能输入</para>
    /// <para>必填：否</para>
    /// <para>示例值：{"key": "value"}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("skill_input")]
    public string? SkillInput { get; set; }

    /// <summary>
    /// <para>其他透传信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：{}</para>
    /// <para>最大长度：255</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}
