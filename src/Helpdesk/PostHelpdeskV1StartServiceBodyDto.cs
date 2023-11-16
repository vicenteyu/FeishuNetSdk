namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建服务台对话 请求体
/// <para>该接口用于创建服务台对话。</para>
/// <para>接口ID：6955768699895726082</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/ticket-management/ticket/start_service</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fticket%2fstart_service</para>
/// </summary>
public record PostHelpdeskV1StartServiceBodyDto
{
    /// <summary>
    /// <para>是否直接进入人工(若appointed_agents填写了，该值为必填)</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("human_service")]
    public bool? HumanService { get; set; }

    /// <summary>
    /// <para>客服 open ids (获取方式参考[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get))，human_service需要为true</para>
    /// <para>必填：否</para>
    /// <para>示例值：[ou_7dab8a3d3cdcc9da365777c7ad535d62]</para>
    /// </summary>
    [JsonPropertyName("appointed_agents")]
    public string[]? AppointedAgents { get; set; }

    /// <summary>
    /// <para>用户 open id,(获取方式参考[获取单个用户信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/get))</para>
    /// <para>必填：是</para>
    /// <para>示例值：ou_7dab8a3d3cdcc9da365777c7ad535d62</para>
    /// </summary>
    [JsonPropertyName("open_id")]
    public string OpenId { get; set; } = string.Empty;

    /// <summary>
    /// <para>工单来源自定义信息，长度限制1024字符，如设置，[获取工单详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/helpdesk-v1/ticket/get)会返回此信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试自定义字段信息</para>
    /// </summary>
    [JsonPropertyName("customized_info")]
    public string? CustomizedInfo { get; set; }
}
