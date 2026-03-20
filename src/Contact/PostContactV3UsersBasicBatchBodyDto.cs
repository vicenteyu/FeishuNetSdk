namespace FeishuNetSdk.Contact;
/// <summary>
/// 通过 ID 获取用户姓名 请求体
/// <para>根据用户 ID 获取用户姓名，仅返回核心信息（姓名），不含扩展字段及敏感信息。</para>
/// <para>接口ID：7616208028610694095</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/basic_batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fbasic_batch</para>
/// </summary>
public record PostContactV3UsersBasicBatchBodyDto
{
    /// <summary>
    /// <para>用户 ID。ID 类型与查询参数 `user_id_type` 保持一致。</para>
    /// <para>必填：是</para>
    /// <para>最大长度：10</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = [];
}
