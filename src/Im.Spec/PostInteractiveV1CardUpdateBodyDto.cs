using Newtonsoft.Json;
namespace FeishuNetSdk.Im.Spec;
/// <summary>
/// 延时更新消息卡片 请求体
/// <para>用户对消息卡片完成交互操作后，对指定用户更新卡片内容，给与及时反馈。</para>
/// <para>接口ID：6907568030018469890</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/im-v1/message-card/delay-update-message-card</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMDO1YjLzgTN24yM4UjN</para>
/// </summary>
public record PostInteractiveV1CardUpdateBodyDto
{
    /// <summary>
    /// <para>用于更新卡片的token，不是tenant_access_token（可通过[卡片交互返回内容](https://open.feishu.cn/document/ukTMukTMukTM/uEzNwUjLxcDM14SM3ATN)获取）</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// <para>消息卡片的描述内容，具体参考[卡片结构](https://open.feishu.cn/document/ukTMukTMukTM/uEjNwUjLxYDM14SM2ATN)</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("card")]
    public object Card { get; set; } = new();

    /// <summary>
    /// <para>指定需要更新的用户，共享卡片默认更新所有人卡片，无需填写该字段。推荐使用 OpenID，获取方式可参考文档[如何获取 Open ID？](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("open_ids")]
    public string[]? OpenIds { get; set; }
}
