using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 更新客服信息 请求体
/// <para>更新客服状态等信息。</para>
/// <para>接口ID：6974742353936842753</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/agent-function/agent/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fagent%2fpatch</para>
/// </summary>
public record PatchHelpdeskV1AgentsByAgentIdBodyDto
{
    /// <summary>
    /// <para>agent status，1：在线；2：离线</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonProperty("status")]
    public int? Status { get; set; }
}
