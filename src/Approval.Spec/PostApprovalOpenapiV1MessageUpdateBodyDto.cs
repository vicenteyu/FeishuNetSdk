using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 更新审批 Bot 消息 请求体
/// <para>此接口可以根据审批bot消息id及相应状态，更新相应的审批bot消息，只可用于更新待审批模板的bot消息。例如，给用户推送了审批待办消息，当用户处理该消息后，可以将之前推送的Bot消息更新为已审批。</para>
/// <para>**注意：该接口只能更新模板为 1008「收到审批待办」的卡片。**</para>
/// <para>接口ID：6907569743419752450</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/approval-v4/message/update-bot-messages</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuAjNyYjLwYjM24CM2IjN</para>
/// </summary>
public record PostApprovalOpenapiV1MessageUpdateBodyDto
{
    /// <summary>
    /// <para>卡片 id，发送卡片时会拿到</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("message_id")]
    public string MessageId { get; set; } = string.Empty;

    /// <summary>
    /// <para>状态类型，用于更新第一个action文字内容，枚举：<br> APPROVED:已同意<br>REJECTED:已拒绝<br>CANCELLED:已撤回<br>FORWARDED:已转交<br>ROLLBACK:已回退<br>ADD:已加签<br>DELETED:已删除<br>PROCESSED:已处理<br>CUSTOM:自定义按钮状态</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// <para>status=CUSTOM时可以自定义审批同意/拒绝后title状态</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("status_name")]
    public string? StatusName { get; set; }

    /// <summary>
    /// <para>status=CUSTOM时可以自定义审批同意/拒绝后“查看详情按钮名称”</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("detail_action_name")]
    public string? DetailActionName { get; set; }

    /// <summary>
    /// <para>i18n国际化文案</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_resources")]
    public string? I18nResources { get; set; }
}
