using Newtonsoft.Json;
namespace FeishuNetSdk.Mail;
/// <summary>
/// 批量删除邮件组成员 请求体
/// <para>一次请求可以删除一个邮件组中的多个成员。</para>
/// <para>接口ID：7187647376462872580</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mail-v1/mail-group/mailgroup-member/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fmailgroup-member%2fbatch_delete</para>
/// </summary>
public record DeleteMailV1MailgroupsByMailgroupIdMembersBatchDeleteBodyDto
{
    /// <summary>
    /// <para>本次调用删除的成员ID列表</para>
    /// <para>必填：否</para>
    /// <para>示例值：["xxxxxxx","yyyyyyy"]</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonProperty("member_id_list")]
    public string[]? MemberIdList { get; set; }
}
