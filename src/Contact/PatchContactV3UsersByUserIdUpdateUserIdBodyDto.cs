using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 更新用户ID 请求体
/// <para>此接口可用于更新用户ID(user_id)。新的用户ID(user_id)需要保证企业内未被占用。</para>
/// <para>接口ID：7257363132833300482</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/user/update_user_id</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fuser%2fupdate_user_id</para>
/// </summary>
public record PatchContactV3UsersByUserIdUpdateUserIdBodyDto
{
    /// <summary>
    /// <para>自定义新用户ID(user_id)</para>
    /// <para>必填：是</para>
    /// <para>示例值：3e3cf96b</para>
    /// </summary>
    [JsonProperty("new_user_id")]
    public string NewUserId { get; set; } = string.Empty;
}
